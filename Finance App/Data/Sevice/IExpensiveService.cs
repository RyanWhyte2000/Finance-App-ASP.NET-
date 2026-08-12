using Finance_App.Models;

namespace Finance_App.Data.Sevice
{
    public interface IExpensiveService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task<Expense> GetExpenseById(int id);
        Task Add(Expense expense);
        Task Update(Expense expense);
        Task Delete(int id);
    }
}
