using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode.Arrays
{
    public class graghTest1
    {
        public static void solution()
        {
            List<int>[] graph = new List<int>[8];
            for (int i = 0; i < graph.Length; i++)
                graph[i] = new List<int>();

            graph[1].Add(2);
            graph[1].Add(1);
            graph[1].Add(4);
            graph[4].Add(3);
            graph[3].Add(5);
            graph[5].Add(3);
            graph[6].Add(7);
            graph[7].Add(6);

            var sorted = graph
            .Select((x, i) => new KeyValuePair<List<int>, int>(x, i))
            .OrderByDescending(x => x.Key.Count)
            .ToList();

            int[] values = new int[8];
            int value = 8;
            foreach (var item in sorted)
            {
                values[item.Value] = value;
                value--;
            }
        }
    }
}
