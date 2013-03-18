using System;
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

        private void Add(Node  pos, bool check)
        {
            char c = 'a';
            if  (countOfExample < example.Length)
            {
                c = example[countOfExample];
                ++countOfExample;
                if (c != '(' && c != ')' && c != ' ')
                {
                    Node temp = TypeOfNode(c);                   
                    temp.value = c;
                    temp.parent = pos;
                    temp.left = new Number();
                    temp.right = new Number();
                    temp.left.parent = temp;
                    temp.right.parent = temp;
                    if (check)
                    {
                        pos.left = temp;
                    }
                    else
                    {
                        pos.right = temp;                    
                    }
                    Add(pos.left, true);
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
            root.left = new Number();
            root.right = new Number();
            root.left.parent = root;
            root.right.parent = root;
            root.parent = root;
            countOfExample = 0;
            using (StreamReader f = new StreamReader(s))
            {
                example = f.ReadLine();
            }
            Add(root, true);
        }

        public int  Count()
        {
            return root.left.Action();
        }

        public void Print()
        {
            root.left.Print();
        }

        public Node Root()
        {
            return root;
        }
    }
}
