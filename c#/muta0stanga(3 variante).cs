using System;
using System.Collections.Generic;
namespace myNameSpace{
    public class myClass{
        public static void printArr(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            for(int i=0;i<n;i++){
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
        }
        public static void muta0stanga1(int[] arr,int n=-1){
            //implementare instabila
            if(n==-1){n=arr.Length;}
            int left=0;
            for(int i=0;i<n;i++){
                if(arr[i]==0){
                    while(left<i && arr[left]==0){
                        left++;
                    }
                    (arr[i],arr[left])=(arr[left],arr[i]);
                    left+=1;
                }
            }
        return;}
        public static void muta0stanga2(int[] arr,int n=-1){
            //implementare stabila
            if(n==-1){n=arr.Length;}
            for(int i=n-2;i>=0;i--){
                if(arr[i]!=0){
                    int left=i,right=i+1;
                    while(right<=n-1){
                        if(arr[right]==0){
                            (arr[left],arr[right])=(arr[right],arr[left]);
                        }
                        else{
                            right++;
                            left++;
                        }
                    }
                }
            }
        return;
        }
        public static void line(int n=50){
            Console.WriteLine();
            for(int i=0;i<n;i++){Console.Write("_");}
            Console.WriteLine();
        }
        public static int[] muta0stanga3(int[] arr,int n=-1){
            if(n==-1){n=arr.Length;}
            int[] result=new int[n];
            int right=n-1;
            int left=0;
            for(int i=0;i<n;i++){
                int element=arr[i];
                if(element==0){result[left]=element;left++;}
                else{result[right]=element;right-=1;}
            }
        return result;}
        public static void Main(string[] args){
            int[] arr=new int[]{0,0,1,0,0,0,2,0,0,3,0};
            int n=arr.Length;
            printArr(arr,n);
            muta0stanga1(arr,n);
            printArr(arr,n);
            line();
            arr=new int[]{0,0,1,0,0,0,2,0,0,3,0};
            printArr(arr);
            muta0stanga2(arr,n);
            printArr(arr);
            arr=new int[]{0,0,1,0,0,0,2,0,0,3,0};
            line();
            printArr(arr,n);
            arr=muta0stanga3(arr,n);
            printArr(arr,n);
        }
    }
}
