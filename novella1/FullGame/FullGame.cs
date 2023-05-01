using novella1.GamesChapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novella1.FullGame
{
    internal class FullGame
    {
        public void StartFullGame()
        {
            GameChapter1 gc1 = new GameChapter1();
            GameChapter2 gc2 = new GameChapter2();
            GameChapter3 gc3 = new GameChapter3();
            gc1.StartGame();
            gc2.StartGame();
            gc3.StartGame();
        }
    }
}
