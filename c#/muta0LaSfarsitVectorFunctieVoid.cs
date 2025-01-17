using System;
public class HelloWorld{
    public static void muta0dreapta(int[] arr,int n){
        if(n==-1){n=arr.Length;}
        int end=n-1;
        while(arr[end]==0 && end>=0){end-=1;}
        if(end==0){return;}
        for(int i=0;i<n;i++){
            if(arr[i]==0){
                (arr[i],arr[end])=(arr[end],arr[i]);
                while(arr[end]!=0){end-=1;
                    if(end==0){return;}
                }
            }
        }
    }
    public static void printArr(int[] arr,int n){
        if(n==-1){n=arr.Length;}
        for(int i=0;i<n;i++){
            Console.Write($" {arr[i]} ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args){
        int[] arr=new int[]{1,2,0,3,0,0,4};
        int n=arr.Length;
        printArr(arr,n);
        muta0dreapta(arr,n);
        printArr(arr,n);
        
    }
}
