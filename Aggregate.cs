// its like lambda function when ever u want to use linq but you cant find function that fit just use aggregation 

using System.Linq;
public class Kata
{
  public static int Grow(int[] x)
  {
     return  x.Aggregate((x, y) => x*y);
  }
}
