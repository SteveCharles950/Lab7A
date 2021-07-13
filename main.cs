using System;

class MainClass {

  public static double CalculateCharges(double timeCarPark){
    double cost = 0.0;
    double timeParked = timeCarPark;
    double smoothTime = timeParked - 3;
    double coolTime = 0.00;
    

    if (timeParked <= 3){
      cost = 2.00;
    }else if (timeParked < 24 && timeParked > 3){
     coolTime = smoothTime * .50;
     cost = coolTime + 2.00;
    }else {
     cost = 10.00;
    }
    return cost;
  }

  public static void Main (string[] args) {
    string x1; 
    double Charges = 0.00;


do
{
  Console.WriteLine("Did you park your car in the parking garage (yes or no)");
    x1 = Console.ReadLine();

    if(x1 == "no" || x1 == "No"){
    Console.WriteLine("");
} else{
    Console.WriteLine ("Enter time your car has been parked in garage (in hours)");
      double timeCarPark = Convert.ToDouble(Console.ReadLine());
      Charges = CalculateCharges(timeCarPark);
      Console.WriteLine ("You owe $" + (Charges));
}
} while (x1=="yes" || x1=="Yes");
    
  }
}