using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasic
{
    public class Employee
    {
        public int ID;
        public string name;
        public int salary;
        public int experience;

        public  static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligiblePromotable)
        {
            foreach(Employee employee in employeeList)
            {
                if(isEligiblePromotable(employee))
                {
                    Console.WriteLine(employee.name + " - Promote");
                    
                }
            }
        }
        
        public static void NewSalary(List<Employee> employeeList, IsPromotable isEligiblePromotable)
        {
            foreach (Employee employee in employeeList)
            {
                if (isEligiblePromotable(employee))
                {
                    Console.WriteLine(employee.name + " New Salary - {0} ",  Convert.ToInt32(employee.salary) + 100000  );
                }
            }
        }
    }
}
