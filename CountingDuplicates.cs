using System;
using System.Collections.Generic;

public class Kata
{
  public static int DuplicateCount(string str)
  {
     int repeated = 0;
     Dictionary<char, int> Dup = new Dictionary<char, int>();
     str = str.ToLower();
     
     for (int i = 0; i < str.Length; i++)
     {
         if (!Dup.ContainsKey(str[i]))
           Dup.Add(str[i], 0);
         else if (Dup[str[i]] == 0)
         {
            repeated++;  
            Dup[str[i]]++;
         }
       }
     
     return repeated;
  }
}

using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
  }
}
