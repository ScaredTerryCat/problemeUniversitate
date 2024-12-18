
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("n = ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write($"\tCifraDeControl({n}) = ");
        while(n>9){
            int s=0;
            while(n>0){
                s+=n%10;
                n/=10;
            }
            n=s;
        }
        Console.Write(n);
        
    }
}
