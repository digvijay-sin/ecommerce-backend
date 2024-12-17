using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.FileProviders;


//using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            string basePath = Directory.GetCurrentDirectory();

            string path = Path.Join(basePath, @"..\ecommerce-app-backend\");

            System.Diagnostics.Debug.WriteLine(basePath);

                                                                                                                                                                                                
            var builder = new ConfigurationBuilder()
                 .Add(new JsonConfigurationSource
                 {
                     Path = "appsettings.json",
                     Optional = true,
                     ReloadOnChange = true,
                     FileProvider = new PhysicalFileProvider(path)
                 });
                                                                                                                                                                            
            var configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
 
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
