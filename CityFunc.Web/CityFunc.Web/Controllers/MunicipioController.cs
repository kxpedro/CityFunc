using CityFunc.Web.Entity.Context;
using CityFunc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityFunc.Web.Controllers
{
    public class MunicipioController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _partialSearch()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult _partialSearchResult(string text)
        {
            try
            {
                using (var dbcontext = new Context())
                {
                    var list = dbcontext.Municipio.Where(x => x.Nome.ToLower().Contains(text.ToLower()) || x.UF.ToLower().Contains(text.ToLower())).ToList();
                    ViewBag.SearchText = list;

                    return RedirectToAction("_partialSearch");
                }                
            }
            catch(Exception e)
            {
                return RedirectToAction("Index","Home");
            }
        }

        [HttpGet]
        public PartialViewResult _partialCreate()
        {
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult Create(Municipio m)
        {
            try
            {
                using (var dbcontext = new Context())
                {
                    dbcontext.Municipio.Add(m);
                    dbcontext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return RedirectToAction("Index");
            }
        } 
        
    }
}
