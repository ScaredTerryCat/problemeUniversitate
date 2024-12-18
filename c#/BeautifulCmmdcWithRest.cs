
using System;
public class HelloWorld
{
    public static int cmmdc(int x,int y){
        if(x==0){return y;}if(y==0){return x;}
        while(y!=0){
            int r=x%y;
            x=y;
            y=r;
        }
        return x;
    }
    public static void Main(string[] args)
    {
        Console.Write("\tn1 = ");
          int n1=Convert.ToInt32(Console.ReadLine());
        Console.Write("\tn2 = ");
            int n2=Convert.ToInt32(Console.ReadLine());
        int maxDivizor=cmmdc(n1,n2);
        Console.WriteLine($"\t\tcmmdc({n1},{n2}) = {cmmdc(n1,n2)}");
        
          
          
        }
}
