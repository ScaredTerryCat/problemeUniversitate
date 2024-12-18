// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static bool estePrim(int n){
        if(n<2){return false;}
        for(int i=1;i*i<=n;i++){
            if(n%i==0){
                if(i!=1){return false;}
                int d=n/i;
                if(d!=n && d!=i){return false;}
            }
        }
    return true;}
    public static void Main(string[] args)
    {
        Console.Write("n = ");
        int n=Convert.ToInt32(Console.ReadLine());
        if(estePrim(n)){
            Console.WriteLine($"{n} este prim.");
        }
        else{
            Console.WriteLine($"{n} nu este prim.");
        }
       
    }}
