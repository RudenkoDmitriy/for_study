using System.Collections.Generic;

namespace LocalNetwork
{
    public class Graph
    {
        public Graph(int numberOfVertex)
        {
            this.NumberOfVertex = numberOfVertex;
            this.matrix = new bool[numberOfVertex][];
            for (int i = 0; i < numberOfVertex; ++i)
                this.matrix[i] = new bool[numberOfVertex];
        }

        /// <summary>
        /// Adds edge between vertex1 and vertex2.
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        public void AddEdge(int vertex1, int vertex2)
        {
            matrix[vertex1][vertex2] = true;
            matrix[vertex2][vertex1] = true;
        }

        /// <summary>
        /// Checks :Is whether edge between vertex1 and vertex2?
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        /// <returns></returns>
        public bool IsEdge(int vertex1, int vertex2)
        {
            return matrix[vertex1][vertex2];
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

        public bool[][] GetMatrix()
        {
            return this.matrix;
        }

        public int NumberOfVertex { get; private set; }

        private void TraverseTemp(int numberOfVertex, bool[] visited, Stack<int> st)
        {
            visited[numberOfVertex] = true;
            st.Push(numberOfVertex);
            for (int i = 0; i < this.NumberOfVertex; ++i)
            {
                if (!visited[i] && this.matrix[numberOfVertex][i])
                    this.TraverseTemp(i, visited, st);
            }
        }

        private bool[][] matrix;
    }
}

