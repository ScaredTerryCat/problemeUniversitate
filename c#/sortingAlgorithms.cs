// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void line(int n=50){
        for(int i=0;i<n;i++){Console.Write("_");}
    }
    public static void printArr(int[] arr){
        int n=arr.Length;
        Console.WriteLine();
        for(int i=0;i<n;i++){Console.Write($" {arr[i]}");}
        Console.WriteLine();
    }
    public static void populateArr(int[] arr,int minValue=0,int maxValue=10){
        int n=arr.Length;
        Random rnd=new Random();
        for(int i=0;i<n;i++){
            arr[i]=rnd.Next(minValue,maxValue);
        }
    }
    public static void bubbleSort(int[] arr){
        int n=arr.Length;
        for(int i=0;i<n;i++){
            for(int j=0;j<n-i-1;j++){
                if(arr[j]>arr[j+1]){(arr[j],arr[j+1])=(arr[j+1],arr[j]);}
            }
        }
    }
    public static void insertSort(int[] arr){
        int n=arr.Length;
        for(int i=1;i<n;i++){
            int key=arr[i];
            int j=i-1;
            while(j>=0 && arr[j]>key){
                arr[j+1]=arr[j];
                arr[j]=key;
                j-=1;
            }
        }
    }
    public static void selectSort(int[] arr){
        int n=arr.Length;
        for(int i=0;i<n-1;i++){
            int minIndex=i;
            for(int j=i+1;j<n;j++){
                if(arr[j]<arr[minIndex]){minIndex=j;}
            }
        (arr[i],arr[minIndex])=(arr[minIndex],arr[i]);
        }
    }
    public static int[] merge(int[] arr1,int[] arr2){
        int n1=arr1.Length,n2=arr2.Length;
        int[] result=new int[n1+n2];
        int i1=0,i2=0,i=0;
        while(i1<n1 && i2<n2){
            if(arr1[i1]<arr2[i2]){
                result[i]=arr1[i1];
                i1++;
            }
            else{
                result[i]=arr2[i2];
                i2++;
            }
            i++;
        }
        while(i1<n1){
            result[i]=arr1[i1];
            i++;
            i1++;
        }
        while(i2<n2){
            result[i]=arr2[i2];
            i++;
            i2++;
        }
        return result;
    }
    public static int[] mergeSort(int[] arr){
        int n=arr.Length;
        if(n<=1){return arr;}
        int mid=n/2;
        int[] leftArr=new int[mid];
        int[] rightArr=new int[n-mid];
        int i=0;
        for(int i1=0;i1<mid;i1++){
            leftArr[i1]=arr[i];
            i+=1;
        }
        for(int i2=0;i2<n-mid;i2++){
            rightArr[i2]=arr[i];
            i+=1;
        }
        leftArr=mergeSort(leftArr);
        rightArr=mergeSort(rightArr);
        return merge(leftArr,rightArr);
    }
    
    public static int[] quickSort(int[] arr){
        int n=arr.Length;
        if(n<=1){return arr;}
        int pivot=arr[n-1];
        List<int> l1=new List<int>(),l2=new List<int>();
        for(int i=0;i<n-1;i++){
            if(arr[i]<pivot){l1.Add(arr[i]);}
            else{l2.Add(arr[i]);}
        }
        int n1=l1.Count,n2=l2.Count;
        int[] arr1=new int[n1],arr2=new int[n2];
        for(int i=0;i<n1;i++){arr1[i]=l1[i];}
        for(int i=0;i<n2;i++){arr2[i]=l2[i];}
        arr1=quickSort(arr1);
        arr2=quickSort(arr2);
        int[] result=new int[n];
        int ri=0;
        for(int i=0;i<n1;i++){
            result[ri]=arr1[i];
            ri++;
        }
        result[ri]=pivot;
        ri++;
        for(int i=0;i<n2;i++){
            result[ri]=arr2[i];
            ri++;
        }
    return result;}

    public static void example(int[] arr,string functionName){
        Console.WriteLine("\n"+functionName);
        populateArr(arr);
        printArr(arr);
        if(functionName!="bubbleSort" && functionName!="selectSort" && functionName!="insertSort" && functionName!="mergeSort" && functionName!="quickSort"){return;}
        if(functionName=="bubbleSort"){bubbleSort(arr);}
        if(functionName=="insertSort"){insertSort(arr);}
        if(functionName=="selectSort"){selectSort(arr);}
        if(functionName=="mergeSort"){arr=mergeSort(arr);}
        if(functionName=="quickSort"){arr=quickSort(arr);}
        printArr(arr);
        line();
    }
    
    public static void Main(string[] args)
    {
     int[] arr=new int[10];
     string[] functionNames=new string[]{"bubbleSort","insertSort","selectSort","mergeSort","quickSort"};
     foreach(string functionName in functionNames){
     example(arr,functionName);
}
    }
}
