using System;
using System.Collections.Generic;
namespace myNameSpace{
    public class myClass{
        public static void muta0Dreapta(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            for(int i=1;i<n;i++){
                if(arr[i]!=0){
                    int left=i-1;
                    int right=i;
                    while(arr[left]==0){
                        (arr[right],arr[left])=(arr[left],arr[right]);
                        left-=1;
                        right-=1;
                        if(left==-1){break;}
                    }
                }
            }
        return;}
        public static void printArr(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            for(int i=0;i<n;i++){Console.Write($" {arr[i]}");}
            Console.WriteLine();
        }
        public static void Main(string[] args){
            int[] arr=new int[]{0,0,0,1,2,3,0,4,0,0,0,5};
            int n=arr.Length;
            printArr(arr,n);
            muta0Dreapta(arr,n);
            printArr(arr,n);
            
        }
    }
}
