using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasic
{
    class Employee
    {
        public int ID;
        public string name;
        public int salary;
        public int experience;

        public  static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if(employee.experience > 5)
                {
                    Console.WriteLine(employee.name + " - Promote");
                }
            }
        }
    }
}
