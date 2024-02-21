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
    }
}
