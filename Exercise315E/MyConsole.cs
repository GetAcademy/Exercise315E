using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise315E
{
    internal class MyConsole
    {
        public static int Ask(string question)
        {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
