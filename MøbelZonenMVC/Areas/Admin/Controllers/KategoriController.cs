using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ;

namespace MøbelZonenMVC.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Admin/Kategori
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddKatView()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddKat()
        {
            Kategori k = new Kategori();
            KategoriFac kf = new KategoriFac();

            k.Navn = Request["navn"];
            k.Sortering = int.Parse(Request["sortering"]);
            kf.Insert(k);

            return View("AddKatView");
        }
    }
}