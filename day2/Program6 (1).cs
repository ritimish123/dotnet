using System;
class Program6
{
    public static void Main()
    {
        Console.Write("enter  username: ");
        string username= Convert.ToString(Console.ReadLine());
 
        Console.Write("Enter password: ");
        string password= Convert.ToString(Console.ReadLine());

        if(username == "admin" && password == "1234")
     {

      Console.Write("Welcome ");

      }
  else

   {
      Console.Write("invalid username or password");
}