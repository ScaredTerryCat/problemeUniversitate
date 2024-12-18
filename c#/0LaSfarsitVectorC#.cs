
someone someoneAdam <marioetare1120@gmail.com>
Fri, Dec 13, 3:38 AM (5 days ago)
to me

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static int[] muta0(int[] vector,int n){
        int[] result=new int[n];
        int end=n-1;
        int start=0;
        for(int i=0;i<n;i++){
            if(vector[i]==0){result[end]=0;end--;}
            else{result[start]=vector[i];start++;}
        }
        return result;
    }
    public static void afisareVector(int[] vector){
        Console.WriteLine();
        for(int i=0;i<vector.Length;i++){
            Console.Write($" {vector[i]}");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        int[] vector={1,2,3,0,0,4,5,0,6};
        afisareVector(vector);
        int n=vector.Length;
        int[] result=muta0(vector,n);
        afisareVector(result);
       
    }
}
