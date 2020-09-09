using System;
using System.Text;

namespace Unit2
{
    public class Program13
    {
        public static void MainX(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            int prod = 1;
            for (int i = 0; i < str.Length; i++)
            {
                prod *= (int)str[i];
            }
            Console.WriteLine(prod);
        }
    }
}
