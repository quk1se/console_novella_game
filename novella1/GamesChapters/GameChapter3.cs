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
    internal class GameChapter3 : GameDrawing
    {
        int saveChoice;

        public void StartGame()
        {
            Bob b = new Bob();
            Jeff j = new Jeff();
            Marko m = new Marko();
            Rose r = new Rose();
            Demon d = new Demon();
            Events e = new Events();
            ChoicesChapter3 cc3 = new ChoicesChapter3();
            /*if (GameChapter2.InhalerChoice == false)
            {
                d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                j.TextReader(j.ReaderNoInhalerChapter3, ref j.lastPositionNoInhalerChapter3);
                d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                b.TextReader(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                j.TextReader(j.ReaderNoInhalerChapter3, ref j.lastPositionNoInhalerChapter3);
                d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                j.TextReader(j.ReaderNoInhalerChapter3, ref j.lastPositionNoInhalerChapter3);
                d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                e.TextReader(e.ReaderChoiceChapter3, ref e.lastPositionChoiceChapter3);
                saveChoice = cc3.SaveChoice();
                if (saveChoice == 0)
                {
                    m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                    b.TextReader(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                    d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                    m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                    m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                    b.TextReader(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                    m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                    m.TextReader(m.ReaderNoInhalerChapter3, ref m.lastPositionNoInhalerChapter3);
                    d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                    d.TextReader(d.ReaderNoInhalerChapter3, ref d.lastPositionNoInhalerChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerChapter3, ref b.lastPositionNoInhalerChapter3);
                }
                else if (saveChoice == 1)
                {
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    m.TextReader(m.ReaderNoInhalerBobChapter3, ref m.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    d.TextReader(d.ReaderNoInhalerBobChapter3, ref d.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    d.TextReader(d.ReaderNoInhalerBobChapter3, ref d.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    b.TextReader(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    e.TextReader(e.ReaderNoInhalerBobChapter3, ref e.lastPositionNoInhalerBobChapter3); Thread.Sleep(1000); Console.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                        b.TextReader(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    }
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    b.TextReader(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    j.TextReader(j.ReaderNoInhalerBobChapter3, ref j.lastPositionNoInhalerBobChapter3);
                    e.TextReader(e.ReaderNoInhalerBobChapter3, ref e.lastPositionNoInhalerBobChapter3); Thread.Sleep(1000); Console.Clear();
                    d.TextReader(d.ReaderNoInhalerBobChapter3, ref d.lastPositionNoInhalerBobChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerBobChapter3, ref b.lastPositionNoInhalerBobChapter3);
                    d.TextReader(d.ReaderNoInhalerBobChapter3, ref d.lastPositionNoInhalerBobChapter3);
                }
                else if (saveChoice == -1)
                {
                    j.TextReader(j.ReaderNoInhalerMarkoChapter3, ref j.lastPositionNoInhalerMarkoChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerMarkoChapter3, ref b.lastPositionNoInhalerMarkoChapter3);
                    d.TextReader(d.ReaderNoInhalerMarkoChapter3, ref d.lastPositionNoInhalerMarkoChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerMarkoChapter3, ref b.lastPositionNoInhalerMarkoChapter3);
                    d.TextReader(d.ReaderNoInhalerMarkoChapter3, ref d.lastPositionNoInhalerMarkoChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerMarkoChapter3, ref b.lastPositionNoInhalerMarkoChapter3);
                    b.TextReaderDemon(b.ReaderNoInhalerMarkoChapter3, ref b.lastPositionNoInhalerMarkoChapter3);
                    for (int i = 0; i < 3; i++)
                    {
                        m.TextReader(m.ReaderNoInhalerMarkoChapter3, ref m.lastPositionNoInhalerMarkoChapter3);
                        if (i < 2) j.TextReader(j.ReaderNoInhalerMarkoChapter3, ref j.lastPositionNoInhalerMarkoChapter3);
                    }
                    e.TextReader(e.ReaderNoInhalerMarkoChapter3, ref e.lastPositionNoInhalerMarkoChapter3); Thread.Sleep(1000); Console.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        j.TextReader(j.ReaderNoInhalerMarkoChapter3, ref j.lastPositionNoInhalerMarkoChapter3);
                        m.TextReader(m.ReaderNoInhalerMarkoChapter3, ref m.lastPositionNoInhalerMarkoChapter3);
                    }
                }
            }
            else if (GameChapter2.InhalerChoice == true)
            {
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
                j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                e.TextReader(e.ReaderChapter3, ref e.lastPositionChapter3);
                saveChoice = cc3.SaveChoice();

                if (saveChoice == 0)
                {
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                    b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
                    d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                    m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
                    b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);//
                    m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                    d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                    m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                    b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                    d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                    r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                    e.TextReader(e.ReaderChapter3, ref e.lastPositionChapter3); Thread.Sleep(1000); Console.Clear();
                }
                else if (saveChoice == 1)
                {
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    m.TextReader(m.ReaderBobChapter3, ref m.lastPositionBobChapter3);
                    d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                    b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    b.TextReaderDemon(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                    e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                    d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                    b.TextReaderDemon(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                    d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                }
                else if(saveChoice == -1)
                {
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                    b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                    r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                    d.TextReader(d.ReaderMarkoChapter3, ref d.lastPositionMarkoChapter3);
                    b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                    d.TextReader(d.ReaderMarkoChapter3, ref d.lastPositionMarkoChapter3);
                    b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                    b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                    m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                    m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                    r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                    m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                    e.TextReader(e.ReaderMarkoChapter3, ref e.lastPositionMarkoChapter3); Thread.Sleep(1000); Console.Clear();
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                    m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                    r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                    j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                }
            }
*/
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
            b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
            j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            j.TextReader(j.ReaderChapter3, ref j.lastPositionChapter3);
            d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
            e.TextReader(e.ReaderChapter3, ref e.lastPositionChapter3);
            saveChoice = cc3.SaveChoice();

            if (saveChoice == 0)
            {
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                b.TextReader(b.ReaderChapter3, ref b.lastPositionChapter3);
                b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);//
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                m.TextReader(m.ReaderChapter3, ref m.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                b.TextReaderDemon(b.ReaderChapter3, ref b.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                d.TextReader(d.ReaderChapter3, ref d.lastPositionChapter3);
                r.TextReader(r.ReaderChapter3, ref r.lastPositionChapter3);
                e.TextReader(e.ReaderChapter3, ref e.lastPositionChapter3); Thread.Sleep(1000); Console.Clear();
            }
            else if (saveChoice == 1)
            {
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                m.TextReader(m.ReaderBobChapter3, ref m.lastPositionBobChapter3);
                d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                b.TextReader(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                b.TextReaderDemon(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                j.TextReader(j.ReaderBobChapter3, ref j.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                r.TextReader(r.ReaderBobChapter3, ref r.lastPositionBobChapter3);
                e.TextReader(e.ReaderBobChapter3, ref e.lastPositionBobChapter3); Thread.Sleep(1000); Console.Clear();
                d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
                b.TextReaderDemon(b.ReaderBobChapter3, ref b.lastPositionBobChapter3);
                d.TextReader(d.ReaderBobChapter3, ref d.lastPositionBobChapter3);
            }
            else if (saveChoice == -1)
            {
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                d.TextReader(d.ReaderMarkoChapter3, ref d.lastPositionMarkoChapter3);
                b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                d.TextReader(d.ReaderMarkoChapter3, ref d.lastPositionMarkoChapter3);
                b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                b.TextReaderDemon(b.ReaderMarkoChapter3, ref b.lastPositionMarkoChapter3);
                m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                e.TextReader(e.ReaderMarkoChapter3, ref e.lastPositionMarkoChapter3); Thread.Sleep(1000); Console.Clear();
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                m.TextReader(m.ReaderMarkoChapter3, ref m.lastPositionMarkoChapter3);
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                r.TextReader(r.ReaderMarkoChapter3, ref r.lastPositionMarkoChapter3);
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
                j.TextReader(j.ReaderMarkoChapter3, ref j.lastPositionMarkoChapter3);
            }
        }
    }
}
