using System;
					
public class Program
{
	public static void insertionSort(int[] vector){
	for(int i=1;i<vector.Length;i++){
	int j=i;
		while(vector[j-1]>vector[j]){
		(vector[j-1],vector[j])=(vector[j],vector[j-1]);
		j-=1;
		if(j==0){break;}
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
		
		insertionSort(vector);
		
		Console.Write("\n\n");
		Console.Write("After:");
		for(int i=0;i<vector.Length;i++){Console.Write($" {vector[i]}");}
		
		
}}
