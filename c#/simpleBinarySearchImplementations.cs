using System;
namespace mainNameSpace{
    public static class MainClass{
        public static int binarySearch(int[] arr,int target){
            int len=arr.Length;
            int start=0;
            int end=len-1;
            while(start<=end){
                int mid=(start+end)/2;
                if(arr[mid]==target){return mid;}
                if(arr[mid]>target){end--;}else{start++;}
            }
        return -1;
        }
        public static void Main(string[] args){
            int[] nums=new int[]{1,2,3,4,5,6,7,8,9,10};
            int target=10;
            Console.WriteLine(binarySearch(nums,target));
        }
    }
}
