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
  
  class patient
  {

 string[] name = new string [4];
int[] age = new int [4];
string[] address = new string [4];
string[] disease = new string [4];
 int input;
   



    public void menu(){
      
      Console.WriteLine("\n SELECT THE OPTIONS FROM MENU \n ");
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
          menu();
          break;
        }
        case 2:
        {
          show();
          break;
        }
        case 3:
        {
         // search();
          break;
        }
        case 4:
        {
         // update();
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





   static void Main(string[] args)
    {
     
     patient myobj = new patient();

     myobj.menu();
      
    }
  }
  }
