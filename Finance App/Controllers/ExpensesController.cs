using Finance_App.Data;
using Finance_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finance_App.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly FinanceAppContext context;
        public ExpensesController(FinanceAppContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var expenses = context.Expenses.ToList();
            return View(expenses);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                context.Expenses.Add(expense);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
