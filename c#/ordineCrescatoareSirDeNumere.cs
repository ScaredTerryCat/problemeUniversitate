using System;
using System.Collections.Generic;
namespace programUlMeu{
    public class Program{
        public static bool ordineCrescatoare(string line){
        int numBefore=int.MinValue;
        foreach(var varNum in line.Split(' ')){
            if(int.TryParse(varNum,out int num)){
                if(num>numBefore){numBefore=num;}
                else{return false;}
           
               
            }
        }

    return true;        
   
        }
public static void Main(string[] args){
    Console.Write("Introdu o secventa de numere separate prin spatii:\t");
    string line=Console.ReadLine();
    if(ordineCrescatoare(line)){Console.WriteLine("Secventa este crescatoare");}
    else{Console.WriteLine("Secventa nu este crescatoare.");}
}
       
    }}
