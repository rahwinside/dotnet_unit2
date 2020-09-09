using System;
using System.Text;

namespace Unit2
{
    public class Program5
    {
        public static void MainX(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < str.Length; i++) {
                if ((int)str[i] >= 97 && (int)str[i] <= 122)
                    str[i] = (char)((int)str[i] - 32);
            }
            Console.WriteLine(str);
        }
    }
}
