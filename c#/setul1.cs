// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class Setul1{
    public static void problema1(){
        //ecuatie grad 1
        //x=-1*b/a
        if(float.TryParse(Console.ReadLine(),out float a)){
            if(float.TryParse(Console.ReadLine(),out float b)){
                float x=-1*b/a;
                Console.WriteLine($"x = {x}");
                return;
            }
        }
        Console.WriteLine("Te rog introdu doar numere float.");
    }
    public static void problema2(){
        //ecuatie grad 2
        //x=(-b+-delta)/(2*a);
        //delta=b*b-4*a*c
        if(double.TryParse(Console.ReadLine(),out double a)){
            if(double.TryParse(Console.ReadLine(),out double b)){
                if(double.TryParse(Console.ReadLine(),out double c)){
                    double delta=b*b-4*a*c;
                    if(delta==0){
                        double x=-b/(2*a);
                        Console.WriteLine(x);
                    }
                    else if(delta<0){Console.WriteLine("Ecuatie nu are solutii reale.");}
                    else{
                        double sqrtDelta=Math.Sqrt(delta);
                        double x1=(-b+sqrtDelta)/(2*a);
                        double x2=(-b-sqrtDelta)/(2*a);
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);
                    }
                }
            }
        }
    }
public static void problema3(){
    try{
        int n=Convert.ToInt32(Console.ReadLine());
        int k=Convert.ToInt32(Console.ReadLine());
        if(n%k==0){Console.WriteLine($"{k} divide {n}");}
        else{Console.WriteLine($"{k} nu divide pe {n}");}
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}
public static void problema4(){
    try{
        bool bisect=true;
        int y=Convert.ToInt32(Console.ReadLine());
        if(y%4==0){
            if(y%100==0){
                if(y%400==0){
                    ;
                }
                else{
                    bisect=false;
                }
            }
        }
        else{bisect=false;}
        if(bisect){Console.WriteLine($"Anul {y} este bisect.");}
        else{Console.WriteLine($"Anul {y} nu este bisect.");}
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}
public static void problema5(){
    if(double.TryParse(Console.ReadLine(),out double num)){
        string snum=Convert.ToString(num);
        snum=snum.Replace(".","");
        if(int.TryParse(Console.ReadLine(),out int k)){
            if(k>snum.Length){Console.WriteLine($"Numarul {num} nu are {k} cifre");return;}
            char ccifra=snum[snum.Length-k];
        int cifra=ccifra-'0';
        Console.WriteLine(cifra);
        }
    }
}
public static void problema6(){
    try{
        double a,b,c;
        a=Convert.ToDouble(Console.ReadLine());
        b=Convert.ToDouble(Console.ReadLine());
        c=Convert.ToDouble(Console.ReadLine());
        if((a+b>c) && (a+c>b) && (b+c>a)){Console.WriteLine("Laturile pot forma un triunghi");}
        else{Console.WriteLine("Laturile nu pot forma un triunghi");}
    }
    catch(Exception e){Console.Write(e.Message);}
}

}
public class Program
{
    public static void Main(string[] args)
    {
     Setul1.problema6R();
    }
}
