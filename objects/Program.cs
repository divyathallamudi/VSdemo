using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects
{
    class Employee  /*type*/
    {
        //private int age; /*field*, ideally not public for encapsulation*/
        //public int myage(int setage)
        //{
        //    age = setage;
        //    return age;
        //}
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //        }
        public int Age { get; set; } /*short form to above get, set and declaring variable age*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee Dave = new Employee(); /*creating instance of class*/
            //Dave.age = 25;
            //Console.WriteLine("Dave's age is {0}", D ave.age);
            //Console.ReadLine();
            Employee Dave = new Employee();
            //int Daveage = Dave.myage(35);
            //Console.WriteLine("Dave's age is {0}", Daveage);
            //Console.ReadLine();
            Dave.Age = 25;
            Console.WriteLine("Dave's age is {0}", Dave.Age);
            Console.ReadLine();
        }
    }
}
