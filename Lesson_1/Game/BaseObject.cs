using System;
using System.Drawing;

namespace Game
{
    class BaseObject
    {
        Point pos, dir;

        public BaseObject()
        {
            pos.X = Game.rnd.Next(0, Game.Width);
            pos.Y = Game.rnd.Next(0, Game.Height);
            dir.X = Game.rnd.Next(-10, 10);
            dir.Y = Game.rnd.Next(-10, 10);
        }

        public BaseObject(Point pos, Point dir)
        {
            this.pos = pos;
            this.dir = dir;
        }

        public void Show()
        {
            Game.buffer.Graphics.DrawEllipse(Pens.AliceBlue, new Rectangle(pos, new Size(40, 40)));
        }

        public void Update()
        {
            pos.X = pos.X + dir.X;
            pos.Y = pos.Y + dir.Y;
            if (pos.X < 0 || pos.X > Game.Width) dir.X = -dir.X;
            if (pos.Y < 0 || pos.Y > Game.Width) dir.Y = -dir.Y;
        }

    }
}
