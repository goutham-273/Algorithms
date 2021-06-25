using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void plusMinus(List<int> arr)
    {float a=0,b=0,c=0;
    for(int i=0;i<arr.Count;i++)
    {if(arr[i]>0){a++;}
     if(arr[i]<0){b++;}
     if(arr[i]==0){c++;}
    }
    a=a/arr.Count;b=b/arr.Count;c=c/arr.Count;
     Console.WriteLine(a.ToString("N6"));
     Console.WriteLine(b.ToString("N6"));
     Console.WriteLine(c.ToString("N6"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
