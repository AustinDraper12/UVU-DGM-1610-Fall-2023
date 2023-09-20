using System;
					
public class Program
{
	public static void Main()
	{
		//Challenge 1
		// It was not working in fiddle becasue it kept changing the number
		// gets random number
		Random rng = new Random();
		int num = rng.Next(1, 11);
		// sets up how to stop the loop
		int x = 1;
		int y = 0;
		// sets variable for attempts
		int attempts = 1;
		while (x > y)
		{
			// this was for trouble shooting  Console.WriteLine(num);
			//asks for number
			Console.WriteLine("Please Guess Between 1 and 10");
			int userNum = Convert.ToInt32(Console.ReadLine());
			//if correct ends loop and congrats
			if (userNum == num)
			{
				Console.WriteLine("Correct Congrats. It took "+ attempts +" attempts");
				y++;
			}
			// num to high
			else if (userNum > num)
			{
				Console.WriteLine("Incorrect sorry number is to high");
				
			}
			//num to low
			else if (userNum < num)
			{
				Console.WriteLine("Incorrect sorry number is to low");
				
			}
			
			else
			{
				Console.WriteLine("This is unacceptable");
			}
			//adds attempts
			attempts++;
		}
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
