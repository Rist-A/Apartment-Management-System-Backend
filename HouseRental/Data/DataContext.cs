using HouseRental.Modules;
using Microsoft.EntityFrameworkCore;

namespace HouseRental.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
            { 

             }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }

    }
}
