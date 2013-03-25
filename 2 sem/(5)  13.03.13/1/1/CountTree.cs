using System.IO;

namespace _1
{
    public class CountTree
    {
        private string example;
        private int countOfExample;
        private Node root;

        private Node TypeOfNode(char c)
        {
            if (c == '+')
                return new Add();
            if (c == '-')
                return new Subtract();
            if (c == '*')
                return new Multiply();
            if (c == '/')
                return new Divide();
            return new Number();
        }

        private void Add(Node pos, bool check)
        {
            char c = 'a';
            if (countOfExample < example.Length)
            {
                c = example[countOfExample];
                ++countOfExample;
                if (c != '(' && c != ')' && c != ' ')
                {
                    Node temp = TypeOfNode(c);
                    temp.Value = c;
                    if (check)
                    {
                        pos.Left = temp;
                    }
                    else
                    {
                        pos.Right = temp;
                    }
                    Add(pos.Left, true);
                    Add(pos, false);
                }
                if (c == '(')
                {
                    Add(pos, true);
                }
            }
        }

        public CountTree(string s)
        {
            root = new Add();
            countOfExample = 0;
            using (StreamReader f = new StreamReader(s))
            {
                example = f.ReadLine();
            }
            Add(root, true);
        }

        public int Count()
        {
            return root.Left.Action();
        }

        public void Print()
        {
            root.Left.Print();
        }

        public Node Root()
        {
            return root.Left;
        }
    }
}
