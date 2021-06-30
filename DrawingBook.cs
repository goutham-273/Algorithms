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
    public static int pageCount(int n, int p)
    {   
        var front=0;
        var back=0;
        if(n%2==0)
        {
            if(p%2==0)
            {
                front=p/2;
                back=(n-p)/2;
            }
            else
            {
                front=(p-1)/2;
                back=(n+1-p)/2;
            }
        }
        else
        {
            if(p%2==0)
            {
                front=p/2;
                back=(n-p-1)/2;
            }
            else
            {
                front=(p-1)/2;
                back=(n-p)/2;
            }
        }
        return Math.Min(front,back);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
