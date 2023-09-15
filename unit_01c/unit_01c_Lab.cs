using System;
					
public class Program
{
	public static void Main()
	{
		//Asks for the number and gets one from user
		Console.WriteLine("Please give a number for pyramid");
		int num = Convert.ToInt32(Console.ReadLine());
		//sets up a second number you add to until you get to num
		//Because of formating
		int num2 = 1;
		while (num2 <= num)
		{
			// gets the amount of times it needs to print the number then prints
			for (int times = 0; times < num2; times++)
			{
				Console.Write(num2);
			}
			//Goes to next line the adds one to the pyramid and starts again.
			Console.WriteLine("");
			num2++;
			
		}
	}
}