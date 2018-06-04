using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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

        public void AddGrade(object sender, EventArgs e)
        {

            WADLAB4.Models.Note nota = new Models.Note();

            nota.Materie = Request.Form["nMat"];
            nota.Student = long.Parse(Request.Form["cnp"]);
            nota.Calificativ = Int32.Parse(Request.Form["cnota"]);

            var db = WADLAB4.Models.ApplicationDbContext.Create();

            db.Grades.Add(nota);
            db.SaveChanges();

            db.Dispose();
        }

        public void AddCurs(object sender, EventArgs e)
        {
            WADLAB4.Models.Materie mat = new Models.Materie();

            mat.An = Int32.Parse(Request.Form["cname"]);
            mat.Credite = Int32.Parse(Request.Form["ccred"]);
            mat.IDSpec = Int32.Parse(Request.Form["cspec"]);
            mat.Nume = Request.Form["cname"];
            mat.Sem = Int32.Parse(Request.Form["csem"]);
            mat.TotalOre = Int32.Parse(Request.Form["core"]);

            var db = WADLAB4.Models.ApplicationDbContext.Create();
            db.Materii.Add(mat);
            db.SaveChanges();
            db.Dispose();
        }

        public void AddNew(object sender, EventArgs e)
        {
            WADLAB4.Models.News noutate = new Models.News();

            noutate.link = Request.Form["link"];
            noutate.title = Request.Form["title"];
            noutate.message = Request.Form["mes"];

            var db = WADLAB4.Models.ApplicationDbContext.Create();

            db.Noutati.Add(noutate);
            db.SaveChanges();
            db.Dispose();
        }
    }
}