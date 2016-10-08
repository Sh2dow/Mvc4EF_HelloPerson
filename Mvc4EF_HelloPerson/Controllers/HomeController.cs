using Mvc4EF_HelloPerson.Models;
using Mvc4EF_HelloPerson.Repositories;
using System.Web.Mvc;

namespace Mvc4EF_HelloPerson.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext db = new PersonContext();
        public ActionResult Index()
        {
            ViewBag.Message = "ASP.NET Framework 4.5 + razor + MVC4 + MSSQL + EF";

            if (Request.IsAjaxRequest())
                return PartialView("_CreatePartial");

            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(Person person)
        {
            DbSave(person);
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult AddPersonAjax(Person person)
        {
            DbSave(person);
            ModelState.Clear();
            return Json(person);
        }

        private void DbSave(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Personnel.Add(person);
                db.SaveChanges();
            }
        }

    }
}
