using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ;

namespace MøbelZonenMVC.Controllers
{
    public class HomeController : Controller
    {
        KontaktFac kf = new KontaktFac();
        KategoriFac katF = new KategoriFac();
        Kontakt k = new Kontakt();
        // GET: Home
        public ActionResult Index()
        {
            k = kf.Get(1);
            @ViewBag.Adress = k.Navn + ", " + k.Adresse + ", " + k.PostNr + " " + k.Bynavn + ", " + k.Tlf + ", " + k.Email;
           
            // foreach (var kat in katF.GetAll())
            //{
            // @ViewBag.Kat += "<a href=\"ProduktListe.aspx?katid=" + kat.ID + "\" class=\"Menu\">" + kat.Navn + "</a><br/>";
            //}

            return View(katF.GetAll());
        }
    }
}