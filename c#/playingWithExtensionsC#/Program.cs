using System;
using Functions;
namespace mainNameSpace{
public class HelloW{
    public static void Main(string[] args){
        Console.Write("x=\t");
        int x=Convert.ToInt32(Console.ReadLine());
        if(x.estePar()==1){Console.WriteLine($"{x} este par");}
        else{Console.WriteLine($"{x} este impar");}
        Console.WriteLine("_____________________");
        Console.WriteLine("mario".estePar());
    }
}
}
