using Microsoft.EntityFrameworkCore;

namespace L01WebApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        //Khai báo mapping với table
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
    }
}
