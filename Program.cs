using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.Write("Введи m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи n: ");
int n = Convert.ToInt16(Console.ReadLine());
		int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		Console.WriteLine(AkkermanFunc(m,n));
	}
}