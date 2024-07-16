using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Tong cua mang la: " + SumArray(a));
            Console.ReadLine();
        }

        static int SumArray(int[] a)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            return sum;
        }
    }
}