using System;

namespace HelloWorld
{
  class Program
  {
    static void function()
    {
      Console.WriteLine("my first function ");
    }
    static void Main(string[] args)
    {
      int a=4;
      double b=2.34;
      string c="rehan";
      string alpha;

      Console.WriteLine(a);
      Console.WriteLine(b);   
      Console.WriteLine(a+b); 
      Console.WriteLine(c);
      Console.WriteLine("enter your name");
      Console.WriteLine("here is your name "+ c);  
      function();  
      
      for(int i=0;i<3;i++){

        Console.WriteLine("enter you marks ");
        alpha = Console.ReadLine();
        Console.WriteLine(alpha);
      }
      for(int i=0;i<3;i++)
      {
        Console.WriteLine(alpha);
        function();
        Console.WriteLine("i am rehan");
      }

    }
  }
  }
