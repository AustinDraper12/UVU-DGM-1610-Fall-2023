using System;
					
public class Program
{
	public static void Main()
	{
		for (int x = 0; x < 5; x++)
		{
			Console.WriteLine(x);
		}
		
		for (int y = 8; y > 0; y--)
		{
			Console.WriteLine("I Like Cheese");
		}
		string[] cheese = {"Goat","Swiss","Mosserala","Velveta","Coby jack"};
		foreach (string i in cheese)
		{
			Console.WriteLine(i);
		}
	}
}