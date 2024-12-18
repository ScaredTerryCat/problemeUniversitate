using System;
					
public class Program
{
	public static void bubbleSort(int[] vector){
	bool sorted=false;
	while(!sorted){
	sorted=true;
	for(int i=0;i<vector.Length-1;i++){
	if(vector[i]>vector[i+1]){
	sorted=false;
	(vector[i],vector[i+1])=(vector[i+1],vector[i]);
	}
	}
	}
	}
	public static void Main()
	{
		int[] vector=new int[10];
		Random rnd=new Random();
		for(int i=0;i<vector.Length;i++){vector[i]=rnd.Next(1,10);}
		Console.Write("Before:");
		for(int i=0;i<vector.Length;i++){Console.Write($" {vector[i]}");}
		
		bubbleSort(vector);
		
		Console.Write("\n\n");
		Console.Write("After:");
		for(int i=0;i<vector.Length;i++){Console.Write($" {vector[i]}");}
		
		
}}
