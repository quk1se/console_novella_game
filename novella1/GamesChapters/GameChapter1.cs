using novella1.Characters;
using novella1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace novella1.GamesChapters
{
    internal class GameChapter1 : GameDrawing
    {
        public void StartScreenChapter()
        {
            Console.WriteLine("Откройте консоль на весь экран, как только вы это сделаете, нажмите Space.");
            while ((Console.ReadKey(true)).Key != ConsoleKey.Spacebar)
            {

            }
            Console.Clear();
            Thread.Sleep(1000);
        }
        public void ShowRules()
        {
            Console.WriteLine("\t\t\t\t\t\t\t    Все персонажи вымышлены,история не взята из реальной жизни, все это просто фантазия.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\t\t\t\t\t\t\t\tВаш выбор может повлиять на дальнейшее развитие событий.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\t\t\t\t\t\t\t  Если вы видите на своем экране сообщение выделенное [] - это выбор.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t  Для продвижения по диалогу нажимайте клавишу Space.");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t      Если вы готовы начать игру, нажмите Space.");
            Console.ForegroundColor = ConsoleColor.White;
            while ((Console.ReadKey(true)).Key != ConsoleKey.Spacebar)
            {

            }
            Console.Clear();
            Thread.Sleep(1000);
        }
        public void StartGame()
        {
            Bob b = new Bob();
            Jeff j = new Jeff();
            Marko m = new Marko();
            Rose r = new Rose();
            Demon d = new Demon();
            for (int i = 0; i < 5; i++)
            {
                j.TextReader(j.ReaderChapter1, ref j.lastPositionChapter1);
                if (i == 4) break;
                b.TextReader(b.ReaderChapter1, ref b.lastPositionChapter1);
            }
            for (int i = 0; i < 6; i++)
            {
                m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
                if (i == 5) break;
                r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            }
            j.TextReader(j.ReaderChapter1, ref j.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            b.TextReader(b.ReaderChapter1, ref b.lastPositionChapter1);
            r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            j.TextReader(j.ReaderChapter1, ref j.lastPositionChapter1);
            d.ShowPersonWoman();
            d.TextReaderChapter1(d.ReaderChapter1, ref d.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            d.ShowPersonWoman();
            d.TextReaderChapter1(d.ReaderChapter1, ref d.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            j.TextReader(j.ReaderChapter1, ref j.lastPositionChapter1);
            b.TextReader(b.ReaderChapter1, ref b.lastPositionChapter1);
            r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            d.ShowPersonPilot();
            d.TextReaderChapter1(d.ReaderChapter1, ref d.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            r.TextReader(r.ReaderChapter1, ref r.lastPositionChapter1);
            m.TextReader(m.ReaderChapter1, ref m.lastPositionChapter1);
            j.TextReader(j.ReaderChapter1, ref j.lastPositionChapter1);
            b.TextReader(b.ReaderChapter1, ref b.lastPositionChapter1);
        }
    }
}
