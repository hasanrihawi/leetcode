using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Types.Graph
{
    class Graph2
    {
        int numberOfVertices;
        LinkedList<int>[] graph;
        bool[] visited;
        long[] costs;

        Graph2(int numberOfVertices, long[] costs)
        {
            this.numberOfVertices = numberOfVertices;
            this.graph = new LinkedList<int>[numberOfVertices];
            for (int v = 0; v < numberOfVertices; v++)
            {
                graph[v] = new LinkedList<int>();
            }

            this.costs = costs;
            this.visited = new bool[numberOfVertices];

        }

        void addEdge(int u, int v)
        {
            graph[u].AddLast(v);
            graph[v].AddLast(u);
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
            int numberOfVertices = 5;

            // number of relations
            int numberOfRelations = 2;

            // cost of saying the rumor to person
            long[] costs = new long[numberOfVertices];

            Graph2 g = new Graph2(numberOfVertices, costs);

            // numberOfVertices
            costs[0] = 2;
            costs[1] = 5;
            costs[2] = 3;
            costs[3] = 4;
            costs[4] = 8;

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

            // number of relations
            int numberOfRelations = 5;

            // cost of saying the rumor to person
            long[] costs = new long[numberOfVertices];
            // numberOfVertices
            costs[0] = 1;
            costs[1] = 6;
            costs[2] = 2;
            costs[3] = 7;
            costs[4] = 3;
            costs[5] = 8;
            costs[6] = 4;
            costs[7] = 9;
            costs[8] = 5;
            costs[9] = 10;


            Graph2 g = new Graph2(numberOfVertices, costs);

            // numberOfRelations
            g.addEdge(0, 1);
            g.addEdge(2, 3);
            g.addEdge(4, 5);
            g.addEdge(6, 7);
            g.addEdge(8, 9);


            // Expected Output: 10
            g.minimumSumConnectedComponents();
        }
    }
}
