using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHUSHI_23FOTCA1003.Demotest
{

    class Student
    {
        
        string Name;
        int Age;
        string City;

        public void inputdata()
        {
            Name = "khushi";
            Age = 20;
            City = "jetpur";

        }
        
        public void DisplayInfo()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("City: " + City);
        }
    }


    class Q3
    {
        public static void Main(String[] args)
        {
            Student student1 = new Student();
            student1.inputdata();
            student1.DisplayInfo();
        }
    }
}







  