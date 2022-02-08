using System;

namespace CheckPalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The String : ");
            string s = Console.ReadLine();
            Console.WriteLine(CheckPal(s));
        }
        public static bool CheckPal(String s)
        {
            if (s == null)
                return false;
            if(s.Length <= 1)
            {
                return true;
            }
            else
            {
                if (s[0] != s[s.Length - 1])
                {
                    return false;
                }
                else
                {
                    return CheckPal(s.Substring(1, s.Length - 2));
                }
            }
        }
    }
}
