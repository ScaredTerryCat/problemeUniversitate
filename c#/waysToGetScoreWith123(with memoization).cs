/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
class HelloWorld {
   static Dictionary<int,long> memo=new Dictionary<int,long>();
     static long waysToScore(int score){
        if(score==0){return 1;}
        if(score<0){return 0;}
        long way1,way2,way3;
        if(memo.ContainsKey(score-1)){
            way1=memo[score-1];
        }
        else{way1=waysToScore(score-1);memo.Add(score-1,way1);}
        if(memo.ContainsKey(score-2)){
            way2=memo[score-2];
        }
        else{way2=waysToScore(score-2);memo.Add(score-2,way2);}
        if(memo.ContainsKey(score-3)){way3=memo[score-3];
        }
        else{way3=waysToScore(score-3);memo.Add(score-3,way3);}
        return way1+way2+way3;
    }
  static void Main() {
      int score;
      Console.Write("Score:\t");
      score=Convert.ToInt32(Console.ReadLine());
      long result=waysToScore(score);
      Console.Write($"Number of ways to achieve score:\t {result}");
      
  }
}
