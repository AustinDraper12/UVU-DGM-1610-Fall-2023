using System;
					
public class Program
{
	public static void Main()
	{
		string[] color = {"Blue","Yellow","Red","Purple",};
		Console.WriteLine(color[3]);
		//output purple
		color[1] = "grey";
		Console.WriteLine(color[3]);
		Console.WriteLine(color[1]);
		//Does not add just replaces
		Console.WriteLine(color.Length);
		color[1] = "Yellow";
		foreach (string i in color)
		{
			Console.WriteLine(i);
		}
	}
}