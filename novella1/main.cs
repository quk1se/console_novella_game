using novella1.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using novella1.GamesChapters;

namespace novella
{
    internal class main
    {
        static void Main(string[] args)
        {
            /*GameChapter1 gc1 = new GameChapter1();
            gc1.StartGame();*/
            GameChapter2 gc2 = new GameChapter2();
            GameChapter3 gc3 = new GameChapter3();
            //gc2.StartGame();
            gc3.StartGame();
            Console.Read();
        }
    }
}
