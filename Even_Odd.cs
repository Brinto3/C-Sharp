using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = new int[6];
            Console.Write("Enter 6 integer digits:");
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Array:");
            foreach (int digits in arr ){
                if (digits % 2 == 0)
                {
                    Console.WriteLine($"{digits} Even");
                }
                else
                {
                    Console.WriteLine($"{digits} Odd");
                }
                Console.WriteLine(digits);
            }
            Console.ReadLine();
        }
    }
}
