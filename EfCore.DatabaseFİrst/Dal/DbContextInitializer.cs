using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.DatabaseFirst.Dal
{
    public class DbContextInitializer
    {   
        // appsettings.json'daki key ve value okuyabilmek için
        public static IConfigurationRoot Configuration;
        // veritabanı ile ilgili optionslar
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder;

        public static void Build()
        {   

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            // options

            //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));

        }


    }
}
