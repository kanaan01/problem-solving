using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    return Enumerable.Reverse(list).ToList();
  }
}


using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> l)
  {
      List<int> reversedlist = new List<int>();
    
     for(int i= l.Count -1; i>=0 ;i--)
       {
           reversedlist.Add(l[i]);
     }
    
     return reversedlist;
  }
}
