using System;
using Admin.IDP.Data;
using Admin.IDP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Admin.IDP.Areas.Identity.IdentityHostingStartup))]
namespace Admin.IDP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        //context.Configuration.GetConnectionString("TaxCollectorAuthContextConnection")));
                        context.Configuration.GetConnectionString("DefaultConnection")));
                //builder.ConfigureServices((context, services) => {
            });
        }
    }
}