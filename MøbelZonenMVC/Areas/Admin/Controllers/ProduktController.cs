using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MøbelZonenMVC.Controllers;
using RepoMZ;

namespace MøbelZonenMVC.Areas.Admin.Controllers
{
    public class ProduktController : Controller
    {
        ProduktFac pf = new ProduktFac();
        // GET: Admin/Produkt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddProd(HttpPostedFile file)
        {
            var u = new Uploader();
            var p = new Produkt();
            string path = Request.PhysicalApplicationPath + "images/";
            p.KatID = int.Parse(Request["ddlKat"]);

            for (var i = 0; i < Request.Files.Count; i++)
            {
                var postedFile = Request.Files[i];
                p.Billede = Path.GetFileName(u.UploadImage(postedFile, path, 0, true));
                
            }
           
             
            p.Navn = Request["txtNavn"];
            p.Pris = decimal.Parse(Request["txtPris"]);
            p.Tekst = Request["txtTekst"];

            pf.Insert(p);

            return View("AddProduct");
        }
    }
}