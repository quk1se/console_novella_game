using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novella1.Interface;

namespace novella1.Characters
{
    internal class Rose : Person,Scenario
    {
        #region Variables
        private bool life = true;
        private const string filePathChapter1 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 1 (Plane)\\RoseTxt.txt";
        private const string filePathChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\RoseTxt.txt";
        private const string filePathChoiceChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\RoseChoiceTxt.txt";
        private const string filePathChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\RoseTxt.txt";
        private const string filePathBobChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\RoseChoiceBobTxt.txt";
        private const string filePathMarkoChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\RoseChoiceMarkoTxt.txt";
        public long lastPositionChapter1 = 0;
        public long lastPositionChapter2 = 0;
        public long lastPositionChoiceChapter2 = 0;
        public long lastPositionChapter3 = 0;
        public long lastPositionBobChapter3 = 0;
        public long lastPositionMarkoChapter3 = 0;
        private StreamReader readerChapter1 = new StreamReader(filePathChapter1);
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        private StreamReader readerChoiceChapter2 = new StreamReader(filePathChoiceChapter2);
        private StreamReader readerChapter3 = new StreamReader(filePathChapter3);
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
        public string FilePathChoiceChapter2
        {
            get { return filePathChoiceChapter2; }
        }
        public string FilePathChapter3
        {
            get { return filePathChapter3; }
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
        public StreamReader ReaderChoiceChapter2
        {
            get { return readerChoiceChapter2; }
        }
        public StreamReader ReaderChapter3
        {
            get { return readerChapter3; }
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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████");
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("██████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████");
            Console.Write("===============================================================================================================================================" +
                "==================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }
        public void TextReader(StreamReader reader, ref long lastPosition)
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
