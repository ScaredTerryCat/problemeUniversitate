//Acest cod de c# citeste cinci numere de la tastatura si fara sa foloseasca tablouri le sorteaza crescator sau decrescator.
using System;
public class Program{
    public static void Main(string[] args){
int n1,n2,n3,n4,n5;
int copy1,copy2,copy3,copy4,copy5;
Console.Write("Enter number 1:\t");
n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2:\t");
n2=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3:\t");
n3=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 4:\t");
n4=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 5:\t");
n5=Convert.ToInt32(Console.ReadLine());
int maxValue=Int32.MaxValue;
int minValue=Int32.MinValue;
copy1=n1;copy2=n2;copy3=n3;copy4=n4;copy5=n5;
Console.Write("\nNumerele in ordine crescatoare sunt:");
int minNumber=maxValue;
int maxNumber=minValue;
for(int i=0;i<5;i++){
if(n1<minNumber){minNumber=n1;}
if(n2<minNumber){minNumber=n2;}
if(n3<minNumber){minNumber=n3;}
if(n4<minNumber){minNumber=n4;}
if(n5<minNumber){minNumber=n5;}
Console.Write($"\t{minNumber}");
if(minNumber==n1){n1=maxValue;}else if(minNumber==n2){n2=maxValue;}else if(minNumber==n3){n3=maxValue;}else if(minNumber==n4){n4=maxValue;}else{n5=maxValue;}
minNumber=maxValue;
}
n1=copy1;n2=copy2;n3=copy3;n4=copy4;n5=copy5;
Console.Write("\nNumerele in ordine decrescatoare sunt:");
for(int i=0;i<5;i++){
if(n1>maxNumber){maxNumber=n1;}
if(n2>maxNumber){maxNumber=n2;}
if(n3>maxNumber){maxNumber=n3;}
if(n4>maxNumber){maxNumber=n4;}
if(n5>maxNumber){maxNumber=n5;}
Console.Write($"\t{maxNumber}");
if(n1==maxNumber){n1=minValue;}else if(n2==maxNumber){n2=minValue;}else if(n3==maxNumber){n3=minValue;}else if(n4==maxNumber){n4=minValue;}else{n5=minValue;}
maxNumber=minValue;
}


    }
}

