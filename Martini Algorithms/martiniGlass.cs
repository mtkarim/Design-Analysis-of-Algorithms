using System;

public class MartiniG
{  
// martiniGlass runs at the end of Main
public static void martiniGlass(int count)
{
    // using string constructor
		for(int i = count - 1; i >= 0; i--)
		{
    		Console.WriteLine(new string('0', 2*i + 1).PadLeft(i+count));
		}
		Console.Write(new string('|', count).Replace("|","|\n".PadLeft(count+1)));
		Console.WriteLine(new string('=', count* 2-1));
}

// the Main 
public static void Main()
{
   Console.WriteLine("Enter a number: ");
   int count = Convert.ToInt32(Console.ReadLine());
   martiniGlass(count);
}
}

// compiles on ideone.com -- not sure how to compile it on here.
