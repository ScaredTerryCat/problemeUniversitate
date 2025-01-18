using System;
using System.Collections.Generic;
namespace myNameSpace{
    public class myClass{
        public static void muta0Dreapta(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            int right=n-1;
            for(int i=0;i<n;i++){
                if(arr[i]==0){
                    while(arr[right]==0 && right>i){right-=1;}
                    if(right<=i){return;}
                    (arr[i],arr[right])=(arr[right],arr[i]);
                    right-=1;
                }
            }
        return;
        }
        public static void printArr(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            for(int i=0;i<n;i++){
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args){
            int[] arr=new int[]{1,2,0,0,4,5,0};
            int n=arr.Length;
            printArr(arr,n);
            muta0Dreapta(arr,n);
            printArr(arr,n);
            
        }
    }
}
