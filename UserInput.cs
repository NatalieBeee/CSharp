using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      string number = "*suspence*";
      Console.WriteLine(number);
      Console.WriteLine($"You are {input} years old!");
    }
  }
}