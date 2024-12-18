// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static int cmmdc(int n1,int n2){
        if(n1==0){return n2;}
        if(n2==0){return n1;}
        while(n1!=n2){
            if(n1>n2){n1-=n2;}
            else{n2-=n1;}
        }
    return n1;}
    public static void Main(string[] args)
    {
        Console.Write("\tn1 = ");
          int n1=Convert.ToInt32(Console.ReadLine());
        Console.Write("\tn2 = ");
            int n2=Convert.ToInt32(Console.ReadLine());
        int maxDivizor=cmmdc(n1,n2);
        Console.WriteLine($"cmmdc({n1},{n2}) = {cmmdc(n1,n2)}");
        
          
          
        }
}
