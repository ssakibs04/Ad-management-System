namespace DLL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DLL.Models.employeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DLL.Models.employeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Employees.AddOrUpdate(new Models.Employee
                {
                    name = Guid.NewGuid().ToString().Substring(0, 15),
                    age = 25, 
                    email = "example@example.com", 
                    designation = "Developer" 
                });
            }

            context.SaveChanges(); 

        }
    }
    }

