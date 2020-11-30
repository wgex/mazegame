using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Console = Colorful.Console;
using System.Drawing;

namespace mazegame.Classes
{
    class Utilities
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput, [Out] StringBuilder lpCharacter, uint length, Coord bufferCoord, out uint lpNumberOfCharactersRead);

        public static char? karakteriAl(int x, int y)
        {
            IntPtr consoleHandle = GetStdHandle(-11);
            if (consoleHandle == IntPtr.Zero)
            {
                return null;
            }

            Coord position = new Coord
            {
                X = (short)x,
                Y = (short)y
            };
            StringBuilder result = new StringBuilder(1);
            uint read = 0;
            if (ReadConsoleOutputCharacter(consoleHandle, result, 1, position, out read))
            {
                return result[0];
            }
            else
            {
                return null;
            }
        }

        public struct Coord
        {
            public short X;
            public short Y;
        }

        public static void yaz(int x, int y, char harf)
        {
            Console.SetCursorPosition(x - 1, y);

            if (harf == '#')
            {
                Console.Write(harf, Color.RosyBrown);
            }
            else
            {
                if (harf == '0')
                {
                    Console.Write(harf, Color.Aquamarine);
                }
                else
                {
                    Console.Write(harf, Color.LightBlue);
                }
            }
        }
    }
}
