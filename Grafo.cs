using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_de_grafos
{
    internal class Grafo
    {
        public int Vertix;
        public Dictionary<int, List<int>> AdjList;

        public Grafo()
        {
            AdjList = new Dictionary<int, List<int>>();
        }

        public void InsertVertix(int Vertix)
        {
            AdjList[Vertix] = new List<int>();
        }

        public void InsertEdge(int VertixA, int VertixB, bool IsDirected)
        {
            if (AdjList.ContainsKey(VertixA))
            {
                AdjList[VertixA].Add(VertixB);
                if (!IsDirected && AdjList.ContainsKey(VertixB))
                {
                    AdjList[VertixB].Add(VertixA);
                }
            }
        }

        public void MostrarListaAdy()
        {
            int i = 0;
            foreach (var ParVertix in AdjList)
            {
                Console.Write(ParVertix.Key + " ---> ");
                foreach (var item in AdjList[ParVertix.Key])
                {
                        Console.Write(item + " ");
                    i++;
                }
                Console.WriteLine("");
            }
        }

        public void DFS(int origin)
        {
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            foreach (var ParVertix in AdjList)
            {
                visited[ParVertix.Key] = false;
            }
            DFS(origin, visited);
        }
        public void DFS(int startVertix, Dictionary<int, bool> visited)
        {
            if (visited[startVertix]) { return; } 

            Console.Write(startVertix + " ");
            visited[startVertix] = true; 

            foreach (int neighbor in AdjList[startVertix])
            {
                DFS(neighbor, visited);
            }
        }

        public void BFS(int origin)
        {
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            foreach (var ParVertix in AdjList)
            {
                visited[ParVertix.Key] = false;
            }

            Queue<int> queue = new Queue<int>();
            
           queue.Enqueue(origin);
           while (queue.Any())
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");
                foreach(int i in AdjList[current])
                {
                    {
                        if (!visited[i])
                        {
                            queue.Enqueue((int)i);
                            visited[i] = true;
                        }
                    }
                }
                
            }
        
        }
    }
}
