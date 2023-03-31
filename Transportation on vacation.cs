public class RentalCar {
    
    public static int RentalCarCost(int d)
    {
      
        return  d>=7?(40*d)-50  : d>=3 && d<7? (d*40)-20 :d*40;
      }
  }
