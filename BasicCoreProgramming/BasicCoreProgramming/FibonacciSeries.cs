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
        public void DetermineDayOfWeek()
        {
            Console.WriteLine("Enter any year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday\n");
                    break;

                case 1:
                    Console.WriteLine("Monday\n");
                    break;

                case 2:
                    Console.WriteLine("Tuesday\n");
                    break;

                case 3:
                    Console.WriteLine("Wednesday\n");
                    break;

                case 4:
                    Console.WriteLine("Thursday\n");
                    break;

                case 5:
                    Console.WriteLine("Friday\n");
                    break;

                case 6:
                    Console.WriteLine("Saturday\n");
                    break;
            }

        }

    }
}
