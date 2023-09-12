using System;
					
public class Program
{
	public static void Main()
	{
		//Challenge 1
		//Setting variables
		int myInt = 18;
		double myFloat = 12.56454;
		bool myBool = true;
		string write = "Hello world";
		//Printing
		Console.WriteLine(myInt);
		Console.WriteLine(myFloat);
		Console.WriteLine(myBool);
		Console.WriteLine(write);
		//Readablity
		Console.WriteLine("");
		
		//Challenge 2
		//Set
		int myInt2 = 16;
		double myFloat2 = 13.151;
		//Operations
		double myAns = (myInt2 - myFloat2) * myInt2 + 10 / 5;
		//Printing
		Console.WriteLine(myInt2);
		Console.WriteLine(myFloat2);
		Console.WriteLine(myAns);
		//Readablity
		Console.WriteLine("");
		
		//Challenge 3
		//Prompts and Receves input
		Console.WriteLine("Please input first number");
		int myIntInput1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please input second number");
		int myIntInput2 = Convert.ToInt32(Console.ReadLine());
		//takes input and computes it
		double myAns2 = (myIntInput1 - myIntInput2) * myIntInput1 + 10 / 5;
		Console.WriteLine(myAns2);
	}
}