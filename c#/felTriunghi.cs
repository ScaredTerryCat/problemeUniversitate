
someone someoneAdam <marioetare1120@gmail.com>
Fri, Nov 8, 3:33 AM (1 day ago)
to me

using System;
using System.Collections.Generic;
namespace programUlMeu{
    public class Program{
        public static void Main(string[] args){
        Console.WriteLine("_____FEL___TRIUNGHI____");
        try{
            bool isoscel=false;
        Console.Write("latura 1:\t");
        int l1=Convert.ToInt32(Console.ReadLine());
        Console.Write("latura 2:\t");
        int l2=Convert.ToInt32(Console.ReadLine());
        Console.Write("latura 3:\t");
        int l3=Convert.ToInt32(Console.ReadLine());
        if(l1<=0 || l2<=0 || l3<=0){Console.WriteLine("Laturile nu pot fi negative sau nule !!!");return;}
        if(l1==l2 && l1==l3){Console.WriteLine("Triunghiul este echilateral.");return;}
        if(l1==l2 || l2==l3 || l3==l1){Console.WriteLine("Trinunghiul este isoscel");isoscel=true;}
        int p1=l1*l1;int p2=l2*l2;int p3=l3*l3;
        if(p1+p2==p3 || p1+p3==p2 || p2+p3==p1){Console.WriteLine("Triunghiul este pitagoreic");return;}
        if(isoscel==false){Console.WriteLine("Triunghiul este oarecare.");return;}
       
       
       
       
           
        }
        catch(Exception e){Console.WriteLine("Laturile pot fi doar valori numerice.");}
    }
   
}
}
