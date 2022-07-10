using System;

/*
Title: Money Maker
Author: Joao Ribeiro
*/

namespace MoneyMaker
{
  class MainClass
  {
    /*
    Given 3 coins:
    - A bronze coin is worth 1 cent
    - A silver coin is worth 5 cents
    - A gold coin is worth 10 cents

    The user insert a number of cents and the program gives
    the minimum number os coins of that value 
    */
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter a number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      int [] coins = {1, 5, 10};
      int [] dp = new int[number+1];
      int [] parent = new int[number+1];
      Array.Fill(dp, (int)Math.Pow(10, 9));
      dp[0] = 0;
      for(int i = 1; i <= number; i++){
        foreach(int c in coins){
          if(i-c >= 0 && dp[i] > dp[i-c]+1){
            dp[i] = dp[i-c]+1;
            parent[i] = c;
          }
        }
      }
      int [] ans = {0,0,0};
      int num = number;
      while(number > 0){
        if(parent[number] == 1) ans[0]++;
        else if(parent[number] == 5) ans[1]++;
        else ans[2]++;
        number -= parent[number];
      }
      Console.WriteLine(num + " cents is equal to...");
      Console.WriteLine("Gold coins: " + ans[2]);
      Console.WriteLine("Silver coins: " + ans[1]);
      Console.WriteLine("Bronze coins: " + ans[0]);
    }
  }
}
