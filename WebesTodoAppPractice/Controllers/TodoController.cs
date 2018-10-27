using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebesTodoAppPractice.Models;

namespace WebesTodoAppPractice.Controllers
{
    public class TodoController : Controller    
    {
        public ActionResult Index()
        {
            var Lista = new List<TodoItem>();

            Lista.Add(new TodoItem() { Name = "Só", Done = true });
            Lista.Add(new TodoItem() { Name = "Paprika", Done = false });
            Lista.Add(new TodoItem() { Name = "Bors", Done = true });
            Lista.Add(new TodoItem() { Name = "Tészta", Done = false });
            Lista.Add(new TodoItem() { Name = "Bor", Done = true });

            return View(Lista);
        }
    }
}