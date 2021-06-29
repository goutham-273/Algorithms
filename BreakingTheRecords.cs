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
{    public static List<int> breakingRecords(List<int> scores)
     {  var r1=0;
        var r2=0;
        List<int> res= new List<int>();
        var high=scores[0];
        var low=scores[0];
        for(int i=1;i<scores.Count;i++)
        {   if(scores[i]>high)
            {   high=scores[i];r1++;}
            if(scores[i]<low)
            {   low=scores[i];r2++;}
        }
        res.Add(r1);
        res.Add(r2);
        return res; 
     }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
