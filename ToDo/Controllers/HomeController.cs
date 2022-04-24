using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private IAdmin admin = null;
        private IToDo todo = null;
        public HomeController(IAdmin admin, IToDo todo)
        {
            this.admin = admin;
            this.todo = todo;
        }
        public ActionResult Index()
        {
            int count = admin.GetTotalContact();
            bool data = todo.IsToDo();
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

            return View();
        }
    }
}