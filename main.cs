using System;

class MainClass {
  public static void Main (string[] args) { 

    double speed;
    int x=1;
           

    for (int counter=1; counter<=2; counter++)

    {
      Console.WriteLine("Enter the distance covered by Car#"+x);
      double dist = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter the time taken by Car#"+x);
      double hrs = Convert.ToDouble(Console.ReadLine());

      speed = (dist/hrs);
      Console.WriteLine("The speed of this car is "+ speed + " mile per hour");
    }
         

   

    


  }
}