using System;
using System.Collections.Generic;
namespace aNamespace{
    public class aClass{
        public static void Main(string[] args){
            string line;
            Console.WriteLine("Introdu niste numere naturale separate prin spatii: \t");
            line=Console.ReadLine();
            string[] tablou=line.Split(' ');
            List<int> oddNumbers=new List<int>();
            List<int>evenNumbers=new List<int>();
            foreach (string snum in tablou){
                if(int.TryParse(snum,out int num)){
                    if(num%2==0){
                        evenNumbers.Add(num);
                    }
                    else{
                        oddNumbers.Add(num);
                    }
                }
                else{;}
            }
            Console.Write("Numere pare:\t");
            foreach(int num in evenNumbers){
                Console.Write($" {num}");
            }
            Console.WriteLine();
            Console.Write("Numere impare:\t");
            foreach(int num in oddNumbers){
                Console.Write($" {num}");
            }
        }
    }
}
