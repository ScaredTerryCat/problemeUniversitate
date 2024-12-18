
using System;
public class HelloWorld
{
    public static bool estePrim(int n){
        if(n<2){return false;}
        for(int i=2;i*i<=n;i++){
            if(n%i==0){return false;}
        }
    return true;}
    public static void Main(string[] args)
    {
        int[] test=new int[]{0,1,2,3,4,5,6,7,8,9,10};
        for(int i=0;i<test.Length;i++){
            Console.Write($" {test[i]}");
        }
        Console.WriteLine();
        for(int i=0;i<test.Length;i++){
            int result=0;
            if(estePrim(test[i])){result=1;}
            Console.Write($" {result}");
        }
        Console.WriteLine();
    }
}
