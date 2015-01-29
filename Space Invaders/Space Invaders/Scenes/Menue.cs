﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace Space_Invaders.Scenes
{
    class Menue : Scene
    {
        public Menue() : base()
        {
            Console.WriteLine("[Scene] Initiating \"Menue\"");
            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                int x = random.Next(0, 480);
                int y = random.Next(0, 720);
                Add(new Objects.starLine(x,y));
            }
            Console.WriteLine("[Scene] Initiated \"Menue\"");
        }
        public override void Begin()
        {
            base.Begin();

            Console.WriteLine("[Scene] Scene \"Menue\" hast begun.");
        }
        public override void End()
        {
            base.End();
            Console.WriteLine("[Scene] Scene \"Menue\" hast end.");
        }
    }
}
