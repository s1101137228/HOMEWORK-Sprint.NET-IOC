
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();

            employee1.Id = "Fisrt";
            employee1.Name = "悟空";
            employee1.Age = 65;
            employees.Add(employee1);

            Employee employee2 = new Employee();

            employee2.Id = "Second";
            employee2.Name = "悟飯";
            employee2.Age = 40;
            employees.Add(employee2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {


            Employee employeeman = new Employee();

            employeeman.Id = "Fisrt";
            employeeman.Name = "悟空";
            employeeman.Age = 65;

            return employeeman;
        }

    }
}
