using System;
using System.Windows.Forms;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 700;
            form.Height = 600;
            form.Show();
            Game.Init(form);
            Game.Load();
            Game.Draw();

            Application.Run(form);
        }

    }
}
