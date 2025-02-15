// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class Setul1{
    public static void problema1(){
        //ecuatie grad 1
        //x=-1*b/a
        if(float.TryParse(Console.ReadLine(),out float a)){
            if(float.TryParse(Console.ReadLine(),out float b)){
                float x=-1*b/a;
                Console.WriteLine($"x = {x}");
                return;
            }
        }
        Console.WriteLine("Te rog introdu doar numere float.");
    }
    public static void problema2(){
        //ecuatie grad 2
        //x=(-b+-delta)/(2*a);
        //delta=b*b-4*a*c
        if(double.TryParse(Console.ReadLine(),out double a)){
            if(double.TryParse(Console.ReadLine(),out double b)){
                if(double.TryParse(Console.ReadLine(),out double c)){
                    double delta=b*b-4*a*c;
                    if(delta==0){
                        double x=-b/(2*a);
                        Console.WriteLine(x);
                    }
                    else if(delta<0){Console.WriteLine("Ecuatie nu are solutii reale.");}
                    else{
                        double sqrtDelta=Math.Sqrt(delta);
                        double x1=(-b+sqrtDelta)/(2*a);
                        double x2=(-b-sqrtDelta)/(2*a);
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);
                    }
                }
            }
        }
    }
public static void problema3(){
    try{
        int n=Convert.ToInt32(Console.ReadLine());
        int k=Convert.ToInt32(Console.ReadLine());
        if(n%k==0){Console.WriteLine($"{k} divide {n}");}
        else{Console.WriteLine($"{k} nu divide pe {n}");}
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}
public static void problema4(){
    try{
        bool bisect=true;
        int y=Convert.ToInt32(Console.ReadLine());
        if(y%4==0){
            if(y%100==0){
                if(y%400==0){
                    ;
                }
                else{
                    bisect=false;
                }
            }
        }
        else{bisect=false;}
        if(bisect){Console.WriteLine($"Anul {y} este bisect.");}
        else{Console.WriteLine($"Anul {y} nu este bisect.");}
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
    }
}
public static void problema5(){
    if(double.TryParse(Console.ReadLine(),out double num)){
        string snum=Convert.ToString(num);
        snum=snum.Replace(".","");
        if(int.TryParse(Console.ReadLine(),out int k)){
            if(k>snum.Length){Console.WriteLine($"Numarul {num} nu are {k} cifre");return;}
            char ccifra=snum[snum.Length-k];
        int cifra=ccifra-'0';
        Console.WriteLine(cifra);
        }
    }
}
public static void problema6(){
    try{
        double a,b,c;
        a=Convert.ToDouble(Console.ReadLine());
        b=Convert.ToDouble(Console.ReadLine());
        c=Convert.ToDouble(Console.ReadLine());
        if((a+b>c) && (a+c>b) && (b+c>a)){Console.WriteLine("Laturile pot forma un triunghi");}
        else{Console.WriteLine("Laturile nu pot forma un triunghi");}
    }
    catch(Exception e){Console.Write(e.Message);}
}
    public static void problema7(){
			string eroare="eroare";
			Console.Write("a= ");
			if(!(int.TryParse(Console.ReadLine(),out int a))){Console.WriteLine(eroare);return;}
			Console.Write("b= ");
			if(!(int.TryParse(Console.ReadLine(),out int b))){Console.WriteLine(eroare);return;}
			Console.WriteLine("Inainte:");
			Console.WriteLine($"a= {a}  b= {b}");
			Console.WriteLine("Dupa Swap:");
			int aux=a;
			a=b;
			b=aux;
			Console.WriteLine($"a= {a}  b= {b}");

		}
		public static void problema8(){
			string eroare="eroare";
			Console.Write("a=");
			if(!(int.TryParse(Console.ReadLine(),out int a))){Console.WriteLine(eroare);return;}
			Console.Write("b=");
			if(!(int.TryParse(Console.ReadLine(),out int b))){Console.WriteLine(eroare);return;}
			Console.WriteLine("Inainte de swap:");
			Console.WriteLine($"a={a}  |  b={b}");
			a=a+b;
			b=a-b;
			a=a-b;
			Console.WriteLine("Dupa swap:");
			Console.WriteLine($"a={a}  |  b={b}");
			Console.WriteLine();
		}
		public static void problema9(){
			Console.Write("n= ");
			if(!(int.TryParse(Console.ReadLine(),out int n))){Console.WriteLine("Eroare.");return;}
			Console.WriteLine($"Divizori {n} :");
			for(int i=1;i*i<=n;i++){
				if(n%i==0){
					Console.WriteLine(i);
					int d=n/i;
					if(d!=i){Console.WriteLine(d);}
				}
			}
		}
		public static void problema10(){
			Console.Write("n= ");
			if(int.TryParse(Console.ReadLine(),out int n)){;} else{Console.WriteLine("Eroare.");return;}
			bool prim=true;
			if(n<2){prim=false;}
			else if(n==2 || n==3){;}
			else if(n%2==0 || n%3==0){prim=false;}
			else{
				for(int i=5;i*i<=n;i+=6){
					if(n%i==0 || n%(i+2)==0){prim=false;break;}
				}
			}
			Console.Write($"Numarul {n} ");
			if(prim){
				Console.Write("este prim.");
			}
			else{Console.Write("nu este prim.");}
			return;
		}
		public static void problema11(){
			Console.Write("n= ");
			if(int.TryParse(Console.ReadLine(),out int n)){;}
			else{Console.WriteLine("Eroare.");return;}
			Console.Write($"Cifrele lui n={n} in ordine inversa:");
			if(n==0){Console.Write(0);return;}
			while(n!=0){
				int cifra=n%10;
				Console.Write($" {cifra}");
				n/=10;
			}
		}
		public static void problema12(){
			//cate numere intregi divizibile cu n se afla in intervalul [a,b]
			string sa,sb,sn;
			Console.Write("n= ");
			sn=Console.ReadLine();
			Console.Write("a= ");
			sa=Console.ReadLine();
			Console.Write("b= ");
			sb=Console.ReadLine();
			if(int.TryParse(sn,out int n) && int.TryParse(sa,out int a) && int.TryParse(sb,out int b)){
			;
			}
			else{Console.Write("Eroooare.");return;}
			Console.Write($"Divizori ai lui {n} in intervalul [{a},{b}] :\t");
			for(int i=1;i*i<=n;i++){
				if(n%i==0){
					if(i>=a && i<=b){
					Console.Write($" {i}");
				}
				int d=n/i;
				if(d>=a && d<=b && d!=i){Console.Write($" {d}");}

				}
			}
		}
		public static void problema13(){
			string sy1,sy2;
			Console.Write("An y1= ");
			sy1=Console.ReadLine();
			Console.Write("An y2= ");
			sy2=Console.ReadLine();
			if(int.TryParse(sy1,out int y1) && int.TryParse(sy2,out int y2)){;}else{Console.WriteLine("Eroare.");return;}
			Console.Write($"Ani bisecti intre {y1} si {y2}:");
			for(int i=y1;i<=y2;i++){
				bool bisect=true;
				if(i%4!=0){bisect=false;}
				else if(i%100==0 && i%400!=0){bisect=false;}
				if(bisect){Console.Write($" {i}");}
			}
		}

}
public class Program
{
    public static void Main(string[] args)
    {
     Setul1.problema6R();
    }
}
