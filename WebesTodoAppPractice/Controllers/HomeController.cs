using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebesTodoAppPractice.Models;

namespace WebesTodoAppPractice.Controllers
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

            return View();
        }

        public ActionResult TodoList()
        {
            var Lista = new List<TodoItem>();

            Lista.Add(new TodoItem() { Name = "Só", Done=true});
            Lista.Add(new TodoItem() { Name = "Paprika", Done = false });
            Lista.Add(new TodoItem() { Name = "Bors", Done = true });
            Lista.Add(new TodoItem() { Name = "Tészta", Done = false });
            Lista.Add(new TodoItem() { Name = "Bor", Done = true });

            return View(Lista);
        }
    }
}