using System;
using System.Collections.Generic;
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
        public static void Main(string[] args){
            int[] arr=new int[10];
            Random rnd=new Random();
            for(int i=0;i<arr.Length;i++){
                arr[i]=rnd.Next(1,10);
            }
            Array.Sort(arr);
            printArr(arr);
            int target=3;
            int index=binarySearch(arr,target);
            if(index!=-1){
            Console.WriteLine($"value: {target} | index: {index}");}
            else{
                Console.WriteLine($"value: {target} | index: not in array");
            }


        }
    }
}
