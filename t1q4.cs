using System;

namespace _24SOEIT13019_RUTVIK

{
    public class t1q3
    {
        static void Main(string[] args)
        {

            int x;

            Console.WriteLine("Enter Number : ");

            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
            string str = Console.ReadLine();
        }
    }
}



