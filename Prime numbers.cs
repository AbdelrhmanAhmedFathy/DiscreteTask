using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, x;

            Console.WriteLine("enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n2");
            int n2 = int.Parse(Console.ReadLine());

            num = n1;
            while (num<=n2)
            {
                x = 0;
                for (i=2; i<num; i++)
                {
                    if (num%i==0)
                    {
                        x = 1;
                        break;
                    }
                }
                if (x == 0)
                    Console.WriteLine(num);
                num++;
            }
            return;
            Console.ReadKey();
        }
    }
}
