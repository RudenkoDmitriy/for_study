
namespace Robots
{
    public class RobotsNetwork
    {
        public RobotsNetwork(string path)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            this.g = new Graph(file.Read() - 48);
            if (this.g.NumberOfVertex < 1)
                throw new IncorrectInputException();
            this.hereRobot = new bool[this.g.NumberOfVertex];
            file.ReadLine();
            file.ReadLine();
            while (true)
            {
                string[] temp = file.ReadLine().Split(' ');
                if (temp[0][0] == 'R')
                    break;
                if (((temp[0][0] - 48) < 0) || ((temp[1][0] - 48) < 0) || ((temp[1][0] - 48) > (this.g.NumberOfVertex - 1)) || ((temp[0][0] - 48) > (this.g.NumberOfVertex - 1)))
                    throw new IncorrectInputException();
                g.AddEdge(temp[0][0] - 48, temp[1][0] - 48);
            }
            string[] listRob = file.ReadLine().Split(' ');
            for (int i = 0; i < listRob.Length; ++i)
            {   
                if (((listRob[i][0] - 48) < 0 ) || ((listRob[i][0] - 48) > this.g.NumberOfVertex - 1))
                    throw new IncorrectInputException();
                this.hereRobot[listRob[i][0] - 48] = true;
            }
            this.classA = new bool[this.g.NumberOfVertex];
            this.classB = new bool[this.g.NumberOfVertex];
            this.visited = new bool[this.g.NumberOfVertex];
            this.Traverse(0, true);
        }

        /// <summary>
        /// This function check: Are all robots might be destroyed?
        /// </summary>
        /// <returns></returns>
        public bool isDestroy()
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < this.g.NumberOfVertex; ++i)
            {
                if ((this.classA[i]) && (this.hereRobot[i]))
                    count1++;
                if ((this.classB[i]) && (this.hereRobot[i]))
                    count2++;               
            }
            return ((count1 != 1) && (count2 != 1));
        }

        private void Traverse(int robotNumber, bool isClassA)
        {
            if (isClassA)
                classA[robotNumber] = true;
            else
                classB[robotNumber] = true;
            this.visited[robotNumber] = true;
            for (int i = 0; i < this.g.NumberOfVertex; ++i)
            {
                if (!visited[i] && this.g.Matrix[robotNumber][i])
                    this.Traverse(i, !isClassA);
            }
        }

        private bool[] classA;
        private bool[] classB;
        private bool[] visited;
        private bool[] hereRobot;
        private Graph g;
    }
}
