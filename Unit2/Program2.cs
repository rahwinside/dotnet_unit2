using System;
namespace Unit2
{
    public class Program2
    {
        public static void MainX(string[] args)
        {
            string x = Console.ReadLine();
            int count = 0;
            try {
                while (x[count] != null) {
                    count++;
                }
            }
            catch (System.IndexOutOfRangeException) {
                Console.WriteLine(count);
            }
        }
    }
}
