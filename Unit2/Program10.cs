using System;
using System.Text;

namespace Unit2
{
    public class Program10
    {
        public static void MainX(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += (int)str[i];
            }
            Console.WriteLine(sum);
        }
    }
}
