using System;
using System.IO;
namespace LocalNetwork
{
    public class Network
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="path">
        /// First has written number of computers.
        /// Second has written list of computers in the form of
        /// w, inter, 1....enter       where 1/0 - infected/ not infected, w/l/m - windows/linux/mac.
        /// Third has written matrix in one string.
        /// </param>
        public Network(string path)
        {
            StreamReader file = new System.IO.StreamReader(path);
            this.numberOfComputers = file.Read() - 48;
            if (this.numberOfComputers < 1)
                throw new IncorrectInputException();
            file.ReadLine();
            this.listOfComputers = new Computer[this.numberOfComputers];
            this.matrix = new bool[this.numberOfComputers][];
            for (int i = 0; i < this.numberOfComputers; ++i)
            {
                string temp = file.ReadLine();
                char os = temp[0];
                int isInfect = file.Read() - 48;
                file.ReadLine();
                if ((os != 'w' && os != 'l' && os != 'm') || (isInfect != 0 && isInfect != 1))
                    throw new IncorrectInputException();
                this.listOfComputers[i] = new Computer(os, isInfect);
            }
            string[] matr = file.ReadLine().Split(' ');
            int count = 0;
            for (int i = 0; i < this.numberOfComputers; ++i)
            {
                this.matrix[i] = new bool[this.numberOfComputers];
                for (int j = 0; j < this.numberOfComputers; ++j)
                {
                    int temp = matr[count][0] - 48;
                    if (temp !=0 && temp != 1)
                        throw new IncorrectInputException();
                    matrix[i][j] = temp == 1;
                    count++;                  
                }
            }
        }

        /// <summary>
        /// Changing state of the network in one step.
        /// </summary>
        public void Step()
        {
            bool[] visited = new bool[numberOfComputers];
            for (int i = 0; i < this.numberOfComputers; ++i)
                visited[i] = false;
            this.Traverse(0, false, visited);
        }

        /// <summary>
        /// Displays the state of the console.
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < this.numberOfComputers; ++i)
            {
                string inf;
                if (listOfComputers[i].Virus)
                    inf = " infected.";
                else
                    inf = " not infected.";
                string temp = i + 1 + ") " + listOfComputers[i].OperationSystem + inf;
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }

        private Computer[] listOfComputers;
        private bool[][] matrix;
        private int numberOfComputers;
        private void Traverse(int numberOfComputer, bool isInfection, bool[] visited)
        {
            visited[numberOfComputer] = true;
            if (isInfection)
                this.listOfComputers[numberOfComputer].Infection();
            for (int i = 0; i < this.numberOfComputers; ++i)
            {
                if (!visited[i] && this.matrix[numberOfComputer][i])
                    this.Traverse(i, this.listOfComputers[numberOfComputer].Virus, visited);
            }
        }
    }
}
