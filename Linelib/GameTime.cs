using System;

namespace AnteaterStudios.Linelib
{
    public class GameTime
    {
        public TimeSpan ElapsedGameTime { get; set; }
        public TimeSpan TotalGameTime { get; set; }

        public GameTime()
        {
            ElapsedGameTime = TimeSpan.Zero;
            TotalGameTime = TimeSpan.Zero;
        }
    }
}