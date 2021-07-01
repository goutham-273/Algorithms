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
    /* Link: https://www.hackerrank.com/challenges/picking-numbers/problem */
    public static int pickingNumbers(List<int> a)
    {
        var ans=0;
        a.Sort();
        for(int i=0;i<a.Count-1;i++)
        {
            var len=1;
            for(int j=i+1;j<a.Count;j++)
            {
                if(a[j]-a[i]<=1)
                {
                    len++;
                }
                else
                {
                    break;
                }
            }
            ans=Math.Max(ans,len);
        }
        return ans;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
