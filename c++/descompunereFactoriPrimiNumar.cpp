#include<iostream>
using namespace std;
bool estePrim(int n){
    if(n<2){return false;}
    for(int i=1;i*i<=n;i++){
        if(n%i==0){
            if(i!=1){return false;}
        int d=n/i;
        if(d!=i && d!=n){
            return false;
        }
        }
    }

    return true;
}
void descompunereFactoriPrimi(int n){
    for(int i=2;i<=n;i++){
        if(estePrim(i) && n%i==0){
            int p=0;
            while(n%i==0){
                n/=i;
                p++;
            }
            cout<<i<<" "<<p<<endl;
        }
    }
}
int main(){
    int n;
    cin>>n;
    descompunereFactoriPrimi(n);
}
