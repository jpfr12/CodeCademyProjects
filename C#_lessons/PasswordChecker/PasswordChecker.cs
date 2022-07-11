/*
Title: Password Checker
Author: Joao Ribeiro

Problem Statement: Given a password by the user, the program will say how strong it is.
Scores:
- 4 or 5: extremely strong
- 3: strong
- 2: medium
- 1: weak
*/
using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      bool digits = false;
      bool lower = false;
      bool upper = false;
      bool special = false;
      Console.WriteLine("Enter a password: ");
      string input = Console.ReadLine();
      foreach(char c in input){
        if(Char.IsDigit(c)) digits = true;
        else if(Char.IsLetter(c)){
          if(c == Char.ToUpper(c)) upper = true;
          else lower = true;
        }
        else special = true;
      }
      int ans = (input.Length >= 8 ? 1:0) + (upper ? 1:0) + (lower ? 1:0) + (special ? 1:0) + (digits ? 1: 0);
      switch(ans){
        case (5):
          Console.WriteLine("the password is extremely strong");
          break;
        case (4):
          Console.WriteLine("the password is extremely strong");
          break;
        case (3):
          Console.WriteLine("the password is strong");
          break;
        case(2):
          Console.WriteLine("the password is medium");
          break;
        case (1):
          Console.WriteLine("the password is weak");
          break;
        default:
          Console.WriteLine("the password doesn’t meet any of the standards");
          break;
      }
    }
  }
}
