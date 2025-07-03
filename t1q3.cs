using System;
namespace _24SOEIT13019_RUTVIK
{
	public class t1q3
	{
		static void Main(String[] args)
		{
			Console.WriteLine("Enter A number ");
			int a = Convert.ToInt32(Console.ReadLine());
			if (a % 2 == 0)
			{
				Console.WriteLine("Number is Even");
			}
			else
			{
				Console.WriteLine("Number is Odd");
			}
		}
	}
}