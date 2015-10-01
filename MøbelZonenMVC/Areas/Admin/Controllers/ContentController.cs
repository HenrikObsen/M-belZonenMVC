using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ;




namespace MøbelZonenMVC.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        // GET: Admin/Content
        IndholdFac IF = new IndholdFac();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditContent(int ID)
        {
         
            return View(IF.Get(ID));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditContent(Indhold page, string tekst)
        {

            if (ModelState.IsValid)
            {
                IF.Update(page);
                return RedirectToAction("Index/" + page.ID + "/");
            }

            return View("Index");
        }
    }
}