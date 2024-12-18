// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static List<int> divizori(int n){
    List<int> result=new List<int>();
    for(int i=1;i*i<=n;i++){
        if(n%i==0){
            result.Add(i);
            int d=n/i;
            if(d!=i){result.Add(d);}
        }
    }
    return result;
    }
    public static void Main(string[] args)
    {
        Console.Write("\tn = ");
          int n=Convert.ToInt32(Console.ReadLine());
          List<int> listaDivizori=divizori(n);
          Console.Write("\t\tDivizori:\t");
          foreach(int i in listaDivizori){
              Console.Write($" {i}");
          }
          
        }
}
