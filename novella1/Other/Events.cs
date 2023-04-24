using novella1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novella1.Other
{
    internal class Events : Scenario
    {
        private const string filePathChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\EventsTxt.txt";
        private const string filePathChoiceChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\Choices Chapter2.txt";
        private const string filePathNoInhalerChapter2 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 2 (Survive)\\EventsNoInhalerTxt.txt";
        private const string filePathNoInhalerChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\EventsNoInhalerTxt.txt";
        private const string filePathNoInhalerChoiceChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\Choices Chapter3.txt";
        private const string filePathNoInhalerBobChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\EventsChoiceBobTxt.txt";
        private const string filePathNoInhalerMarkoChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)NoInhaler\\EventsChoiceMarkoTxt.txt";
        private const string filePathChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\EventsTxt.txt";
        private const string filePathBobChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\EventsChoiceBobTxt.txt";
        private const string filePathMarkoChapter3 = "D:\\itstep\\С#\\novella1\\novella1\\Chapter 3 (Escape)\\EventsChoiceMarkoTxt.txt";
        public long lastPositionChapter2 = 0;
        public long lastPositionChoiceChapter2 = 0;
        public long lastPositionChoiceChapter3 = 0;
        public long lastPositionNoInhalerChapter2 = 0;
        public long lastPositionNoInhalerChapter3 = 0;
        public long lastPositionNoInhalerBobChapter3 = 0;
        public long lastPositionNoInhalerMarkoChapter3 = 0;
        public long lastPositionChapter3 = 0;
        public long lastPositionBobChapter3 = 0;
        public long lastPositionMarkoChapter3 = 0;
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        private StreamReader readerChoiceChapter2 = new StreamReader(filePathChoiceChapter2);
        private StreamReader readerChoiceChapter3 = new StreamReader(filePathNoInhalerChoiceChapter3);
        private StreamReader readerNoInhalerChapter2 = new StreamReader(filePathNoInhalerChapter2);
        private StreamReader readerNoInhalerChapter3 = new StreamReader(filePathNoInhalerChapter3);
        private StreamReader readerNoInhalerBobChapter3 = new StreamReader(filePathNoInhalerBobChapter3);
        private StreamReader readerNoInhalerMarkoChapter3 = new StreamReader(filePathNoInhalerMarkoChapter3);
        private StreamReader readerChapter3 = new StreamReader(filePathChapter3);
        private StreamReader readerBobChapter3 = new StreamReader(filePathBobChapter3);
        private StreamReader readerMarkoChapter3 = new StreamReader(filePathMarkoChapter3);
        public string FilePathChapter2
        {
            get { return filePathChapter2; }
        }
        public string FilePathChoiceChapter2
        {
            get { return filePathChoiceChapter2; }
        }
        public string FilePathNoInhalerChoiceChapter3
        {
            get { return filePathNoInhalerChoiceChapter3; }
        }
        public string FilePathNoInhalerChapter2
        {
            get { return filePathNoInhalerChapter2; }
        }
        public string FilePathNoInhalerChapter3
        {
            get { return filePathNoInhalerChapter3; }
        }
        public string FilePathNoInhalerBobChapter3
        {
            get { return filePathNoInhalerBobChapter3; }
        }
        public string FilePathNoInhalerMarkoChapter3
        {
            get { return filePathNoInhalerMarkoChapter3; }
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
        public StreamReader ReaderChapter2
        {
            get { return readerChapter2; }
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
        public StreamReader ReaderChoiceChapter2
        {
            get { return readerChoiceChapter2; }
        }
        public StreamReader ReaderChoiceChapter3
        {
            get { return readerChoiceChapter3; }
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
        public void TextReader(StreamReader reader, ref long lastPosition)
        {
            reader.BaseStream.Seek(lastPosition, SeekOrigin.Begin);
            string line = reader.ReadLine();
            lastPosition = reader.BaseStream.Position;
            foreach (char c in line.ToCharArray())
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
        public void WaitKeyPress()
        {
            while ((Console.ReadKey(true)).Key != ConsoleKey.Spacebar) { }
        }
    }
}
