
someone someoneAdam <marioetare1120@gmail.com>
Fri, Nov 8, 2:24 AM (1 day ago)
to me

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Introdu un an:\t");
        int an=Convert.ToInt32(Console.ReadLine());
        bool bisect=false;
        if(an%4==0){bisect=true;}
        if(an%100==0){bisect=false;}
        if(an%400==0){bisect=true;}
        if(bisect){Console.WriteLine($"Anul {an} este bisect.");}
        else{Console.WriteLine($"Anul {an} nu este bisect.");}
    }
}
