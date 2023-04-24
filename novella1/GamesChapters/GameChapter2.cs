using novella1.Characters;
using novella1.Choices;
using novella1.Interface;
using novella1.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novella1.GamesChapters
{
    internal class GameChapter2 : GameDrawing
    {
        public static bool InhalerChoice { get; set; }


        public void StartGame()
        {
            Bob b = new Bob();
            Jeff j = new Jeff();
            Marko m = new Marko();
            Rose r = new Rose();
            Demon d = new Demon();
            Events e = new Events();
            ChoicesChapter2 cc2 = new ChoicesChapter2();
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2);
            e.TextReader(e.ReaderChoiceChapter2, ref e.lastPositionChoiceChapter2);
            InhalerChoice = cc2.InhalerChoice();
            if (InhalerChoice)
            {
                b.TextReader(b.ReaderChoiceChapter2, ref b.lastPositionChoiceChapter2);
                r.TextReader(r.ReaderChoiceChapter2, ref r.lastPositionChoiceChapter2);
            }
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            d.TextReader(d.ReaderChapter2, ref d.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            d.TextReader(d.ReaderChapter2, ref d.lastPositionChapter2);
            d.TextReader(d.ReaderChapter2, ref d.lastPositionChapter2);
            b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
            m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
            j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
            r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
            if (InhalerChoice == false)
            {
                j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                r.Life = false;
                b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                }
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 7; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                }
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                }
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    if (i < 3)
                    {
                        m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                    }
                }
                m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                }
                e.TextReader(e.ReaderNoInhalerChapter2, ref e.lastPositionNoInhalerChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    j.TextReader(j.ReaderNoInhalerChapter2, ref j.lastPositionNoInhalerChapter2);
                    b.TextReader(b.ReaderNoInhalerChapter2, ref b.lastPositionNoInhalerChapter2);
                    m.TextReader(m.ReaderNoInhalerChapter2, ref m.lastPositionNoInhalerChapter2);
                }
            }
            else 
            {
                r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                for (int i = 0; i < 5; i++)
                {
                    j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                    b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                    m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                    r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                }
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                    b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                    m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                    r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                }
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                    b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                    m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                    if (i < 3) r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                }
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                    b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                    m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                    if (i < 1) r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                }
                e.TextReader(e.ReaderChapter2, ref e.lastPositionChapter2); Thread.Sleep(1000); Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    j.TextReader(j.ReaderChapter2, ref j.lastPositionChapter2);
                    b.TextReader(b.ReaderChapter2, ref b.lastPositionChapter2);
                    m.TextReader(m.ReaderChapter2, ref m.lastPositionChapter2);
                    r.TextReader(r.ReaderChapter2, ref r.lastPositionChapter2);
                }
            }
        }
    }
}
