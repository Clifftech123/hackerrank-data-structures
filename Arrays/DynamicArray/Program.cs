using System;
using System.Collections.Generic;

class Result
{
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> seqList = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            seqList.Add(new List<int>());
        }

        int lastAnswer = 0;
        List<int> results = new List<int>();

        foreach (List<int> query in queries)
        {
            int queryType = query[0];
            int x = query[1];
            int y = query[2];

            int seqIndex = (x ^ lastAnswer) % n;

            if (queryType == 1)
            {
                seqList[seqIndex].Add(y);
            }
            else if (queryType == 2)
            {
                int size = seqList[seqIndex].Count;
                if (size > 0)
                {
                    lastAnswer = seqList[seqIndex][y % size];
                    results.Add(lastAnswer);
                }
            }
        }

        return results;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter all numbers on a single line, separated by spaces:");
       string[] inputs = Console.ReadLine().Trim().Split(' ');
        if (inputs.Length < 2)
        {
            Console.WriteLine("You must enter at least two numbers.");
            return;
        }
        int n = int.Parse(inputs[0]);
        int q = int.Parse(inputs[1]);
        List<List<int>> queries = new List<List<int>>();
        for (int i = 2; i < inputs.Length; i += 3)
        {
            if (i + 2 < inputs.Length)
            {
                queries.Add(new List<int> { int.Parse(inputs[i]), int.Parse(inputs[i + 1]), int.Parse(inputs[i + 2]) });
            }
        }

        List<int> result = Result.dynamicArray(n, queries);

        Console.WriteLine(String.Join("\n", result));
    }
} 
