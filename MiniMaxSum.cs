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
    public static void miniMaxSum(List<int> arr)
    {
    arr.Sort();
    Console.WriteLine(Convert.ToInt64(Convert.ToInt64(arr[0])+Convert.ToInt64(arr[1]) +Convert.ToInt64(arr[2])+Convert.ToInt64(arr[3]))+" "+Convert.ToInt64(Convert.ToInt64(arr[1])+Convert.ToInt64(arr[2])+Convert.ToInt64(arr[3])+Convert.ToInt64(arr[4])));
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
