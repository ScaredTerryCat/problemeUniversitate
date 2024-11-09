
someone someoneAdam <marioetare1120@gmail.com>
Fri, Nov 8, 3:57 AM (1 day ago)
to me

using System;
using System.Collections.Generic;
namespace programUlMeu{
public class Program{
public static void Main(string[] args){
Console.Write("Introdu o secventa de numere separata prin spatii:\t");
string line=Console.ReadLine();
Console.Write("Introdu numarul pe care sa il caut:\t");
int wanted=Convert.ToInt32(Console.ReadLine());
int wantedCount=0;
foreach(var varNum in line.Split(' ')){
    if(int.TryParse(varNum,out int num)){
        if(wanted==num){wantedCount++;}
    }
}
   
Console.WriteLine($"Am gasit numarul de {wantedCount} ori.");}
       
    }}
