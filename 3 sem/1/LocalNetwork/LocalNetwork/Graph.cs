using System.Collections.Generic;

namespace LocalNetwork
{
    public class Graph
    {
        public Graph(int numberOfVertex)
        {
            this.NumberOfVertex = numberOfVertex;
            this.Matrix = new bool[numberOfVertex][];
            for (int i = 0; i < numberOfVertex; ++i)
                this.Matrix[i] = new bool[numberOfVertex];
        }

        /// <summary>
        /// Adds edge between vertex1 and vertex2.
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        public void AddEdge(int vertex1, int vertex2)
        {
            Matrix[vertex1][vertex2] = true;
            Matrix[vertex2][vertex1] = true;
        }

        /// <summary>
        /// Checks :Is whether edge between vertex1 and vertex2?
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        /// <returns></returns>
        public bool IsEdge(int vertex1, int vertex2)
        {
            return Matrix[vertex1][vertex2];
        }

        /// <summary>
        /// Depth-first search. Returns stack with numbers of vertexes.
        /// </summary>
        /// <returns></returns>
        public Stack<int> Traverse()
        {
            Stack<int> st = new Stack<int>();
            bool[] visited = new bool[this.NumberOfVertex];
            this.TraverseTemp(0, visited, st);
            return st;
        }

        public int NumberOfVertex { get; private set; }
        public bool[][] Matrix { get; private set; }


        private void TraverseTemp(int numberOfVertex, bool[] visited, Stack<int> st)
        {
            visited[numberOfVertex] = true;
            st.Push(numberOfVertex);
            for (int i = 0; i < this.NumberOfVertex; ++i)
            {
                if (!visited[i] && this.Matrix[numberOfVertex][i])
                    this.TraverseTemp(i, visited, st);
            }
        }
    }
}

