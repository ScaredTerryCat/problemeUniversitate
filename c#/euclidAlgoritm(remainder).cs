using System;
public class HelloWorld{
    public static void divizori(int n){
        for(int i=1;i*i<=n;i++){
            if(n%i==0){
                Console.Write($"{i} ");
                int d=n/i;
                if(d!=i){Console.Write($"{d} ");}
            }
        }
    }
    public static int cmmdc1(int a,int b){
        while(a!=b){
            if(a>b){a-=b;}
            else{b-=a;}
        }
        return b;
    }
    //bellow is the algoritm
    public static int cmmdc2(int a,int b){
        while(a!=0){
            int r=a%b;
            a=b;
            b=r;
        }
    return a;    
    }
    //up is the algorithm
 public static void Main(string[] args){
     int n1=Convert.ToInt32(Console.ReadLine());
     int n2=Convert.ToInt32(Console.ReadLine());
     //divizori(n1);
     //Console.WriteLine(cmmdc1(n1,n2));
     Console.WriteLine(cmmdc2(n1,n2));
 }   
}
