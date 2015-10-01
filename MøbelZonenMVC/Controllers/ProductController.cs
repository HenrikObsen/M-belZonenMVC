using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ;

namespace MøbelZonenMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProduktFac pf = new ProduktFac();
        public ActionResult Index(int ID)
        {
            ViewBag.ID = ID;
            return View(pf.GetBy("KatID",ID));
        }

        public ActionResult Search()
        {
            var keyWord = Request["Search"];
            return View(pf.Search(keyWord));
        }
    }
}