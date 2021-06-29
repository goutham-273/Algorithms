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
{   public static int migratoryBirds(List<int> arr)
    {   arr.Sort();
        int[] pos={0,0,0,0,0};
        for(int i=1;i<=5;i++)
        {   for(int j=0;j<arr.Count;j++)
            {   if(arr[j]==i)
                {   pos[i-1]++;}
            }
        }
        var m=pos.Max();
        int[] ans={6,6,6,6,6};
        for(int i=0;i<5;i++)
        {   if(pos[i]==m)
            {   ans[i]=i+1;}
        }
        return ans.Min();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
