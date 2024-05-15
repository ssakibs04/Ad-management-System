using DLL.Models;

namespace DLL.Models
{
    public class Repo
    {
        internal employeeContext db;
        internal Repo()
        {
            db = new employeeContext();
        }
    }
}
