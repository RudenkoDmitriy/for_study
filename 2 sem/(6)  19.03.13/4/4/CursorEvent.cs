using System;
namespace _4
{
    public class CursorEvent
    {
        public event EventHandler left = (sender, args) => { };
        public event EventHandler right = (sender, args) => { };
        public event EventHandler up = (sender, args) => { };
        public event EventHandler down = (sender, args) => { };

        public void EventLeft(EventArgs e)
        {
            left.Invoke(this, e);
        }

        public void EventDown(EventArgs e)
        {
            down.Invoke(this, e);
        }

        public void EventRight(EventArgs e)
        {
            right.Invoke(this, e);
        }

        public void EventUp(EventArgs e)
        {
            up.Invoke(this, e);
        }

        public CursorEvent()
        {
            EventArgs eArgs = new EventArgs();
            while (true)
            {             
                var key = Console.ReadKey(false);
                Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    EventUp(eArgs);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    EventDown(eArgs);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    EventLeft(eArgs);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    EventRight(eArgs);
                }
            }
        }
    }
}
