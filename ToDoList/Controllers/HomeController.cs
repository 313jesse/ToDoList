using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;


namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ToDoListEntities ORM = new ToDoListEntities();
            ViewBag.newtask = ORM.Tasks.ToList();
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

        public ActionResult NewTask()
        {
            return View();
        }

        public ActionResult SaveNewTask(Task newtask)
        {
            ToDoListEntities ORM = new ToDoListEntities();
            ORM.Tasks.Add(newtask);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTask(int taskID)
        {
            ToDoListEntities ORM = new ToDoListEntities();
            Task TaskToDelete = ORM.Tasks.Find(taskID);

            ORM.Tasks.Remove(TaskToDelete);
            ORM.SaveChanges();
            return RedirectToAction("Index");


        }
        



    }
}