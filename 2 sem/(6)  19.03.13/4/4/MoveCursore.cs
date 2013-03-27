using System;

namespace _4
{
    public class MoveCursore
    {
        public MoveCursore(CursorEvent ev)
        {
            ev.left += new EventHandler(CursoreMoveLeft);
            ev.right += new EventHandler(CursoreMoveRight);
            ev.up += new EventHandler(CursoreMoveTop);
            ev.down += new EventHandler(CursoreMoveBottom);
        }

        public void CursoreMoveLeft(Object sender, EventArgs e)
        {
            if (Console.CursorLeft < 2)
            {
                return;
            }
            Console.CursorLeft--;
        }

        public void CursoreMoveRight(Object sender, EventArgs e)
        {
            Console.CursorLeft++;
        }

        public void CursoreMoveTop(Object sender, EventArgs e)
        {
            if (Console.CursorTop < 1)
            {
                return;
            }
            Console.CursorTop--;
        }

        public void CursoreMoveBottom(Object sender, EventArgs e)
        {
            Console.CursorTop++;
        }
    }
}
