using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Nomonde";
            int age;

            name = "Nomonde";
            age = 15;

            Console.WriteLine(" There was once a girl called " +  name);
            Console.WriteLine(name  + " was " +  age +  " years of age ");
            Console.WriteLine(name  +  " really never liked her name ");

            age = 19;
            name = "Monde";

            Console.WriteLine("At age  " +  age  + " she changed her name to " +  name);
            Console.ReadLine();
        }
    }
}
