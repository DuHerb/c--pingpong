using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {

    static void Main()
    {
      PingPong newPingPong = new PingPong();
      Console.WriteLine("Please Enter a Number: ");
      int userInput = int.Parse(Console.ReadLine());

      for(int i = 0; i <= userInput; i++)
      {
        Console.WriteLine(newPingPong.IsPingPong(i));
      }
    }

    public string IsPingPong(int number)
    {
      string output;
      if((number % 3 == 0) && (number %5 ==0))
      {
        output = "PingPong";
        return output;
      }
      else if(number %  3 == 0)
      {
        output = "Ping";
        return output;
      }
      else if(number % 5 == 0)
      {
        output = "Pong";
        return output;
      }
      output = number.ToString();
      return output;
    }
  }
}
