using System;
using System.Text;

namespace Unit2
{
    public class Program9
    {
        public static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (((int)str[i] >= 65 && (int)str[i] <= 90) || ((int)str[i] >= 97 && (int)str[i] <= 122))
                    Console.Write(str[i]);
            }
        }
    }
}
