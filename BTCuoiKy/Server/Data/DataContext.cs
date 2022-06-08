using Microsoft.EntityFrameworkCore;

namespace BTCuoiKy.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<GameModel> Games { get; set; }
        public DbSet<SinhvienModel> SinhvienCD { get; set; }
    }
}
