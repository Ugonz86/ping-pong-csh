using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number:");
    int inputNumber = int.Parse(Console.ReadLine());

    for (int i = 1; i <= inputNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
