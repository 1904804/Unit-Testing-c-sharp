using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
        }

        public static void Retun(int menuSelection)
        {
            switch (menuSelection)
                {

                case 1:
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;


                }
        }
    }
}
