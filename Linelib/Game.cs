using System;
using SDL2;

namespace AnteaterStudios.Linelib
{
    public class Game
    {
        private GameTime _gameTime = new GameTime();

        protected virtual string WindowTitle { get; } = "Title";
        protected virtual void Initialize() { }
        protected virtual void LoadContent() { }
        protected virtual void Update(GameTime gameTime) { }
        protected virtual void Draw(GameTime gameTime) { }

        public void Run()
        {
            if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
            {
                Console.WriteLine("Unable to initialize SDL. Error: {0}", SDL.SDL_GetError());
            }
            else
            {
                var window = IntPtr.Zero;

                window = SDL.SDL_CreateWindow(WindowTitle,
                    SDL.SDL_WINDOWPOS_CENTERED,
                    SDL.SDL_WINDOWPOS_CENTERED,
                    1020,
                    800,
                    SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE
                );

                if (window == IntPtr.Zero)
                {
                    Console.WriteLine("Unable to create a window. Error: {0}", SDL.SDL_GetError());
                }
                else
                {
                    SDL.SDL_Event e;
                    bool quit = false;

                    while (!quit)
                    {
                        while (SDL.SDL_PollEvent(out e) != 0)
                        {
                            switch (e.type)
                            {
                                case SDL.SDL_EventType.SDL_QUIT:
                                    quit = true;
                                    break;
                            }
                        }
                    }

                    SDL.SDL_DestroyWindow(window);
                }

                SDL.SDL_Quit();
            }
        }
    }
}
