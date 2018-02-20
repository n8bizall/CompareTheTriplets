﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Solution
{

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {

        int alexScore = 0;
        int bobScore = 0;
        
        
        // Complete this function
        if( a0!= b0)
            switch (a0> b0)
            {
                case true:
                    alexScore++;
                    break;
                case false:
                    bobScore++;
                    break;
                default:
                    break;
            }
        if (a1 != b1)
            switch (a1 > b1)
            {
                case true:
                    alexScore++;
                    break;
                case false:
                    bobScore++;
                    break;
                default:
                    break;
            }
        if (a2 != b2)
            switch (a2> b2)
            { 
                case true:
                    alexScore++;
                    break;
                case false:
                    bobScore++;
                    break;
                default:
                    break;
            }

        int[] totalScore = { alexScore, bobScore };
        return totalScore;






    }

    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));

        Console.ReadKey();
    }
}