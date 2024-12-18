// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static long rapidPower(int a,int b){
        if(a==0 && b==0){throw new ArgumentException("0^0 is undefined!");}
        if(b==0){return 1;}
        if(a==0){return 0;}
        if(b%2==0){
            long halfPower=rapidPower(a,b/2);
            return halfPower*halfPower;
        }
        else{
            return a*rapidPower(a,b-1);
        }
    }
    public static void Main(string[] args)
    {
        Random rnd=new Random();
        for(int i=0;i<10;i++){
            int a=rnd.Next(0,10);
            int b=rnd.Next(0,10);
            long c=rapidPower(a,b);
            Console.WriteLine($"\t{a} ^ {b} = {c}");
        }
    }
}
