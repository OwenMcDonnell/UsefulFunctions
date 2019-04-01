﻿using System;
using FonctionsUtiles.Fred.Csharp;

namespace ConsoleAppPrimesByHundred
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Prime numbers by hundred:");
      foreach (var kvp in FunctionsPrimes.NumberOfPrimesByHundred(5900000))
      {
        display($"{kvp.Key} - {kvp.Value}");
      }

      display("Press any key to exit");
      Console.ReadKey();
    }
  }
}
