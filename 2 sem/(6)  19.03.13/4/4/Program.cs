using System;
using System.Windows.Forms;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            CursorEvent cEv = new CursorEvent();
            EventArgs eArgs = new EventArgs();
            MoveCursore c = new MoveCursore(cEv);
            Keys keyData = new Keys();
            KeyEventArgs e = new KeyEventArgs(keyData);
            cEv.EventRight(eArgs);
            while (true)
            {
                if (e.KeyData == Keys.Up)
                {
                    cEv.EventUp(eArgs);
                }
                if (e.KeyData == Keys.Down)
                {
                    cEv.EventDown(eArgs);
                }
                if (e.KeyData == Keys.E)
                {
                    cEv.EventLeft(eArgs);
                }
                if (e.KeyData == Keys.Right)
                {
                    cEv.EventRight(eArgs);
                }
            }
        }
    }
}
