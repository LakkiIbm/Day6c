using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFirstin
    {
        string Name { get; set; }
        void firstMethod();
    }
    interface ISecondin
    {
        void secMethod();
    }
    interface IThirdin
    {
        void thMethod();
    }

    class MyClass: IFirstin, ISecondin, IThirdin
    {
        public string Name { get; set; }
        public void firstMethod()
        {
            Console.WriteLine("First method");
        }
        public void secMethod()
        {
            Console.WriteLine("Second method");
        }
        public void thMethod()
        {
            Console.WriteLine("Third method");
        }
    }
    class main
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Name = "Lakshita garg";
            myClass.firstMethod();
            myClass.secMethod();
            myClass.thMethod();
            Console.WriteLine(myClass.Name);
            Console.ReadLine();
        }
    }

}
