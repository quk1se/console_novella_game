﻿using novella1.Characters;
using novella1.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novella1.Choices
{
    internal class ChoicesChapter2
    {
        public bool InhalerChoice()
        {
            List<ConsoleKey> allowedKeys = new List<ConsoleKey> { ConsoleKey.Y, ConsoleKey.N };
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            do
            {
                keyInfo = Console.ReadKey(true);
            } while (!allowedKeys.Contains(keyInfo.Key));

            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.Clear();
                return true;
            }
            else if (keyInfo.Key == ConsoleKey.N || keyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                return false;
            }
            Console.Clear();
            return false;
        }
    }
}
