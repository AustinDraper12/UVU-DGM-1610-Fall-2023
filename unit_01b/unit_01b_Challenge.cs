using System;
					
public class Program
{
	public static void Main()
	{
		//Challenge 1 asks for heat
		Console.WriteLine("What is the tempature celcius");
		int heat = Convert.ToInt32(Console.ReadLine());
		// sees if it is above 30 or not
		if (heat > 30)
		{
		   Console.WriteLine("Stay hydrated and avoid being in the sun to long");
		}
		// sees if above or = to 20 
			else if (heat >= 20)
		{
		   Console.WriteLine("Enjoy the fine weather today");
		}
		else if (heat >= 10 && heat < 20)
		{
		   Console.WriteLine("I advise wearing a jacket today");
		}
		else if (heat >= 0 && heat < 10)
		{
		   Console.WriteLine("I advise wearing a coat today");
		}
		// if they input a negative number
		else
		{
		   Console.WriteLine("Please stay inside");
		}
		
		Console.WriteLine("");
		
		// challenge 2 asks for score
		Console.WriteLine("What is your favorte class?\n English = 1 Math = 2 Science = 3 History = 4 other = 5");
		int favClass = Convert.ToInt32(Console.ReadLine());
		switch (favClass)
		{
			case 1:
				Console.WriteLine("I love Reading enjoy your class");
				break;
			case 2:
				Console.WriteLine("Math is my favorte to, keep on learning");
				break;
			case 3:
				Console.WriteLine("Science is a lot of fun physics makes the world go round");
				break;
			case 4:
				Console.WriteLine("History is a lot of fun my favorte is the Greeks");
				break;
			default:
				Console.WriteLine("Hope that you still enjoy the other subjects");
				break;
		}
		Console.WriteLine("What is your test score");
		int score = Convert.ToInt32(Console.ReadLine());
		// Figures out what it is then prints
		//sees if it is above 90
		if (score >= 90)
		{
			Console.WriteLine("You got a A");
		}
		//sees if above 80 but sense the if statement above says 90 and up this only goes to 89
		else if (score >= 80)
		{
			Console.WriteLine("You got a B");
		}
		else if (score >= 70)
		{
			Console.WriteLine("You got a C");
		}
		else if (score >= 60)
		{
			Console.WriteLine("You got a D");
		}
		else
		{
			Console.WriteLine("You got a F");
		}
	}
}
