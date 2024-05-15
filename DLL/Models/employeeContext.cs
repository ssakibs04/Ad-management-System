using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class employeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set;}
    }
}
