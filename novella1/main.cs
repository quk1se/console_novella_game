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
            GameChapter1 gc1 = new GameChapter1();
            gc1.StartGame();
            Console.Read();
        }
    }
}
