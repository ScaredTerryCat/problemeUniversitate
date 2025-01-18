using System;
using System.Collections.Generic;
namespace myNameSpace{
    public class myClass{
        public static void line(int n=50){
            Console.WriteLine();
            for(int i=0;i<n;i++){Console.Write("_");}
            Console.WriteLine();
        }
        public static void printArr(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            for(int i=0;i<n;i++){Console.Write($" {arr[i]}");}
            Console.WriteLine();
        }
        public static void muta0stanga1(int[] arr,int n=-1){
            //instabil
            if(n==-1){n=arr.Length;}
            int left=0;
            for(int i=0;i<n;i++){
                if(arr[i]==0){
                    (arr[left],arr[i])=(arr[i],arr[left]);
                    left+=1;
                }
            }
            return;}
            public static void muta0dreapta1(int[] arr,int n=-1){
                //instabil
                if(n==-1){n=arr.Length;}
                int right=n-1;
                for(int i=n-1;i>=0;i--){
                    if(arr[i]==0){(arr[right],arr[i])=(arr[i],arr[right]);right-=1;}
                }
            }
            public static void muta0stanga2(int[] arr,int n=-1){
                //stabil
                if(n==-1){n=arr.Length;}
                for(int i=1;i<n;i++){
                    if(arr[i]==0){
                        int right=i,left=i-1;
                        while(left>=0 && arr[left]!=0){
                            (arr[right],arr[left])=(arr[left],arr[right]);
                            right--;
                            left--;
                        }
                    }
                }
            return;}
            public static void muta0dreapta2(int[] arr,int n=-1){
                //stabil
                if(n==-1){n=arr.Length;}
                for(int i=n-2;i>=0;i--){
                    if(arr[i]==0){
                        int left=i,right=i+1;
                        while(right<n && arr[right]!=0){
                            (arr[left],arr[right])=(arr[right],arr[left]);
                            left+=1;right+=1;
                        }
                    }
                }
            return;}
        
        public static void Main(string[] args){
            int[] arr=new int[]{0,0,1,2,0,0,0,3,0,4,0,0};
            int n=arr.Length;
            printArr(arr,n);
            muta0stanga1(arr,n);
            printArr(arr,n);
            line();
            arr=new int[]{0,0,1,2,0,0,0,3,0,4,0,0};
            printArr(arr,n);
            muta0dreapta1(arr,n);
            printArr(arr,n);
            line();
            arr=new int[]{0,0,1,2,0,0,0,3,0,4,0,0};
            printArr(arr,n);
            muta0stanga2(arr,n);
            printArr(arr,n);
            line();
            arr=new int[]{0,0,1,2,0,0,0,3,0,4,0,0};
            printArr(arr,n);
            muta0dreapta2(arr,n);
            printArr(arr,n);
            
        }}}
