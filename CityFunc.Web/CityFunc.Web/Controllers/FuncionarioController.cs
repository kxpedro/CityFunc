using CityFunc.Web.Entity.Context;
using CityFunc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityFunc.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _partialSearch()
        {
            try
            {
                using (var dbcontext = new Context())
                {
                    var list = dbcontext.Funcionario.ToList();
                    return PartialView(list);
                }                
            }
            catch (Exception e)
            {
                return PartialView();
            }            
        }

        [HttpPost]
        public ActionResult _partialSearch(string text)
        {
            try
            {
                using (var dbcontext = new Context())
                {
                    ViewBag.SearchText = dbcontext.Funcionario.Where(x => x.Nome.ToLower().Contains(text.ToLower()) || x.UF.ToLower().Contains(text.ToLower()) || x.Municipio.ToLower().Contains(text.ToLower()) ).ToList();

                    return RedirectToAction("Index");
                }                
            }
            catch(Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public PartialViewResult _partialCreate()
        {
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult Create(Funcionario f, HttpPostedFileBase file)
        {
            try
            {
                using (var dbcontext = new Context())
                {
                    if (file != null)
                    {                   
                        string img = System.IO.Path.GetFileName(file.FileName);
                        string path = System.IO.Path.Combine(Server.MapPath("~/Pictures"), img);
                        file.SaveAs(path);

                        f.Foto = path;
                    }

                    //if (file != null)
                    //{
                    //    file.SaveAs(HttpContext.Server.MapPath("~/Pictures/") + file.FileName);
                    //    f.Foto = file.FileName;
                    //}

                    dbcontext.Funcionario.Add(f);
                    dbcontext.SaveChanges();
                }
                return View();
            }
            catch(Exception e)
            {
                return View();
            }
        } 
        
    }
}
