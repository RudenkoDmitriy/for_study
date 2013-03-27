using System;
namespace _4
{
    public class CursorEvent
    {
        public event EventHandler left = (sender, args) => { };
        public event EventHandler right = (sender, args) => { };
        public event EventHandler up = (sender, args) => { };
        public event EventHandler down = (sender, args) => { };

        public void Run()
        {
            while (true)
            {             
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    up(this, EventArgs.Empty);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    down(this, EventArgs.Empty);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    left(this, EventArgs.Empty);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    right(this, EventArgs.Empty); 
                }
            }
        }
    }
}
