using System;
using System.IO;
using System.Collections.Generic;

namespace LocalNetwork
{
    public class Network
    {
        /// <summary>
        /// Path - path to input file. isRand checks real or nor real random.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="isRand"></param>
        public Network(string path, bool isRand)
        {
            StreamReader file = new System.IO.StreamReader(path);
            if (isRand)
                this.rand = new System.Random();
            else
                this.rand = new System.Random(1565456);
            file.ReadLine();
            this.NumberOfComputers = file.Read() - 48;
            if (this.NumberOfComputers < 1)
                throw new IncorrectInputException();
            this.Graph = new Graph(this.NumberOfComputers);
            file.ReadLine();
            file.ReadLine();
            this.ListOfComputers = new Computer[this.NumberOfComputers];
            for (int i = 0; i < this.NumberOfComputers; ++i)
            {
                string[] temp = file.ReadLine().Split(' ');
                char os = temp[0][0];
                int isInfect = temp[1][0] - 48;
                if ((os != 'w' && os != 'l' && os != 'm') || (isInfect != 0 && isInfect != 1))
                    throw new IncorrectInputException();
                this.ListOfComputers[i] = new Computer(os, isInfect);
            }
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string[] temp = file.ReadLine().Split(' ');
                if (((temp[0][0] - 48) < 0) || ((temp[1][0] - 48) < 0) || ((temp[1][0] - 48) > (this.Graph.NumberOfVertex - 1)) || ((temp[0][0] - 48) > (this.Graph.NumberOfVertex - 1)))
                    throw new IncorrectInputException();
                this.Graph.AddEdge(temp[0][0] - 48, temp[1][0] - 48);
            }
        }

        /// <summary>
        /// Changing state of the network in one step.
        /// </summary>
        public void Step()
        {
            Stack<int> st1 = this.Graph.Traverse();
            Stack<int> st2 = new Stack<int>();
            while (st1.Count > 1)
            {
                int temp = st1.Pop();
                if (this.Graph.IsEdge(temp, st1.Peek()))
                {
                    if (this.ListOfComputers[temp].Virus)
                        this.ListOfComputers[st1.Peek()].Infection(this.rand.Next());
                }
                else
                {
                    if (st2.Count != 0)
                    {
                        if (this.Graph.IsEdge(st2.Peek(), temp))
                        {
                            if (this.ListOfComputers[temp].Virus)
                                this.ListOfComputers[st2.Peek()].Infection(this.rand.Next());
                            st2.Pop();
                        }
                        else
                            st2.Push(temp);
                    }
                    else
                        st2.Push(temp);
                }
            }
        }

        /// <summary>
        /// Displays the state of the console.
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < this.NumberOfComputers; ++i)
            {
                string inf;
                if (ListOfComputers[i].Virus)
                    inf = " infected.";
                else
                    inf = " not infected.";
                string temp = i + 1 + ") " + ListOfComputers[i].OperationSystem + inf;
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }

        public Graph Graph { get; private set; }
        public Computer[] ListOfComputers { get; private set; }
        public int NumberOfComputers { get; private set; }

        private System.Random rand;
    }
}
