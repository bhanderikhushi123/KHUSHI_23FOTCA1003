using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{


    class Employee
    {
        int EmployeeId;
        string Name;
        double Salary;

        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public void GiveRaise()
        {
            Salary += Salary * 0.10;
        }

        public void inputdata()
        {
            EmployeeId = 101;
            Name = " khushi";
            Salary = 50000;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Monthly Salary: " + Salary);
            Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
        }
    }
    class Q7
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.inputdata();
            emp.DisplayInfo();
        }
    }
}










