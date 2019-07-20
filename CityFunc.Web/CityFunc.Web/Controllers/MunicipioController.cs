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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _partialSearch()
        {
            return View();
        }

        public ActionResult Search(string text)
        {
            try
            {
                //SELECT
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
     
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
                return RedirectToAction("_partialCreate");
            }
            catch(Exception e)
            {
                return View();
            }
        } 
        
    }
}
