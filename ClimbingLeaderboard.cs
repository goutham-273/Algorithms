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
    /* Link: https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem */
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        var r=new List<int>();
        var count=0;
        var prev=0;
        var flag=0;
        for(int i=0;i<player.Count;i++)
        {
            count=0;
            prev=0;
            flag=0;
            for(int j=0;j<ranked.Count;j++)
            {
                if(player[i]<=ranked[j] && ranked[j]!=prev)
                {
                    if(player[i]==ranked[j])
                    {
                        flag=1;
                    }
                    count++;
                    prev=ranked[j];
                }
                if(player[i]>ranked[j])
                {
                    break;
                }
            }
            if(flag==1)
            {
                //count--;
                r.Add(count);
            }
            else
            {
                count++;
                r.Add(count);
            } 
        }
        return r;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
