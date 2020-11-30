using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using mazegame.Classes;
using System.Windows.Forms;
using Console = Colorful.Console;
using System.Diagnostics;
using System.IO;

namespace mazegame
{
    class Stage1
    {
        public static int topindex = 0;
        public static int leftindex = 0;

        static void Main(string[] args)
        {
            Console.SetWindowSize(20, 12);

            stage1();

            Console.SetCursorPosition(0, 0);

            Console.CursorVisible = false;

            string character = "@";

            ConsoleKeyInfo keyinfo;

            do
            {
                Console.Write(character + "\b", Color.Azure);
                keyinfo = Console.ReadKey();
                Console.Write("\b");

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (Console.CursorTop > 0 && Utilities.karakteriAl(Console.CursorLeft, Console.CursorTop - 1) != '#')
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (Console.CursorTop < Console.WindowTop + Console.WindowHeight - 1 && Utilities.karakteriAl(Console.CursorLeft, Console.CursorTop + 1) != '#')
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                    }
                }

                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    if (Console.CursorLeft > 0 && Utilities.karakteriAl(Console.CursorLeft - 1, Console.CursorTop) != '#')
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }

                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    if (Console.CursorLeft < Console.WindowLeft + Console.WindowWidth - 2 && Utilities.karakteriAl(Console.CursorLeft + 1, Console.CursorTop) != '#')
                    {
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                    }
                }

                
                if (keyinfo.Key == ConsoleKey.X)
                {
                    if (Console.CursorLeft < Console.WindowLeft + Console.WindowWidth - 2)
                    {
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        Console.Write("#", Color.YellowGreen);
                        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                    }
                }

                //MessageBox.Show(Utilities.karakteriAl(leftindex + 22, topindex + 1).ToString());
                //MessageBox.Show(Utilities.karakteriAl(leftindex + 22, topindex + 2).ToString());

                if (bittimi())
                {
                    break;
                }
            }
            while (keyinfo.Key != ConsoleKey.Escape);
            if (bittimi())
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("OYUNU KAZANDIN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", Color.Turquoise);
                Console.WriteLine("Çıkmak için enter'a bas...", Color.Aqua);
                Console.ReadLine();
                Application.Exit();
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Oyun Bitti XD, Kaybettin!", Color.Red);
                Console.WriteLine("Çıkmak için ENTER'a bas...", Color.Lime);
                Console.ReadLine();
                Application.Exit();
            }
        }

        public static void stage1()
        {
            Utilities.yaz(leftindex + 8, topindex + 0, '#');
            Utilities.yaz(leftindex + 8, topindex + 1, '#');
            Utilities.yaz(leftindex + 8, topindex + 2, '#');
            Utilities.yaz(leftindex + 8, topindex + 3, '#');
            Utilities.yaz(leftindex + 8, topindex + 4, '#');
            Utilities.yaz(leftindex + 8, topindex + 7, '#');
            Utilities.yaz(leftindex + 8, topindex + 8, '#');
            Utilities.yaz(leftindex + 8, topindex + 9, '#');
            Utilities.yaz(leftindex + 8, topindex + 10, '#');
            Utilities.yaz(leftindex + 8, topindex + 11, '#');
            Utilities.yaz(leftindex + 9, topindex + 8, '#');
            Utilities.yaz(leftindex + 9, topindex + 11, '#');
            Utilities.yaz(leftindex + 10, topindex + 1, '#');
            Utilities.yaz(leftindex + 10, topindex + 2, '#');
            Utilities.yaz(leftindex + 10, topindex + 3, '#');
            Utilities.yaz(leftindex + 10, topindex + 4, '#');
            Utilities.yaz(leftindex + 10, topindex + 5, '#');
            Utilities.yaz(leftindex + 10, topindex + 6, '#');
            Utilities.yaz(leftindex + 10, topindex + 8, '#');
            Utilities.yaz(leftindex + 10, topindex + 9, '#');
            Utilities.yaz(leftindex + 10, topindex + 11, '#');
            Utilities.yaz(leftindex + 11, topindex + 1, '#');
            Utilities.yaz(leftindex + 11, topindex + 5, '#');
            Utilities.yaz(leftindex + 11, topindex + 9, '#');
            Utilities.yaz(leftindex + 11, topindex + 11, '#');
            Utilities.yaz(leftindex + 12, topindex + 1, '#');
            Utilities.yaz(leftindex + 12, topindex + 3, '#');
            Utilities.yaz(leftindex + 12, topindex + 7, '#');
            Utilities.yaz(leftindex + 12, topindex + 8, '#');
            Utilities.yaz(leftindex + 12, topindex + 9, '#');
            Utilities.yaz(leftindex + 12, topindex + 11, '#');
            Utilities.yaz(leftindex + 13, topindex + 1, '#');
            Utilities.yaz(leftindex + 13, topindex + 2, '#');
            Utilities.yaz(leftindex + 13, topindex + 3, '#');
            Utilities.yaz(leftindex + 13, topindex + 7, '#');
            Utilities.yaz(leftindex + 13, topindex + 11, '#');
            Utilities.yaz(leftindex + 14, topindex + 5, '#');
            Utilities.yaz(leftindex + 14, topindex + 7, '#');
            Utilities.yaz(leftindex + 14, topindex + 9, '#');
            Utilities.yaz(leftindex + 14, topindex + 10, '#');
            Utilities.yaz(leftindex + 14, topindex + 11, '#');
            Utilities.yaz(leftindex + 15, topindex + 2, '#');
            Utilities.yaz(leftindex + 15, topindex + 3, '#');
            Utilities.yaz(leftindex + 15, topindex + 4, '#');
            Utilities.yaz(leftindex + 15, topindex + 5, '#');
            Utilities.yaz(leftindex + 15, topindex + 7, '#');
            Utilities.yaz(leftindex + 15, topindex + 9, '#');
            Utilities.yaz(leftindex + 15, topindex + 11, '#');
            Utilities.yaz(leftindex + 16, topindex + 5, '#');
            Utilities.yaz(leftindex + 16, topindex + 9, '#');
            Utilities.yaz(leftindex + 16, topindex + 11, '#');
            Utilities.yaz(leftindex + 17, topindex + 0, '#');
            Utilities.yaz(leftindex + 17, topindex + 1, '#');
            Utilities.yaz(leftindex + 17, topindex + 3, '#');
            Utilities.yaz(leftindex + 17, topindex + 4, '#');
            Utilities.yaz(leftindex + 17, topindex + 5, '#');
            Utilities.yaz(leftindex + 17, topindex + 6, '#');
            Utilities.yaz(leftindex + 17, topindex + 8, '#');
            Utilities.yaz(leftindex + 17, topindex + 9, '#');
            Utilities.yaz(leftindex + 17, topindex + 11, '#');
            Utilities.yaz(leftindex + 18, topindex + 6, '#');
            Utilities.yaz(leftindex + 18, topindex + 8, '#');
            Utilities.yaz(leftindex + 18, topindex + 9, '#');
            Utilities.yaz(leftindex + 18, topindex + 11, '#');
            Utilities.yaz(leftindex + 19, topindex + 0, '#');
            Utilities.yaz(leftindex + 19, topindex + 1, '#');
            Utilities.yaz(leftindex + 19, topindex + 2, '#');
            Utilities.yaz(leftindex + 19, topindex + 3, '#');
            Utilities.yaz(leftindex + 19, topindex + 4, '#');
            Utilities.yaz(leftindex + 19, topindex + 5, '#');
            Utilities.yaz(leftindex + 19, topindex + 6, '#');
            Utilities.yaz(leftindex + 19, topindex + 8, '#');
            Utilities.yaz(leftindex + 19, topindex + 9, '#');
            Utilities.yaz(leftindex + 19, topindex + 11, '#');
            Utilities.yaz(leftindex + 20, topindex + 0, '#');
            Utilities.yaz(leftindex + 20, topindex + 11, '#');
            Utilities.yaz(leftindex + 21, topindex + 0, '#');
            Utilities.yaz(leftindex + 21, topindex + 3, '#');
            Utilities.yaz(leftindex + 21, topindex + 4, '#');
            Utilities.yaz(leftindex + 21, topindex + 5, '#');
            Utilities.yaz(leftindex + 21, topindex + 6, '#');
            Utilities.yaz(leftindex + 21, topindex + 7, '#');
            Utilities.yaz(leftindex + 21, topindex + 8, '#');
            Utilities.yaz(leftindex + 21, topindex + 9, '#');
            Utilities.yaz(leftindex + 21, topindex + 10, '#');
            Utilities.yaz(leftindex + 21, topindex + 11, '#');
            Utilities.yaz(leftindex + 22, topindex + 0, '#');
            Utilities.yaz(leftindex + 22, topindex + 3, '#');
            Utilities.yaz(leftindex + 23, topindex + 0, '#');
            Utilities.yaz(leftindex + 23, topindex + 1, '0');
            Utilities.yaz(leftindex + 23, topindex + 2, '0');
            Utilities.yaz(leftindex + 23, topindex + 3, '#');
            Utilities.yaz(leftindex + 24, topindex + 0, '#');
            Utilities.yaz(leftindex + 24, topindex + 1, '#');
            Utilities.yaz(leftindex + 24, topindex + 2, '#');
            Utilities.yaz(leftindex + 24, topindex + 3, '#');
            
        }

        public static bool bittimi()
        {
            if (Utilities.karakteriAl(leftindex + 22, topindex + 1) != '0' && Utilities.karakteriAl(leftindex + 22, topindex + 2) != '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
