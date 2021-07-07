using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/* https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem */
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        int E = 100;
        int i = 0;
        while( i<n)
        {
            i = (i + k)%(n);
            if (c[i] == 0) E = E - 1;
            else E = E - 3;
            if (i == 0) break;

        }
        Console.WriteLine(E);
        Console.ReadKey();
    }
}
