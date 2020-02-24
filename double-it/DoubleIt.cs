using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringInput = Console.ReadLine();
    int yourNumber = int.Parse(stringInput);
    int yourDoubledNumber = yourNumber * 2;
    string stringDoubledNumber = yourDoubledNumber.ToString();
    Console.WriteLine("I doubled your number for you: " + yourDoubledNumber);
  }
}