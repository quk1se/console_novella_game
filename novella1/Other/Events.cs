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
        public long lastPositionChapter2 = 0;
        public long lastPositionChoiceChapter2 = 0;
        public long lastPositionNoInhalerChapter2 = 0;
        private StreamReader readerChapter2 = new StreamReader(filePathChapter2);
        private StreamReader readerChoiceChapter2 = new StreamReader(filePathChoiceChapter2);
        private StreamReader readerNoInhalerChapter2 = new StreamReader(filePathNoInhalerChapter2);
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
        public StreamReader ReaderChapter2
        {
            get { return readerChapter2; }
        }
        public StreamReader ReaderNoInhalerChapter2
        {
            get { return readerNoInhalerChapter2; }
        }
        public StreamReader ReaderChoiceChapter2
        {
            get { return readerChoiceChapter2; }
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
