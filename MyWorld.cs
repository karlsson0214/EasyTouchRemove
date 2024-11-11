using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using EasyTouchRemove;

namespace EasyStart
{
    internal class MyWorld : World
    {
        public MyWorld() : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            Add(new Turtle(), "turtle2", 400, 300);
            Add(new Plum(), "plum", 200, 150);
            Add(new Plum(), "plum", 200, 450);
            Add(new Plum(), "plum", 600, 150);
            Add(new Plum(), "plum", 600, 450);
        }
    }
}
