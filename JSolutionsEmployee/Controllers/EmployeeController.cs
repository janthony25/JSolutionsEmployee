using JSolutionsEmployee.Data;
using JSolutionsEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace JSolutionsEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> obj = _db.employees;
            return View(obj);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            _db.employees.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.employees.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }



        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _db.employees.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }


    }
}
