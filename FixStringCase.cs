using System.Linq;

class Kata
{
  public static string Solve(string s)
  {
    return s.Count(char.IsLower) < s.Length / 2 ? s.ToUpper() : s.ToLower();
  }
}

using System;

class Kata
{
    public static string Solve(string s)
    {
       int uppers =0 , lowers =0;
      for(int i =0;i<s.Length;i++)
      {
          if(Char.IsUpper(s[i]))
          {
             uppers++;  
          }
          else lowers++;
      }
      if(uppers == lowers) return s.ToLower();
      else if(uppers >lowers) return s.ToUpper();
      else return s.ToLower();
    }
}
