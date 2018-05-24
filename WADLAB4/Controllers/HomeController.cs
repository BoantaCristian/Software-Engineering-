using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WADLAB4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            /*WADLAB4.Models.ApplicationDbContext db = WADLAB4.Models.ApplicationDbContext.Create();
            WADLAB4.Models.Event ev = new Models.Event();
            ev.Date = DateTime.Now.Date;
            ev.Category = 0;
            ev.Location = "???????????";
            ev.Name = "Contact";

            db.Events.Add(ev);
            db.SaveChanges();

            db.Dispose();
            */

            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "Your calendar page.";

            return View();
        }

        public ActionResult Cursuri()
        {
            ViewBag.Message = "Cursurile Dumneavoastra.";

            return View();
        }

        public ActionResult Note()
        {
            ViewBag.Message = "Notele Dumneavoastra.";

            return View();
        }

        public ActionResult Restante()
        {
            ViewBag.Message = "Restantele Dumneavoastra.";

            return View();
        }

        public ActionResult Studenti()
        {
            ViewBag.Message = "Lista Studentilor.";

            return View();
        }

        public void DeleteCurs()
        {
            var db = WADLAB4.Models.ApplicationDbContext.Create();
            //var idMat = db.Materii.Where(m => m.Nume == );
        }
    }
}