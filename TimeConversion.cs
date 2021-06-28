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
    public static string timeConversion(string s)
    {bool b=s.Contains("AM");
     if(b)
     {int k=Convert.ToInt32(s.Substring(0,2));
      string str="00";
      if(k==12){s=str+s.Substring(2,6);}
      s=s.Substring(0,8);
     }
     else
     {int k=Convert.ToInt32(s.Substring(0,2));
      string str="12";
      if(k==12){s=str+s.Substring(2,6);}
      else{k=k+12;s=k.ToString()+s.Substring(2,6);}
     }
     return s;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
