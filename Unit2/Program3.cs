using System;
using System.Text;

namespace Unit2
{
    public class Program3 {
        public static void MainX(string[] args)
        {

            StringBuilder str = new StringBuilder(Console.ReadLine());
            char old = Console.ReadLine()[0];
            char newC = Console.ReadLine()[0];

            int count = 0;
            try
            {
                while (str[count] != null)
                {
                    if (str[count] == old)
                        str[count] = newC;
                    count++;
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine(str);
            }
        }
    }
}
