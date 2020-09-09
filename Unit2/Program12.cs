using System;
using System.Text;

namespace Unit2
{
    public class Program12
    {
        public static void MainX(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] >= 65 && (int)str[i] <= 90)
                    Console.Write(str[i]);
            }
        }
    }
}
