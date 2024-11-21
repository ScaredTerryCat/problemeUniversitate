
someone someoneAdam <marioetare1120@gmail.com>
Fri, Nov 15, 3:55 AM (6 days ago)
to me

using System.ComponentModel.Design;

namespace ConsoleApp29
{
    internal class Program
    {
        static int consecutivMax(string s){
            int result = 0;
            int count = 0;
            int antNum = int.MinValue;
            foreach (var strNum in s.Split(' ', StringSplitOptions.RemoveEmptyEntries)) {
                if (int.TryParse(strNum,out int num)) {
                    if (num == antNum) { count++; }
                    else { if (count > result) { result = count; }count = 1;}
                    antNum = num;
                }
                else {
                    Console.WriteLine($"{strNum} nu este un numar.");
                }
               
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Introdu o secventa de numere:\t");
            string s = Console.ReadLine();
            int result = consecutivMax(s);
            Console.WriteLine($"Count-ul maxim de numere consecutive este:\t{result}");
           
           
    }
    }
}
