// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static int rFactorial(int x){
        if(x==1 || x==0){return 1;}
        return x*rFactorial(x-1);
    }
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Enter a number:\t");
        n=Convert.ToInt32(Console.ReadLine());
        int result=rFactorial(n);
        Console.WriteLine($"rFactorial({n}) = {result}");
    }
}
