// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static string rev(string s){
        int n=s.Length;
        string result="";
        for(int i=n-1;i>=0;i--){
            result+=s[i];
        }
    return result;}
    public static double pow(int a,int b){
        double result=1;
        if(b>=0){
        for(int i=0;i<b;i++){result*=a;}
        return result;}
        b*=-1;
        for(int i=0;i<b;i++){
            result/=a; }
return result;        
    }
    public static bool containsChar(string s,char c){
        for(int i=0;i<s.Length;i++){if(s[i]==c){return true;}}
        return false;
    }
    public static string remFront0(string s){
        int n=s.Length;
        int startIndex=0;
        if(s[startIndex]=='0'){while(s[startIndex]=='0'){startIndex++;}}
    string result="";
    for(int i=startIndex;i<n;i++){result+=s[i];}
    return result;
    }
    public static string remBack0(string s){
        int n=s.Length;
        int endIndex=n-1;
        if(s[endIndex]=='0'){
            while(s[endIndex]=='0'){endIndex--;}
        }
        string result="";
        for(int i=0;i<=endIndex;i++){
            result+=s[i];
        }
        return result;
    }
    public static string baseAToTenInt(string part,int A){
        if(part=="0"){return "0";}
        part=remFront0(part);
        if(part==""){return "0";}
        int power=part.Length-1;
        int numerical=0;
        foreach(char c in part){
            int n=0;
            if(c=='A'){n=10;}
            else if(c=='B'){n=11;}
            else if(c=='C'){n=12;}
            else if(c=='D'){n=13;}
            else if(c=='E'){n=14;}
            else if(c=='F'){n=15;}
            else if(c=='G'){n=16;}
            else{n=c-'0';}
            numerical+=n*Convert.ToInt32(pow(A,power));
            power--;
        }
    string result=Convert.ToString(numerical);
    return result;
    }
    public static string baseAToTenDouble(string part,int A){
        part=remBack0(part);
        if(part=="0"){return "0";}
        int power=-1;
        double numerical=0;
        string result="";
        foreach(char c in part){
            int n=0;
            if(c=='A'){n=10;}
            else if(c=='B'){n=11;}
            else if(c=='C'){n=12;}
            else if(c=='D'){n=13;}
            else if(c=='E'){n=14;}
            else if(c=='F'){n=15;}
            else if(c=='G'){n=16;}
            else{n=c-'0';}
            numerical+=n*pow(A,power);
            power--;
        }
        result=Convert.ToString(numerical);
        return result;
    }
    public static string baseAToTen(string numA,int A){
        if(A<2 || A>16){return "demonic";}
        if(!containsChar(numA,'.')){
            return baseAToTenInt(numA,A);
        }
        string[] parts=numA.Split('.');
        string part1=parts[0];
        string part2=parts[1];
        string result=baseAToTenInt(part1,A)+remFront0(baseAToTenDouble(part2,A));
        return result;
        
    }
    public static string baseTenToAInt(string snum,int A){
        if(snum=="0"){return "0";}
        snum=remFront0(snum);
        int num=Convert.ToInt32(snum);
        string result="";
        while(true){
            int rest=num%A;
            num/=A;
            if(rest==10){result+='A';}
            else if(rest==11){result+='B';}
            else if(rest==12){result+='C';}
            else if(rest==13){result+='D';}
            else if(rest==14){result+='E';}
            else if(rest==15){result+='F';}
            else{
            result+=Convert.ToString(rest);}
            if(num==0){break;}
        }
    if(result==""){result="0";}
    return rev(result);}
    public static string baseTenToADouble(string snum,int A){
        if(snum=="0"){return ".0";}
        snum=remBack0(snum);
        double num=Convert.ToDouble(snum);
        string result="";
        while(num%1!=0){
            num*=A;
            double intNum=num-num%(1);
            num=num%1;
            int rest=Convert.ToInt32(intNum);
            if(rest==10){result+='A';}
            else if(rest==11){result+='B';}
            else if(rest==12){result+='C';}
            else if(rest==13){result+='D';}
            else if(rest==14){result+='E';}
            else if(rest==15){result+='F';}
            else{
            result+=Convert.ToString(rest);}
        }
        if(result==""){result="0";}
        return "."+result;
    }
    public static string baseTenToA(string snum,int A){
        if(A<2 || A>16){return "demonic";}
        string result="";
        if(!containsChar(snum,'.')){
            result=baseTenToAInt(snum,A);
            return result;
        }
        string[] parts=snum.Split('.');
        string part1=parts[0],part2=parts[1];
        result=baseTenToAInt(part1,A)+baseTenToADouble("."+part2,A);
        return result;
    }
    public static string numBase1numBase2(string snum1,int basa1,int basa2){
        string result1=baseAToTen(snum1,basa1);
        if(result1=="demonic"){return result1;}
        string result2=baseTenToA(result1,basa2);
        return result2;//which could be demonic
    }
    public static void banner(){
        Console.WriteLine();
        for(int i=0;i<25;i++){
            Console.Write("|#");
        }
        Console.WriteLine("|");
    Console.WriteLine("num1 + base1 + base2   = = > >   num2 ");
    for(int i=0;i<25;i++){
            Console.Write("|#");
        }
        Console.WriteLine("|");
        Console.WriteLine();
        Console.WriteLine("minBase:2\tmaxBase:16\t");
        Console.WriteLine("\nPermited characters: 0 1 2 3 4 5 6 7 8 9 A B C D E F");
        Console.WriteLine("\nSpaces are not permited characters   ( but we remove the ones before and after the number )");
        Console.WriteLine("\nMode:\tMAGNITUDE WITHOUT SIGN");
        for(int i=0;i<50;i++){Console.Write("_");}
        Console.WriteLine("\n");
        
    
    }
    public static string removeSpacesAround(string s){
        int start=0;
        int end=s.Length-1;
        while(s[start]==' '){start++;}
        while(s[end]==' '){end--;}
        string result="";
        for(int i=start;i<=end;i++){
            result+=s[i];
        }
    return result;}
    public static bool isBaseOk(string basa){
        if(basa=="2" || basa=="3" || basa=="4"){return true;}
        if(basa=="5" || basa=="6" || basa=="7" || basa=="8" || basa=="9"){return true;}
        if(basa=="10" || basa=="11" || basa=="12" || basa=="13" || basa=="14"){return true;}
        if(basa=="15" || basa=="16"){return true;}
        return false;
        
    }
    public static void Main(string[] args)
    {
    char[] permitedCharacters={'0','1','2','3','4','5','6','7','8','9','A','B',
    'C','D','E','F','.'};
    banner();
    string sa1,sa2,sb1,sb2;
    try{
    Console.Write("num1 =\t");
    sa1=Console.ReadLine();
    sa1=removeSpacesAround(sa1);
    foreach(char c in sa1){
        bool stopProgram=true;
        if(c=='0'){stopProgram=false;}
        else if(c=='1'){stopProgram=false;}
        else if(c=='2'){stopProgram=false;}
        else if(c=='3'){stopProgram=false;}
        else if(c=='4'){stopProgram=false;}
        else if(c=='5'){stopProgram=false;}
        else if(c=='6'){stopProgram=false;}
        else if(c=='7'){stopProgram=false;}
        else if(c=='8'){stopProgram=false;}
        else if(c=='9'){stopProgram=false;}
        else if(c=='A'){stopProgram=false;}
        else if(c=='B'){stopProgram=false;}
        else if(c=='C'){stopProgram=false;}
        else if(c=='D'){stopProgram=false;}
        else if(c=='E'){stopProgram=false;}
        else if(c=='F'){stopProgram=false;}
        else if(c=='.'){stopProgram=false;}
        else{;}
        if(stopProgram){Console.WriteLine("\n!!!Invalid character used!!!");return;}
    }
    Console.Write("base1 =\t");
    sb1=Console.ReadLine();
    Console.Write("base2 =\t");
    sb2=Console.ReadLine();
    int b1,b2;
    sb1=removeSpacesAround(sb1);
    sb2=removeSpacesAround(sb2);
    bool okBase1=isBaseOk(sb1);
    bool okBase2=isBaseOk(sb2);
    if(!okBase1 || !okBase2){Console.WriteLine("\nInvalid base!");return;}
    b1=Convert.ToInt32(sb1);b2=Convert.ToInt32(sb2);
    
    sa2=numBase1numBase2(sa1,b1,b2);
    if(sa2=="demonic"){Console.WriteLine("\n!!Error!! Most likely base is not in range 2-16");return;}
    Console.WriteLine($"num2[ result ] =\t{sa2}");
    }
    catch(Exception  e){Console.WriteLine("Something went wrong... be careful~(mostly to invalid characters)");}
    
    
}}
