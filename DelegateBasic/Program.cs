using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasic
{
    public delegate void HelloFuncDelegate(string strMessage);
    public delegate bool IsPromotable(Employee emp);
    public delegate bool IsPromotable1(Employee emp);
    class Program
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, name = "Mary", salary = 100000, experience = 3 });
            empList.Add(new Employee() { ID = 102, name = "John", salary = 60000, experience = 6 }); 
            empList.Add(new Employee() { ID = 103, name = "Mike", salary = 40000, experience = 7 });
            empList.Add(new Employee() { ID = 104, name = "Tomm", salary = 30000, experience = 2 });

            IsPromotable isPromotable = new IsPromotable(Promote);
     

            Employee.PromoteEmployee(empList, isPromotable);
            Console.WriteLine("********************************************");
            Employee.NewSalary(empList, emp => emp.salary <= 50000);
        }

        public static bool Promote(Employee employee)
        {
            return employee.experience >= 5 ? true : false;
        }

        //public static bool NewSalary(Employee employee)
        //{
        //    return employee.salary >= 50000 ? true : false;
        //}
        static void Main(string[] args)
        {
            HelloFuncDelegate del = new HelloFuncDelegate(Hello);
            del("Hello from Delegate");
         
            Console.ReadKey();
        }
    }
}
