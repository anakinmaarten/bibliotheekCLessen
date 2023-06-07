using bibliotheek.WPF.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.Database
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[]? args = null)
        {
            // sets up and initiates the MyDbContext file which will allow connection and changing of the database
            string defaultConnection = Settings.Default.ConnectionStrings;
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(defaultConnection);
            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
