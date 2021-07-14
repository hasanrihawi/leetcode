using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types.Graph
{
    class Graph2
    {
        int numberOfVertices;
        List<int>[] graph;
        bool[] visited;
        long[] costs;

        Graph2(int numberOfVertices, long[] costs)
        {
            this.numberOfVertices = numberOfVertices;
            this.graph = new List<int>[numberOfVertices];
            for (int v = 0; v < numberOfVertices; v++)
            {
                graph[v] = new List<int>();
            }

            this.costs = costs;
            this.visited = new bool[numberOfVertices];
        }

        void addEdge(int n1, int n2)
        {
            graph[n1].Add(n2);
            graph[n2].Add(n1);
        }

        long dfs(int node, long miniCost)
        {
            // Stores the minimum
            miniCost = Math.Min(miniCost, costs[node]);

            // Marks node as visited
            visited[node] = true;

            // Traversed in all the connected nodes
            foreach (var i in graph[node])
            {
                if (!visited[i])
                    miniCost = dfs(i, miniCost);
            }

            return miniCost;
        }

        void minimumSumConnectedComponents()
        {
            // Initially sum is 0
            long sum = 0L;

            // Traverse for all nodes
            for (int i = 0; i < numberOfVertices; i++)
            {
                if (!visited[i])
                {
                    sum += dfs(i, costs[i]);
                }
            }

            // Returns the answer
            Console.WriteLine(sum);
        }

        public static void main1(String[] args)
        {
            // number of persons
            int numberOfNodes = 5;

            // cost of saying the rumor to person
            long[] costs = new long[] { 2, 5, 3, 4, 8 };

            Graph2 g = new Graph2(numberOfNodes, costs);

            // numberOfRelations
            g.addEdge(0, 3);
            g.addEdge(3, 4);

            // Expected Output: 10
            g.minimumSumConnectedComponents();
        }

        public static void main2(String[] args)
        {
            // number of persons
            int numberOfVertices = 10;

            // cost of saying the rumor to person
            long[] costs = new long[] { 1, 6, 2, 7, 3, 8, 4, 9, 5, 10 };

            Graph2 g = new Graph2(numberOfVertices, costs);

            // numberOfRelations
            g.addEdge(0, 1);
            g.addEdge(2, 3);
            g.addEdge(4, 5);
            g.addEdge(6, 7);
            g.addEdge(8, 9);

            // Expected Output: 15
            g.minimumSumConnectedComponents();
        }
    }
}
