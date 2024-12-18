// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static long LaRusseMultiplication(int a,int b){
        long result=0;
        long B=b;
        while(a>1){
            a/=2;
            B*=2;
            if(a%2!=0){result+=B;}
        }
    return result;}
    public static void Main(string[] args)
    {
        Random rnd=new Random();
        for(int i=0;i<10;i++){
            int a=rnd.Next(0,10);
            int b=rnd.Next(0,10);
            int c=a*b;
            Console.WriteLine($"\t{a} * {b} = {c}");
        }
    }
}
