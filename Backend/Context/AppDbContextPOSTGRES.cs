using Microsoft.EntityFrameworkCore;
using ShinRoll.Models;

namespace Context
{
    public class AppDbContextPOSTGRES : DbContext
    {

        public AppDbContextPOSTGRES(DbContextOptions<AppDbContextPOSTGRES> options)
            : base(options) { }

        public DbSet<Character> characters { get; set; }



    }
}
