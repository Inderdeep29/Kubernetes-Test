using Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Content.Helpers
{
	public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) :base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    base.OnConfiguring(options);
        //    // connect to postgres with connection string from app settings
        //    options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"))
        //        .UseSnakeCaseNamingConvention();
        //}

        public DbSet<Adcvd> Adcvds { get; set; }
        public DbSet<CountryList> CountryLists { get; set; }

    }
}
