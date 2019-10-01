using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string age = "";
            string address = "";
            string contact = "";
            Console.WriteLine("Please Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your Age: ");
            age = Console.ReadLine();
            Console.WriteLine("Please Enter your Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Please Enter your Contact NO: ");
            contact = Console.ReadLine();
            Console.WriteLine("Name: " + name + "\n" + "Age: " + age + "\n" + "Address: " + address + "\n" + "Contact No: " + contact + "\n");
            Console.ReadKey();






        }
    }
}
