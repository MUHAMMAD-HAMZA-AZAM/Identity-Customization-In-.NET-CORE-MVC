using System;
using Admin_Portal.Data;
using Admin_Portal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Admin_Portal.Areas.Identity.IdentityHostingStartup))]
namespace Admin_Portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CustomDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdminPortalContextConnection")));

                
            });
        }
    }
}