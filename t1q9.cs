using System;

namespace  _24SOEIT13019_RUTVIK
{
    class t1q9
    {
        static void Main(String[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            string result = "";

            foreach (char c in name)
                result += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);

            Console.WriteLine(result);
        }
    }
}