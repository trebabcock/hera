using System;
using Hera;

namespace hera
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene("triangle", 0);

            Game game = new Game(900, 500, "Hera");
            game.SetDefaultScene(scene);
            game.Run(60);
        }
    }
}
