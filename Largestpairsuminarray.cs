
using System.Linq;
public class Kata
{
   public static int LargestPairSum(int[] numbers)
   {
      return numbers.OrderByDescending(x=>x).Take(2).Sum();  
   }
}
