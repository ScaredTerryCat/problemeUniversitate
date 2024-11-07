
using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Dictionary<int,string> Produse=new Dictionary<int,string>();
        Produse.Add(1,"apple");
        Produse.Add(2,"banana");
        Produse.Add(3,"milk with banana");
        Produse.Add(4,"Schokholadhde");
        Produse.Add(5,"Miau miau");
        Dictionary<int,int> Preturi=new Dictionary<int,int>{{1,5},{2,10},{3,25},{4,23},{5,29}};
        
        int nickelValue=5;
        int dimeValue=10;
        int quarterValue=25;
        bool running=true;
        while (running){
        //start afisare produse
        Console.WriteLine(new string('_',70));
        Console.WriteLine("{0,35}","_________________________Lista__Produse_______________________________");
        foreach(int id in Produse.Keys){
            string numeProdus=Produse[id];
            int pretProdus=Preturi[id];
            Console.WriteLine("{0,-20}{1,-20}{2,-20}",id,numeProdus,pretProdus);
        }
        Console.WriteLine(new string('_',70));
        //end afisare produse
        int cents=0;
        Console.Write("Introdu bani:\t");
        cents=Convert.ToInt32(Console.ReadLine());
        if(cents==0){continue;}
        if(cents<0){Console.WriteLine($"Sunati politia:\tCineva a incercat sa fure {-1*cents} centi din bancomat.");continue;}
        bool acceptat=false;
        if(cents%nickelValue==0 || cents%dimeValue==0 || cents%quarterValue==0){acceptat=true;}
        if(acceptat){Console.WriteLine($"Introducere reusita:\t{cents} centi");
            Console.Write("Introdu ID produs:\t");
            int pId=Convert.ToInt32(Console.ReadLine());
            //ToDO
        
            //aici se termina if-ul cu acceptat
        }else{Console.WriteLine("Aparatul accepta doar nickel,dime si quarter centi.");}
        
  //here the while loop ends      
    }
}}
