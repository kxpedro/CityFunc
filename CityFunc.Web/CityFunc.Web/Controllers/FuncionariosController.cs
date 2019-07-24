using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using CityFunc.Web.Entity.Context;
using CityFunc.Web.Models;

namespace CityFunc.Web.Controllers
{
    public class FuncionariosController : Controller
    {
        private Context db = new Context();

        public ActionResult Index()
        {
            return View(db.Funcionario.ToList());
        }

        public PartialViewResult _partialSearch(string text)
        {
            if (text != null)
            {
                var searchList = db.Funcionario.Where(x => x.Nome.Contains(text.ToLower()) || x.UF.Contains(text.ToLower()) || x.Municipio.Contains(text.ToLower()) ).ToList();
                return PartialView(searchList);
            }
            else
            {
                var list = db.Funcionario.ToList();
                return PartialView(list);
            }
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        public ActionResult Create()
        {
            ViewBag.ListaDeUF = db.Municipio.Select(x => x.UF).Distinct().ToList();
            ViewBag.ListaDeCidade = db.Municipio.Select(x => x.Nome).Distinct().ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario funcionario, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string img = System.IO.Path.GetFileName(file.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("/Pictures"), img);
                    file.SaveAs(path);

                    funcionario.Foto = img;
                }
                else
                {
                    funcionario.Foto = "#";
                }

                var apenasDigitos = new Regex(@"[^\d]");

                funcionario.CPF = apenasDigitos.Replace(funcionario.CPF, "");
                funcionario.CEP = apenasDigitos.Replace(funcionario.CEP, "");
                funcionario.Telefone = apenasDigitos.Replace(funcionario.Telefone, "");

                db.Funcionario.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.ListaDeUF = db.Municipio.Select(x => x.UF).Distinct().ToList();
            ViewBag.ListaDeCidade = db.Municipio.Select(x => x.Nome).Distinct().ToList();

            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Funcionario funcionario, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string img = System.IO.Path.GetFileName(file.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("/Pictures"), img);
                    file.SaveAs(path);

                    funcionario.Foto = img;
                }
                else
                {
                    funcionario.Foto = "#";
                }

                var apenasDigitos = new Regex(@"[^\d]");

                funcionario.CPF = apenasDigitos.Replace(funcionario.CPF, "");
                funcionario.CEP = apenasDigitos.Replace(funcionario.CEP, "");
                funcionario.Telefone = apenasDigitos.Replace(funcionario.Telefone, "");

                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionario.Find(id);
            db.Funcionario.Remove(funcionario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
