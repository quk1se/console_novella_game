using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novella1.Interface;

namespace novella1.Characters
{
    internal class Bob : Person, Scenario
    {
        #region Variables
        private bool life = true;
        private const string filePathChapter1 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 1 (Plane)\\BobTxt.txt";
        private const string filePathChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\BobTxt.txt";
        private const string filePathChoiceChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\BobChoiceTxt.txt";
        private const string filePathNoInhalerChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\BobNoInhalerTxt.txt";
        public long lastPositionChapter1 = 0;
        public long lastPositionChapter2 = 0;
        public long lastPositionChoiceChapter2 = 0;
        public long lastPositionNoInhalerChapter2 = 0;
        private StreamReader readerChapter1 = new StreamReader(filePathChapter1);
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        private StreamReader readerChoiceChapter2 = new StreamReader(filePathChoiceChapter2);
        private StreamReader readerNoInhalerChapter2 = new StreamReader(filePathNoInhalerChapter2);
        #endregion
        #region Properties
        public bool Life
        {
            set { life = value; }
            get { return life;}
        }
        public string FilePathChapter1
        {
            get { return filePathChapter1; }
        }
        public string FilePathChapter2
        {
            get { return filePathChapter2; }
        }
        public string FilePathChoiceChapter2
        {
            get { return filePathChoiceChapter2; }
        }
        public string FilePathNoInhalerChapter2
        {
            get { return filePathNoInhalerChapter2; }
        }
        public StreamReader ReaderChapter1
        {
            get { return readerChapter1; }
        }
        public StreamReader ReaderChapter2
        {
            get { return readerChapter2; }
        }
        public StreamReader ReaderChoiceChapter2
        {
            get { return readerChoiceChapter2; }
        }
        public StreamReader ReaderNoInhalerChapter2
        {
            get { return readerNoInhalerChapter2; }
        }
        #endregion

        public void ShowPerson()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 209; j++)
                {
                    Console.Write("█");
                }
            }
            #region Bob drawing
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████");
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("███████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;//
            Console.Write("██████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("===============================================================================================================================================" +
                "==================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }
        public void TextReader(StreamReader reader,ref long lastPosition)
        {
            ShowPerson();
            reader.BaseStream.Seek(lastPosition, SeekOrigin.Begin);
            string line = reader.ReadLine();
            lastPosition = reader.BaseStream.Position;
            foreach (char c in line.ToCharArray())
            {
                Console.Write(c);
                //Thread.Sleep(30);
            }
            Console.WriteLine();
            WaitKeyPress();
            Console.Clear();
        }
        public void WaitKeyPress()
        {
            while ((Console.ReadKey(true)).Key != ConsoleKey.Spacebar) { }
        }
    }
}
