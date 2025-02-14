using System;
using System.Collections.Generic;
namespace testFundamenteleProgramarii{
	public class aux{
		public static bool estePrim(int n){
			if(n<2){return false;}
			if(n==2 || n==3){return true;}
			if(n%2==0 || n%3==0){return false;}
			for(int i=5;i<=n;i+=6){
				if(n%i==0 || n%(i+2)==0){return false;}
			}
		return true;}
		public static string rotesteStringStanga(string s,int k=1){
			int n=s.Length;
			k%=n;
			string result=s.Substring(k)+s.Substring(0,k);
		return result;}
		public static string rotesteStringDreapta(string s,int k=1){
			int n=s.Length;
			k%=n;
			string result=s.Substring(n-k,k)+s.Substring(0,n-k);
			return result;
		}
		}
	public class randul2{
		//problema1:	Scrieti o functie care primeste ca argument un numat natural nenul n si intoarce ca valoare 
		//suma numerelor din intervalul inchis 1..n care au cifra zecilor 1
		public static int problema1(int n){
			int s=0;
			for(int i=10;i<=n;i++){
				if((i/10)%10==1){s+=i;}
			}
		return s;}
		/*
			Sirul lui fibonacci se genereaza dupa regula f(n)=f(n-1)+f(n-2),f(0)=1,f(1)=1.
			Scrieti o functie care primeste ca argument un numar natural nenul n si returneaza al n-lea element din sirul fibonacci.
		*/
			public static int problema2(int n){
				if(n==0 || n==1){return 1;}
				return problema2(n-1)+problema2(n-2);
			}
			/*
				Scrieti o functie care primeste ca argument un numar natural n si returneaza suma numerelor prime mai mici strict decat n
			*/
			public static int problema3(int n){
				int s=0;
				for(int i=2;i<n;i++){
					if(aux.estePrim(i)){s+=i;}
				}
			return s;}
			/*
			Scrieti o functie care primeste ca parametrii doua siruri de carectere s si t si determina daca sirul t este un subsir al sirului s.
			Functia returneaza pozitia din sirul s la care incepe sirul t sau -1 daca t nu este subsir al lui s.
			(problema trebuie rezolvata folosind doar operatii de comparare a carecterelor)
			*/
			public static int problema4(string s,string t){
				if(t.Length>s.Length || s.Length==0){return -1;}
				for(int i=0;i<s.Length-t.Length+1;i++){
					bool flag=true;
					for(int j=0;j<t.Length;j++){
						if(s[i+j]!=t[j]){flag=false;break;}
					}
					if(flag){return i;}
				}
			return -1;}
			/*
				Scrieti o functie care primeste ca argument o matrice patratica si determina suma elementelor
				negative situate sub diagonala principala 
				si sub diagonala secundara.Rezultatul se va returna prin functie
			*/
			
			public static int problema5(int[,] arr){
				int n=arr.GetLength(0);
				int s=0;
				for(int i=0;i<n;i++){
					for(int j=0;j<n;j++){
						if(arr[i,j]<0){
							if(i>j || i+j>n-1){s+=arr[i,j];}
						}
					}
				}
				return s;
			}
	}
	public class randul1{
		/*
		1.Scrieti o functie care primeste ca argument un numar natural nenul n si intoarce ca valoare suma multiplilor de 3 
		sau 5 mai mici strict decat n.
		*/
		public static int problema1(int n){
			int s=0;
			int sumaMultiplii(int r){
				int x=0;
				while(x*r<n){
					x+=1;
				}
				x-=1;
				int suma=0;
				int p=x+1;
				if(r%2==0){r/=2;} else if(x%2==0){x/=2;} else{p/=2;}
				return r*x*p;


			}
		return sumaMultiplii(3)+sumaMultiplii(5)-sumaMultiplii(15);
		}
		/*
		2.Sirul lui fibonacci se genereaza dupa regula f(n)=f(n-1)+f(n-2),f(0)=1,f(1)=1
		Scrieti o functie care primeste ca argument un numar natural nenul n si returneaza suma numerelor pare din sirul lui 
		fibonacci mai mici decat n
		*/
		public static int problema2(int n){
			int f0=1,f1=1;
			int fn=0,s=0;
			while(fn<n){if(fn%2==0){s+=fn;}
			fn=f0+f1;
			f0=f1;
			f1=fn;
		}
		return s;}
		/*
			Scrieti o functie care primeste ca argument un numar natural n si returneaza suma primelor n numere prime.
		*/
			public static int problema3(int n){
				int count=0;
				int s=0;
				int num=2;
				while(count<n){
					if(aux.estePrim(num)){s+=num;count++;}
					num+=1;
				}
				return s;
			}
			/*
				Scrieti o functie care primeste ca argument doua siruri de caractere.
				Functia intoarce true daca daca un sir este permutarea circulara a celuilalt si false in caz contrar.
			*/
			public static bool problema4(string s1,string s2){
				int n1=s1.Length,n2=s2.Length;
				if(n1!=n2){return false;}
				for(int i=0;i<n1;i++){
					if(s1==s2){return true;}
					s2=aux.rotesteStringDreapta(s2);
				}
				return false;
			}
			/*
			Scrieti o functie care primeste ca argument o matrice patratica si determina suma
			elementelor pozitive situate deasupra diagonalei principale si deasupra diagonalei secondare.
			Rezultatul se va returna din functie
			*/
			public static int problema5(int[,] matrice){
				//matricea e patratica ,adica numarul de coloane e egal cu numarul de linii
				int n=matrice.GetLength(0);
				int s=0;
				for(int i=0;i<n;i++){
					//iteram randuri
					for(int j=0;j<n;j++){
						//iteram coloane
						int element=matrice[i,j];
						if(element>0){
							if(i<j || i+j<n-1){s+=element;}
						}
					}
				}
				return s;
			}
	public class mainClass{
		public static void Main(string[] args){
			
			int n=100;
			Console.WriteLine(randul1.problema4("mario","iomar"));
		}
	}
}}
