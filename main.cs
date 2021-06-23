using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the temperature in Celcius");
   
  double celcius = Convert.ToDouble(Console.ReadLine());
  var Farenheit = (celcius * 9/5) + 32;
  Console.WriteLine("Farenheit equivalent for " + celcius + " degree celcius is " + Farenheit);
   
   //If temperature is below freezing (32 degree Farenheit)
 if (Farenheit < 32)
 {
   Console.WriteLine("This temperature is below freezing temperature of 32 degrees Farenheit");
 }
if (Farenheit > 212)
{
  Console.WriteLine("This tempature is above boiling tempature of 212 degrees Farenheit");
}

  
  }
}