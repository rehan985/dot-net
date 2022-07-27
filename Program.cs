using System;

namespace code 
{
interface management
{
 void menu();
 void menu1();
 void menu2();
 void add();
 void search();
 void show();
void description();

}
  
  class admin
  {

 public string[] name = new string [4];
public int[] age = new int [4];
public string[] address = new string [4];
public string[] disease = new string [4];
 int input;
 int number;
   



    public void menu1(){
      
      Console.WriteLine("\n SELECT THE OPTIONS FROM MENU \n ");
      Console.WriteLine("1.  ADD RECORD");
      Console.WriteLine("2.  VIEW RECORD");
      Console.WriteLine("3.  SEARCH RECORD");
      input = Convert.ToInt32(Console.ReadLine());

      switch (input)
      {
        case 1:
        {
          add();
          menu1();
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
      
        default :
        {
          Console.WriteLine("YOU HAVE NOT SELECTED FROM THE MENU ");
          break;
        }
      }
   
    }


  public void add(){

Console.WriteLine("\n ENTER PATIENT DETAILS BELOW \n ");

for(int i=0;i<4; i++)
{
Console.WriteLine(" \n \n ENTER PATIENT NAME {0} " ,i );
name[i]=Console.ReadLine();
Console.WriteLine("ENTER PATIENT AGE ");
age[i]=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ENTER PATIENT ADDRESS ");
address[i]=Console.ReadLine();
Console.WriteLine("ENTER PATIENT DISEASE ");
disease[i]=Console.ReadLine();
}
  }  


public void show()
{
 Console.WriteLine("\n HERE IS THE PATIENT DATA \n");

for(int i=0;i<4;i++)
{
 Console.WriteLine( name[i] + "\t" + age[i] + "\t" + address[i] + "\t" + disease[i] + "\n" );


}
}

public void search(){

Console.WriteLine("Search the Patient reccord on bases of number , Enter number below ");
number = Console.Read();

  Console.WriteLine( name[number] + "\t" + age[number] + "\t" + address[number] + "\t" + disease[number] + "\n");

}




  }

class doctor :admin 
{
 int option;
 int pnum;

 public string presciption;
 public void menu2()
 
 { 
 
 Console.WriteLine(" Select the one option ");
 Console.WriteLine("1. View Patient Data ");
 Console.WriteLine(" 2. Add desciption");
option = Console.Read();

switch(option)
{
  case 1 :
{
    Console.WriteLine("Enter the patient number");
    pnum = Console.Read();
    Console.WriteLine( name[pnum] + "\t" + age[pnum] + "\t" + address[pnum] + "\t" + disease[pnum] + "\n" );

    break;
} 

case 2:
Console.WriteLine("Enter patient presciption here ");
presciption=Console.ReadLine();
break;
}

}





} 

  class program{

    
   static void Main(string[] args)
    {
     int select ;
     Console.WriteLine("SELECT FROM MENU");
     Console.WriteLine("ADMIN");
     Console.WriteLine("DOCTOR ");
     select = Console.Read();
     switch(select)
     {
      case 1:
      {
        admin myobj = new admin();
        myobj.menu1();
        break;
      }
      case 2:
      {
        doctor myobj1 = new doctor();
        myobj1.menu2();

        break;
      }


     }

     
      
    }
  }
  }
