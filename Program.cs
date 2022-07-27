using System;

namespace code 
{
interface management
{
 void menu();
 void add();
 void search();
 void show();
 void update();

}
  
  class Program
  {
    static void menu(){
      int input;


      Console.WriteLine("SELECT THE OPTIONS FROM MENU");
      Console.WriteLine("1.  ADD RECORD");
      Console.WriteLine("2.  VIEW RECORD");
      Console.WriteLine("3.  SEARCH RECORD");
      Console.WriteLine("4.  UPDATE RECORD");
      input = Convert.ToInt32(Console.ReadLine());

      switch (input)
      {
        case 1:
        {
          add();
          break;
        }
        case 2:
        {
          show();
          break;
        }
        case 3:
        {
          search();
          break;
        }
        case 4:
        {
          update();
        }

        default:
        {
          Console.WriteLine("YOU HAVE NOT SELECTED FROM THE MENU ");
        }
      }

      
      


    }





  static void Main(string[] args)
    {
     
      menu();
    }
  }
  }
