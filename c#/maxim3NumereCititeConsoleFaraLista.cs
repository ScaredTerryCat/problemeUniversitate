// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
namespace Man{
public class HelloWorld
{   
    public static void functie(){
        int n=-1;
        int max1=int.MinValue,max2=int.MinValue,max3=int.MinValue;
        while(true){
            n=Convert.ToInt32(Console.ReadLine());
            if(n==0){Console.WriteLine($"{max1} {max2} {max3}");break;}
            if(n>max3){max3=n;}
            if(max3>max2){max3=max3+max2;max2=max3-max2;max3=max3-max2;}
            if(max2>max1){
                max2=max2+max1;
                max1=max2-max1;
                max2=max2-max1;}}}
            
    public static void Main(string[] args)
    {
        functie();
    }
}}
