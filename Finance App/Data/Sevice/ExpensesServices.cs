using Finance_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Finance_App.Data.Sevice
{
    public class ExpensesServices : IExpensiveService
    {
        private readonly FinanceAppContext _context;
        public ExpensesServices(FinanceAppContext context)
        {
            _context = context;
        }

        public async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);     
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        Task<Expense> IExpensiveService.GetExpenseById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
