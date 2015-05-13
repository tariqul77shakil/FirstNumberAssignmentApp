using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lower Limit");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper Limit");
            int UpperLImit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAll Integer between "+lowerLimit+" and "+UpperLImit+"\n");
            for (int i = lowerLimit; i <= UpperLImit; i++)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
