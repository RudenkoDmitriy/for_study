
namespace Robots
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

        public void AddEdge(int vertex1, int vertex2)
        {
            Matrix[vertex1][vertex2] = true;
            Matrix[vertex2][vertex1] = true;
        }

        public int NumberOfVertex { get; private set; }

        public bool[][] Matrix { get; private set; }     
    }
}
