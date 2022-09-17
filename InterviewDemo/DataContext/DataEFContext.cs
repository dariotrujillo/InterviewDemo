using InterviewDemo.Abstractions;
using InterviewDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace InterviewDemo.DataContext
{
    public class DataEFContext: DbContext
    {
        public DataEFContext(DbContextOptions options) : base(options) { }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
