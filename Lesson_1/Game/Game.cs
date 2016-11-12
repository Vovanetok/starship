using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    static class Game
    {
        static public Random rnd = new Random();
        static BufferedGraphicsContext context;
        static public BufferedGraphics buffer;

        static public int Width { get; set; }
        static public int Height { get; set; }

        static BaseObject[] objs = new BaseObject[20];

        static Game()
        {
        }

        static public void Init(Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.Width;
            Height = form.Height;
            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));

        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Update();
            Draw();
        }

        static public void Load()
        {
            for (int i = 0; i < objs.Length; i++)
                objs[i] = new BaseObject();
            System.Timers.Timer timer = new System.Timers.Timer(100);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }

        static public void Draw()
        {
            buffer.Graphics.Clear(Color.Black);
            //buffer.Graphics.FillEllipse(Brushes.White, new Rectangle(100, 100, 200, 200));
            //buffer.Graphics.DrawString("Hello", new Font("Arial", 30), Brushes.Violet, 100, 100);
            foreach (var el in objs)
                el.Show();
            buffer.Render();
        }

        static public void Update()
        {
            foreach (var el in objs)
                el.Update();
        }
    }
}
