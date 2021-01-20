using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledCore
{
    public class EngineConfig
    {
        public string GameName = "Untitled Game Engine";
        public int Win_Width = 1280;
        public int Win_Height = 720;
        public RefRate RefreshRate = RefRate.fps60;

    }

    public enum RefRate
    {
        fps30 = 30, fps60 = 60, fps90 = 90, fps144 = 144, fpsNoLimit = 0
    }
}
