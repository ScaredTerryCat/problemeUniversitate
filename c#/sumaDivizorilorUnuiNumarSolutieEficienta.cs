
using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<long> divizoriN(long n){
        List<long> listaDivizori= new List<long>();
        long i=1;
    for(i=1;i*i<n;i++){
        if(n%i==0){listaDivizori.Add(i);listaDivizori.Add(n/i);}
    }
    if(n%i==0 && i*i==n){listaDivizori.Add(i);}
    return listaDivizori;
    }
    public static long sumaDivizoriN(long n){
        List<long> divizori=divizoriN(n);
        long suma=0;
        foreach(long divizor in divizori){
            suma+=divizor;
        }
        return suma;
    }
    public static void Main(string[] args)
    {
     long n=Convert.ToInt64(Console.ReadLine());
     Console.WriteLine(sumaDivizoriN(n));
    }
}

