using Finance_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Finance_App.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options) { }

       public DbSet<Expense> Expenses { get; set; }
    }
}
