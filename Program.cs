using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number:");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 2; i < Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("This number is not prime");
                    return;
                }
            }Console.WriteLine("This number is  prime");
        }
       
    }
}  
