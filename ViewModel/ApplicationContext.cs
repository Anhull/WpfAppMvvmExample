using Microsoft.EntityFrameworkCore;
using WpfAppMvvm.Model;

namespace WpfAppMvvm
{
    class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=64534231;database=test2;");
        }
    }
}