using System;
using System.Collections.Generic;
using System.Threading;
namespace myNamespace{
    public class myClass{
        public static void printArr(int[] arr){
            Console.WriteLine();
            Console.Write("[");
            for(int i=0;i<arr.Length;i++){Console.Write($" {arr[i]}");}
            Console.Write("]");
            Console.WriteLine();
        }
        public static int binarySearch(int[] arr,int value){
            int left=0;
            int right=arr.Length-1;
            while(left<=right){
                int mid=(left+right)/2;
            if(arr[mid]==value){return mid;}
            if(arr[mid]>value){right=mid-1;}
            else{left=mid+1;}
            }
        return -1;}
        public static void rotateLeft(int[] arr,int k=1){
            int n=arr.Length;
            k%=n;
            for(int j=0;j<k;j++){
            int aux=arr[0];
            for(int i=1;i<n;i++){
                arr[i-1]=arr[i];
            }
            arr[n-1]=aux;}
        }
        public static void Main(string[] args){
            int[] arr=new int[]{1,2,3,4};
            int mcontor=600;
            int contor=0;
            printArr(arr);
            while(1==1){
            rotateLeft(arr,1);
            printArr(arr);
            contor+=1;
            Thread.Sleep(1000);
            if(contor==mcontor){break;}

        }
        }
    }
}
