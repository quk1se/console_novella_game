using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novella1.Interface;

namespace novella1.Characters
{
    internal class Jeff : Person,Scenario
    {
        #region Variables
        private bool life = true;
        private const string filePathChapter1 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 1 (Plane)\\JeffTxt.txt";
        private const string filePathChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\JeffTxt.txt";
        private const string filePathChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\JeffTxt.txt";
        private const string filePathNoInhalerChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\JeffNoInhalerTxt.txt";
        private const string filePathNoInhalerChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\JeffNoInhalerTxt.txt";
        private const string filePathNoInhalerBobChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\JeffChoiceBobTxt.txt";
        private const string filePathNoInhalerMarkoChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\JeffChoiceMarkoTxt.txt";
        private const string filePathBobChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\JeffChoiceBobTxt.txt";
        private const string filePathMarkoChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\JeffChoiceMarkoTxt.txt";
        public long lastPositionChapter1 = 0;
        public long lastPositionChapter2 = 0;
        public long lastPositionChapter3 = 0;
        public long lastPositionChoiceChapter3 = 0;
        public long lastPositionNoInhalerChapter2 = 0; 
        public long lastPositionNoInhalerChapter3 = 0;
        public long lastPositionNoInhalerBobChapter3 = 0;
        public long lastPositionNoInhalerMarkoChapter3 = 0;
        public long lastPositionBobChapter3 = 0;
        public long lastPositionMarkoChapter3 = 0;
        private StreamReader readerChapter1 = new StreamReader(filePathChapter1);
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        private StreamReader readerChapter3 = new StreamReader(filePathChapter3);
        private StreamReader readerNoInhalerChapter2 = new StreamReader(filePathNoInhalerChapter2);
        private StreamReader readerNoInhalerChapter3 = new StreamReader(filePathNoInhalerChapter3);
        private StreamReader readerNoInhalerBobChapter3 = new StreamReader(filePathNoInhalerBobChapter3);
        private StreamReader readerNoInhalerMarkoChapter3 = new StreamReader(filePathNoInhalerMarkoChapter3);
        private StreamReader readerBobChapter3 = new StreamReader(filePathBobChapter3);
        private StreamReader readerMarkoChapter3 = new StreamReader(filePathMarkoChapter3);
        #endregion
        #region Properties
        public bool Life
        {
            set { life = value; }
            get { return life; }
        }
        public string FilePathChapter1
        {
            get { return filePathChapter1; }
        }
        public string FilePathChapter2
        {
            get { return filePathChapter2; }
        }
        public string FilePathNoInhalerChapter2
        {
            get { return filePathNoInhalerChapter2; }
        }
        public string FilePathNoInhalerBobChapter3
        {
            get { return filePathNoInhalerBobChapter3; }
        }
        public string FilePathNoInhalerMarkoChapter3
        {
            get { return filePathNoInhalerMarkoChapter3; }
        }
        public string FilePathBobChapter3
        {
            get { return filePathBobChapter3; }
        }
        public string FilePathMarkoChapter3
        {
            get { return filePathMarkoChapter3; }
        }
        public StreamReader ReaderChapter1
        {
            get { return readerChapter1; }
        }
        public StreamReader ReaderChapter2
        {
            get { return readerChapter2; }
        }
        public StreamReader ReaderChapter3
        {
            get { return readerChapter3; }
        }
        public StreamReader ReaderNoInhalerChapter2
        {
            get { return readerNoInhalerChapter2; }
        }
        public StreamReader ReaderNoInhalerChapter3
        {
            get { return readerNoInhalerChapter3; }
        }
        public StreamReader ReaderNoInhalerBobChapter3
        {
            get { return readerNoInhalerBobChapter3; }
        }
        public StreamReader ReaderNoInhalerMarkoChapter3
        {
            get { return readerNoInhalerMarkoChapter3; }
        }
        public StreamReader ReaderBobChapter3
        {
            get { return readerBobChapter3; }
        }
        public StreamReader ReaderMarkoChapter3
        {
            get { return readerMarkoChapter3; }
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
            #region Jeff drawing
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████");
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("█████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
