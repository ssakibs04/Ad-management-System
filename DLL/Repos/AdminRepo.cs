using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DLL.Repos
{
    public class AdminRepo : Repo, IRepo<Employee, int, Employee>
    {
        public Employee Create(Employee obj)
        {
            db.Employees.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var employee = Read(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Employee> Read()
        {
            return db.Employees.ToList();
        }

        public Employee Read(int id)
        {
            return db.Employees.FirstOrDefault(e => e.id == id);
        }

        public Employee Update(Employee obj)
        {
            var existingEmployee = Read(obj.id);
            if (existingEmployee != null)
            {
                db.Entry(existingEmployee).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return obj;
            }
            return null;
        }
    }
}
