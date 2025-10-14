using Introduction.Models;
using Microsoft.EntityFrameworkCore;
namespace Introduction.Data
{

    // Step - 1
    public class TestDataDBContext : DbContext  // to use this DbContext, should use the Microsoft.EntityFramworkCore;  namespace.
    {
        // Step - 2
        // whenever the config is loaded in program.cs file, this options contains the sqlsever related details.
        public TestDataDBContext(DbContextOptions<TestDataDBContext> options) : base(options)
        {

        }


        // Step - 4
        //models creation[design this model by using the DbSet<>]
        public DbSet<Customer> Customers { get; set; }



        public DbSet<Book> Books { get; set; }
        // Step - 3
        //virtual method of DbContext. [ in this method, we will map classes/models] which will convert the classes/models into the data tables.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
