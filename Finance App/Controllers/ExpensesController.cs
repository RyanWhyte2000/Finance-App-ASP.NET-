using Finance_App.Data;
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
    }
}
