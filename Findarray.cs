using System;
using System.Collections.Generic;

public class Kata
{
    public static object[] FindArray(object[] arr1, int[] arr2)
    {
      
      if(arr2 ==null || arr1==null) return arr1;
      else
        {
        List<object> l = new List<object>();
     
        for (int i = 0; i < arr2.Length; i++)
        {
        
            if (arr2[i] < arr1.Length)
            {
                l.Add(arr1[arr2[i]]);
            }
        }
         
        return l.ToArray();
        }
    }
}
