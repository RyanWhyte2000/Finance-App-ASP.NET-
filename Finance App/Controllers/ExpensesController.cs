using Finance_App.Data;
using Finance_App.Data.Sevice;
using Finance_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finance_App.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensiveService  _expensiveService;
        public ExpensesController(IExpensiveService expensiveService)
        {
            _expensiveService = expensiveService;
        }
        public async Task <IActionResult> Index()
        {
            var expenses = await _expensiveService.GetAll();
            return View(expenses);
        }
        public IActionResult Create()
        {
            return View();
        }
         
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
               
                await  _expensiveService.Add(expense);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
