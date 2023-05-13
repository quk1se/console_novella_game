using novella1.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using novella1.GamesChapters;
using novella1.FullGame;
using novella1.Interface;

namespace novella
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.Title = "Island Novella";
            FullGame game = new FullGame();
            //game.StartFullGame();
            GameChapter2 gc2 = new GameChapter2();
            gc2.StartGame();
            Console.Read();
        }
    }
}
