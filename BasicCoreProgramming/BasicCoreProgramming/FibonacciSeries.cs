using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public  class FibonacciSeries
    {
        public void FibonacciCreate()
        {
            Console.WriteLine("Enter The no. Of Element Fibonacci Series");
            int num =Convert.ToInt32(Console.ReadLine());
            int [] fibonacciArray = new int[num];
            fibonacciArray[0] = 1;
            fibonacciArray[1] = 1;
            for  (int i = 2; i < num; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(fibonacciArray[i] + "");
            }
            Console.WriteLine("\n");
        }
    }
}
