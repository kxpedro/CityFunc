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
     
        public ActionResult _partialCreate()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Municipio m)
        {
            try
            {               
                //INSERT
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        } 
        
    }
}
