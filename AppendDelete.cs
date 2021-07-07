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
    /* https://www.hackerrank.com/challenges/append-and-delete/problem */
    public static string appendAndDelete(string s, string t, int k)
    {
        string str="";
        var count=0;
        var i=0;
        if(s==t)
        {
            if(k>=2*(s.Length))
            {
                str="Yes";
                return str;
            }
            else
            {
                str="No";
                return str;
            }
        }
        int m=Math.Min(s.Length, t.Length);
        for(i=0;i<m;i++)
        {
            if(s[i]==t[i])
            {
                count++;
            }
            else
            {
                break;
            }
        }
        var rems=(s.Length)-count;
        var remt=(t.Length)-count;
        if(k>=rems+remt)
        {
            str="Yes";
            return str;
        }
        str="No";
        return str;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
