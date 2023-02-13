//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

internal class Program
{
	private static void Main(string[] args)
	{
		int a = new Random().Next(-99 , 99);
		Console.Write($" Первое число -> ");
		Console.WriteLine(a);
		
		int b = new Random().Next(-99 , 99);
		Console.Write($" Второе число -> ");
		Console.WriteLine(b);
		
		int c = new Random().Next(-99 , 99);
		Console.Write($" Третье число -> ");
		Console.WriteLine(c);

		int max = a;

		if( a > max ) max = a;
		if( b > max ) max = b;
		if( c > max ) max = c;

		System.Console.Write($" Максимальное число -> ");
		Console.WriteLine(max);
	}	
}