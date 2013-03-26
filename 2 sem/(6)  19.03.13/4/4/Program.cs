using System;
using System.Windows.Forms;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            CursorEvent c = new CursorEvent();
            MoveCursore cursore = new MoveCursore(c);
            c.Run();           
        }
    }
}
