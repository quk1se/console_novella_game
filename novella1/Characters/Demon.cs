using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novella1.Interface;

namespace novella1.Characters
{
    internal class Demon : Person, Scenario
    {
        #region Variables
        private const string filePathChapter1 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 1 (Plane)\\DemonTxt.txt";
        private const string filePathChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\DemonTxt.txt";
        public long lastPositionChapter1 = 0;
        public long lastPositionChapter2 = 0;
        private StreamReader readerChapter1 = new StreamReader(filePathChapter1);
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        #endregion
        #region Properties
        public string FilePathChapter1
        {
            get { return filePathChapter1; }
        }
        public string FilePathChapter2
        {
            get { return filePathChapter2; }
        }
        public StreamReader ReaderChapter1
        {
            get { return readerChapter1; }
        }
        public StreamReader ReaderChapter2
        {
            get { return readerChapter2; }
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
            #region Demon drawing
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████");
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████");
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████");
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████████████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████");
            Console.Write("===============================================================================================================================================" +
                "==================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }
        public void ShowPersonWoman()
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
            Console.Write("██████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████");
            Console.Write("===============================================================================================================================================" +
                "==================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }
        public void ShowPersonPilot()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 209; j++)
                {
                    Console.Write("█");
                }
            }
            #region Marko drawing
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████");
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████");
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("███████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("██████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█████████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
            Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("█████████████████████████████████");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("███████████████████████████████████████");
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
        public void TextReaderChapter1(StreamReader reader, ref long lastPosition)
        { 
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
