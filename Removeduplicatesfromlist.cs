using System;
using System.Collections.Generic;

namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
     HashSet<int> set = new HashSet<int>();
    List<int> result = new List<int>();

    foreach (int num in a)
    {
        if (set.Add(num)) // Add returns false if the item already exists in the set
        {
            result.Add(num);
        }
    }

    return result.ToArray();
    }
  }
}
