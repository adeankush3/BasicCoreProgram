using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programming");
            FibonacciSeries fibo=new FibonacciSeries();
            fibo.FibonacciCreate();
            fibo.DetermineDayOfWeek();
        }
    }
}
