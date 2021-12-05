using Microsoft.EntityFrameworkCore;
using offerpool_bl.Models;

namespace offerpool_bl.Data
{

    public class DataContext: DbContext
    {
        public DbSet<Offer> Offer {get; set;} = null!;

        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

    }
    
}