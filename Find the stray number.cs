using System;
using System.Collections.Generic;
using System.Linq;

class Solution 
{
  public static int Stray(int[] numbers)
  {
    Array.Sort(numbers);
    return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
  }
}
