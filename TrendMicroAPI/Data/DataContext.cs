using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data.Entity;
using System.Text.Json.Serialization;
using TrendMicroAPI.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace TrendMicroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<Customer> Customers { get; set; }
    }

    public class CustomerDbInitializer
    {
        public static async Task SeedData(DataContext context)
        {
            if(!context.Customers.Any())
            {
                var customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(@"seed" + Path.DirectorySeparatorChar + "MOCK_DATA.json"));
                context.AddRange(customers);
                context.SaveChanges();
            }
        }
    }
}
