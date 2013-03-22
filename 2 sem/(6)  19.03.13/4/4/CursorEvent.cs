using System;
namespace _4
{
    public class CursorEvent
    {
        public event EventHandler left;
        public event EventHandler right;
        public event EventHandler up;
        public event EventHandler down;

        public void EventLeft(EventArgs e)
        {
            EventHandler Left = left;
            Left(this, e);
        }

        public void EventDown(EventArgs e)
        {
            EventHandler Down = down;
            Down(this, e);
        }

        public void EventRight(EventArgs e)
        {
            EventHandler Right = right;
            Right(this, e);
        }

        public void EventUp(EventArgs e)
        {
            EventHandler Up = up;
            Up(this, e);
        }
    }
}
