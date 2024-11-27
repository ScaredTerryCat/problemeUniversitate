/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
class HelloWorld {
    static int waysToScore(int score){
        if(score==0){return 1;}
        if(score<0){return 0;}
        return waysToScore(score-1)+waysToScore(score-2)+waysToScore(score-3);
    }
  static void Main() {
    Console.Write("Enter score :");
    int score=Convert.ToInt32(Console.ReadLine());
    Console.Write($"Ways to get this score:{waysToScore(score)}");
  }
}
