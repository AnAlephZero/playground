using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algos
{
    internal class GraphDSF
    {

        //Time complexity: O(V + E), where V is the number of vertices and E is the number of edges in the graph.
        //Space Complexity: O(V), since an extra visited array of size V is required.


        //il numero dei vertici
        private int verticeNumber;
        //il numero dei nodi adiacenti
        private List<int>[] adjacency; 

        public GraphDSF(int verticeNumber)
        {
            this.verticeNumber = verticeNumber;
            adjacency = new List<int>[verticeNumber];
            for (int i = 0; i < verticeNumber; i++)
            {
                adjacency[i] = new List<int>();
            }
        }

        //questa funzione aggiunge un ramo tra due vertici 
        public void AddEdge(int v, int w)
        {
            adjacency[v].Add(w);
        }

        void DFSUtil(int v, bool[] visited)
        {
            //dato un nodo, lo marco come visitato e poi lo stampo
            visited[v] = true;
            Debug.WriteLine(v + " ");

            //per ogni ramo che parte da questo nodo
            List<int> vAdj = adjacency[v];
            foreach (var item in vAdj)
            {
                //nel caso non l'avessi visitato provo a percorrerlo
                if (!visited[item])
                {
                    DFSUtil(item, visited);
                }
            }
        }

        public void DFS(int v)
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[verticeNumber];

            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(v, visited);
        }
    }
}
