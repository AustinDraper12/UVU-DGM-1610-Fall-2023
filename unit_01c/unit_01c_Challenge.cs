using System;
					
public class Program
{
	public static void Main()
	{
        //Challenge 2
        // askes for food and gets input
		Console.WriteLine("Please input a your three favorite foods");
		string foodOne = Console.ReadLine();
		string foodTwo = Console.ReadLine();
		string foodThree = Console.ReadLine();
		string[] food = {foodOne, foodTwo, foodThree,};
        //goes through and prints each one
		foreach (string i in food)
		{
			Console.WriteLine("I love " + i + "!");
		}
	}
}
