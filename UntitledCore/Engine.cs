using System;
using System.Collections.Generic;
using Raylib_cs;

namespace UntitledCore
{
    public class Engine
    {
        List<string> Log;
        public Engine()
        {
            //Initialize
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetTargetFPS(60);
            Log = new List<string>();
        }

        public void Run()
        {
            //Run the game. (Update/Draw)
            int f = 0;
            int seconds = 0;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Hello, world!", 300, 12, 20, Color.BLACK);

                Log.Reverse();
                int YPos = 460;
                foreach (string s in Log)
                {
                    Raylib.DrawText(s, 12, YPos, 20, Color.BLACK);
                    YPos -= 20;
                }
                Log.Reverse();

                Raylib.EndDrawing();
                f++;
                if (f >= 60)
                {
                    f = 0;
                    seconds++;
                    Log.Add($"{seconds}...");
                }

            }

            Raylib.CloseWindow();
        }

         ~Engine()
        {
            //cleanup
        }

    }
}
