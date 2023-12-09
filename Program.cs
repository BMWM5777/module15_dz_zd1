using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_dz
{
    class Program
    {
        static void Main()
        {
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            Console.WriteLine("Методы класса Console:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
