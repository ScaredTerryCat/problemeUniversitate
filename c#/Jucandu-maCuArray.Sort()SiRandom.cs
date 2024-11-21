using System;
public class HelloWorld{
public static void printArr(string str,int[] arr){
Console.WriteLine(str);
foreach (var i in arr){Console.Write(i);Console.Write(" ");}
Console.WriteLine();
for(int i=0;i<100;i++){Console.Write("_");}
Console.WriteLine();
}
public static int decreasingHelperFunction(int x,int y){
    return y-x;
}
public static int increasingModuleHelperFunction(int x,int y){return Math.Abs(x)-Math.Abs(y);}
public static int decreasingModuleHelperFunction(int x,int y){return Math.Abs(y)-Math.Abs(x);}
public static int increasingByOddness(int x,int y){
    if(x%2==0 && y%2!=0){return -1;}
    if(y%2==0 && x%2!=0){return 1;}
    return x-y;
}
public static void Main(string[] args){
    int[] arr;
    arr=new int[100];
    Random rand=new Random();
    for(int i=0;i<arr.Length;i++){
        int randInt=rand.Next(-100,100);
        arr[i]=randInt;
    }

printArr("Before: ",arr);
Array.Sort(arr);
printArr("Sorted increasing: ",arr);
Array.Sort(arr,decreasingHelperFunction);
printArr("Sorted Decreasing: ",arr);
Array.Sort(arr,increasingModuleHelperFunction);
printArr("Sorted increasing by absolute value:",arr);
Array.Sort(arr,decreasingModuleHelperFunction);
printArr("Sorted decreasing by absolute value:",arr);
Array.Sort(arr,increasingByOddness);
printArr("Sorcred increasingly by oddness:",arr);
}
}
