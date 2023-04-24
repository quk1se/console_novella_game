using novella1.Characters;
using novella1.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novella1.Choices
{
    internal class ChoicesChapter3
    {
        public int SaveChoice()
        {
            List<ConsoleKey> allowedKeys = new List<ConsoleKey> { ConsoleKey.Y, ConsoleKey.N, ConsoleKey.S };
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            do
            {
                keyInfo = Console.ReadKey(true);
            } while (!allowedKeys.Contains(keyInfo.Key));

            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.Clear();
                return 1;
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                Console.Clear();
                return -1;
            }
            else if (keyInfo.Key == ConsoleKey.S)
            {
                Console.Clear();
                return 0;
            }
            Console.Clear();
            return 0;
        }
    }
}
