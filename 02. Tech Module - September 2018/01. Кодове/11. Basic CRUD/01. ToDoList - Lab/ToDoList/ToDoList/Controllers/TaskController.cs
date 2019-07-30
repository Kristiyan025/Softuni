namespace ToDoList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using ToDoList.Data;
    using ToDoList.Models;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new TasksDbContext())
            {
                var tasks = db.Tasks.ToList();
                return View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            using (var db = new TasksDbContext())
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Task newTask)
        {
            using(var db = new TasksDbContext())
            {
                if (!ModelState.IsValid)
                {
                    TempData["ErrorMessage"] = "The title and comment are required!";
                    return View();
                }
                db.Add(newTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using(var db = new TasksDbContext())
            {
                Task oldTask = db.Tasks.Find(id);
                return View(oldTask);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task oldTask)
        {
            using(var db = new TasksDbContext())
            {
                db.Tasks.Remove(oldTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using(var db = new TasksDbContext())
            {
                var task = db.Tasks.Find(id);
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task newTask)
        {
            using(var db = new TasksDbContext())
            {
                db.Tasks.Update(newTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}