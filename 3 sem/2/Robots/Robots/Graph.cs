
namespace Robots
{
    public class Graph
    {
        /// <summary>
        /// Builds adjacency matrix. 
        /// </summary>
        /// <param name="numberOfVertex"></param>
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
        /// Checks Is edge between  vertex1 and vertex2?
        /// </summary>
        /// <returns></returns>
        public bool IsEdge (int vertex1, int vertex2)
        {
            return this.matrix[vertex1][vertex2];
        }

        public int NumberOfVertex { get; private set; }

        private bool[][] matrix; 
    }
}
