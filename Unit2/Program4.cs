using System;
namespace Unit2
{
    public class Program4
    {
        public static void MainX(string[] args)
        {
            string s = Console.ReadLine();
            var flip = 1;
            for (int i = 0; i <= s.Length; i++) {
                if (s[i] != s[s.Length - 1 - i])
                    flip = 0;
                    break;
            }
            Console.WriteLine(flip);
        }
    }
}
