using Raylib_cs;
using System;
using System.Collections.Generic;

namespace UntitledGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetTargetFPS(60);
            List<string> log = new List<string>();


            int f = 0;
            int seconds = 0;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Hello, world!", 300, 12, 20, Color.BLACK);

                log.Reverse();
                int YPos = 460;
                foreach(string s in log)
                {
                    Raylib.DrawText(s, 12, YPos, 20, Color.BLACK);
                    YPos -= 20;
                }
                log.Reverse();

                Raylib.EndDrawing();
                f++;
                if(f >= 60)
                {
                    f = 0;
                    seconds++;
                    log.Add($"{seconds}...");
                }
                
            }

            Raylib.CloseWindow();
        }
    }
}
