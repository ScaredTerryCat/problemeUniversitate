
someone someoneAdam <marioetare1120@gmail.com>
Fri, Nov 8, 3:03 AM (1 day ago)
to me

using System;
using System.Collections.Generic;
namespace programUlMeu{
    public class Program{
        public static void Main(string[] args){
            int pozitie=1;
            int count=0;
            Console.WriteLine("Introdu un set de numere (separate prin spatii):\t");
            string line=Console.ReadLine();
            foreach(var varNum in line.Split(' ')){
                if(int.TryParse(varNum,out int num)){
                    if(num==pozitie){count++;}
                }
                else{
                    ;
                }
            pozitie+=1;}
           
        Console.WriteLine($"[contor] Numere egale cu pozitia lor:  {count}");
           
        }
    }
   
}
