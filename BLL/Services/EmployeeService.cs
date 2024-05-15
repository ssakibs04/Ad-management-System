using BLL.DTO;
using DLL;
using DLL.Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static List<employeeDTO> Get()
        {
            try
            {
                var data = DataAccessFactory.EmployeeData().Read();
                var employeeDTOs = new List<employeeDTO>();
                foreach (var employee in data)
                {
                    var dto = new employeeDTO
                    {
                        id = employee.id,
                        name = employee.name,
                        age = employee.age,
                        email = employee.email,
                        designation = employee.designation
                    };
                    employeeDTOs.Add(dto);
                }
                return employeeDTOs;
            }
            catch (Exception ex)
            {
          
                throw;
            }
        }

        public static employeeDTO Get(int id)
        {
            try
            {
                var data = DataAccessFactory.EmployeeData().Read(id);
                var dto = new employeeDTO
                {
                    id = data.id,
                    name = data.name,
                    age = data.age,
                    email = data.email,
                    designation = data.designation
                };
                return dto;
            }
            catch (Exception ex)
            {
         
                throw;
            }
        }

        public static employeeDTO Create(employeeDTO employee)
        {
            try
            {
                var newEmployee = new Employee
                {
                    name = employee.name,
                    age = employee.age,
                    email = employee.email,
                    designation = employee.designation
                };
                var createdEmployee = DataAccessFactory.EmployeeData().Create(newEmployee);
                var createdDTO = new employeeDTO
                {
                    id = createdEmployee.id,
                    name = createdEmployee.name,
                    age = createdEmployee.age,
                    email = createdEmployee.email,
                    designation = createdEmployee.designation
                };
                return createdDTO;
            }
            catch (Exception ex)
            {
              
                throw;
            }
        }

        public static employeeDTO Update(int id, employeeDTO employee)
        {
            try
            {
                var existingEmployee = DataAccessFactory.EmployeeData().Read(id);
                if (existingEmployee == null)
                    throw new Exception("Employee not found");

                existingEmployee.name = employee.name;
                existingEmployee.age = employee.age;
                existingEmployee.email = employee.email;
                existingEmployee.designation = employee.designation;

                var updatedEmployee = DataAccessFactory.EmployeeData().Update(existingEmployee);
                var updatedDTO = new employeeDTO
                {
                    id = updatedEmployee.id,
                    name = updatedEmployee.name,
                    age = updatedEmployee.age,
                    email = updatedEmployee.email,
                    designation = updatedEmployee.designation
                };
                return updatedDTO;
            }
            catch (Exception ex)
            {
                // Handle exception
                throw;
            }
        }


        public static bool Delete(int id)
        {
            try
            {
                return DataAccessFactory.EmployeeData().Delete(id);
            }
            catch (Exception ex)
            {
            
                throw;
            }
        }
    }
}
