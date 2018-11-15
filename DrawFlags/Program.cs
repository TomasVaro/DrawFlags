using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv ett land?");
                string flagga = Console.ReadLine().ToLower();
                Console.Clear();

                if (flagga == "sverige")
                {
                    DrawBackground(ConsoleColor.Blue, width: 40, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 4, width: 40, height: 2);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 14, y: 0, width: 4, height: 10);
                }
                else if (flagga == "finland")
                {
                    DrawBackground(ConsoleColor.White, width: 40, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 4, width: 40, height: 2);
                    DrawVerticalRectangle(ConsoleColor.Blue, x: 14, y: 0, width: 4, height: 10);
                }
                else if (flagga == "åhland")
                {
                    DrawBackground(ConsoleColor.Blue, width: 80, height: 20);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 7, width: 80, height: 6);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 26, y: 0, width: 12, height: 20);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 9, width: 80, height: 2);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 30, y: 0, width: 4, height: 20);
                }
                else if (flagga == "färöarna")
                {
                    DrawBackground(ConsoleColor.White, width: 80, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 7, width: 80, height: 5);
                    DrawVerticalRectangle(ConsoleColor.Blue, x: 26, y: 0, width: 10, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 8, width: 80, height: 3);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 28, y: 0, width: 6, height: 19);
                }
                else if (flagga == "island")
                {
                    DrawBackground(ConsoleColor.Blue, width: 80, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 6, width: 80, height: 7);
                    DrawVerticalRectangle(ConsoleColor.White, x: 26, y: 0, width: 14, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 8, width: 80, height: 3);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 30, y: 0, width: 6, height: 19);
                }
                else if (flagga == "norge")
                {
                    DrawBackground(ConsoleColor.Red, width: 80, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 6, width: 80, height: 7);
                    DrawVerticalRectangle(ConsoleColor.White, x: 26, y: 0, width: 14, height: 19);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 8, width: 80, height: 3);
                    DrawVerticalRectangle(ConsoleColor.DarkBlue, x: 30, y: 0, width: 6, height: 19);
                }
                else if (flagga == "skottland")
                {
                    DrawBackground(ConsoleColor.Blue, width: 52, height: 13);
                    Console.BackgroundColor = ConsoleColor.White;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.SetCursorPosition(i + i * 3, i);
                        Console.WriteLine("    ");
                        Console.SetCursorPosition(i + i * 3, 12 - i);
                        Console.WriteLine("    ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 13);
                }
                else if (flagga == "storbritannien")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 104, height: 26);
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 26; i++)
                    {
                        Console.SetCursorPosition(i + i * 3, i);
                        Console.WriteLine("    ");
                        Console.SetCursorPosition(i + i * 3, 25 - i);
                        Console.WriteLine("    ");
                    }
                    Console.BackgroundColor = ConsoleColor.White;
                    for (int i = 0; i < 25; i++)
                    {
                        Console.SetCursorPosition(i + i * 3, i + 1);
                        Console.WriteLine("    ");
                        Console.SetCursorPosition(i + i * 3, 24 - i);
                        Console.WriteLine("    ");
                        Console.SetCursorPosition(i + i * 3 + 4, i);
                        Console.WriteLine("    ");
                        Console.SetCursorPosition(i + i * 3 + 4, 25 - i);
                        Console.WriteLine("    ");
                    }
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 10, width: 104, height: 6);
                    DrawVerticalRectangle(ConsoleColor.White, x: 46, y: 0, width: 12, height: 26);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 11, width: 104, height: 4);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 48, y: 0, width: 8, height: 26);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 26);
                }
                else if (flagga == "albanien")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 10);
                }
                else if (flagga == "andorra")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "benin")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 18, y: 0, width: 24, height: 5);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 18, y: 5, width: 24, height: 5);
                }
                else if (flagga == "botswana")
                {
                    DrawBackground(ConsoleColor.Blue, width: 52, height: 15);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 5, width: 52, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Black, x: 0, y: 6, width: 52, height: 2);
                    Console.SetCursorPosition(0, 15);
                }
                else if (flagga == "gambia")
                {
                    DrawBackground(ConsoleColor.Red, width: 52, height: 15);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 5, width: 52, height: 5);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 6, width: 52, height: 3);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 10, width: 52, height: 5);
                    Console.SetCursorPosition(0, 15);
                }
                else if (flagga == "tonga")
                {
                    DrawBackground(ConsoleColor.DarkRed, width: 52, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 0, width: 20, height: 6);
                    DrawHorisontalRectangle(ConsoleColor.DarkRed, x: 5, y: 2, width: 10, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.DarkRed, x: 8, y: 1, width: 4, height: 4);
                    Console.SetCursorPosition(0, 12);
                }
                else if (flagga == "frankrike")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "danmark")
                {
                    DrawBackground(ConsoleColor.Red, width: 40, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 4, width: 40, height: 2);
                    DrawVerticalRectangle(ConsoleColor.White, x: 14, y: 0, width: 4, height: 10);
                }
                else if (flagga == "england")
                {
                    DrawBackground(ConsoleColor.White, width: 40, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 4, width: 40, height: 2);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 14, y: 0, width: 4, height: 10);
                }
                else if (flagga == "schweiz")
                {
                    DrawBackground(ConsoleColor.Red, width: 40, height: 18);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 6, y: 7, width: 27, height: 4);
                    DrawVerticalRectangle(ConsoleColor.White, x: 15, y: 3, width: 9, height: 12);
                    Console.SetCursorPosition(0, 18);
                }
                else if (flagga == "frankrike")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "barbados")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkBlue, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "afganistan")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkBlue, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "belgien")
                {
                    DrawBackground(ConsoleColor.Black, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "elfenbenskusten")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkGreen, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "guinea")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkGreen, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "guatemala")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Blue, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "irland")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "italien")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkRed, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "mali")
                {
                    DrawBackground(ConsoleColor.Green, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkRed, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "nigeria")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkGreen, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "peru")
                {
                    DrawBackground(ConsoleColor.DarkRed, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.White, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkRed, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "tjad")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 42, height: 10);
                    DrawVerticalRectangle(ConsoleColor.Yellow, x: 42 / 3, y: 0, width: 42 / 3, height: 10);
                    DrawVerticalRectangle(ConsoleColor.DarkRed, x: 43 * 2 / 3, y: 0, width: 42 / 3, height: 10);
                }
                else if (flagga == "armenien")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkYellow, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "österrike")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "bulgarien")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkRed, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "bolivia")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "katalonien")
                {
                    DrawBackground(ConsoleColor.Yellow, width: 60, height: 18);
                    for (int i = 0; i < 4; i++)
                    {
                        DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 2 + 4 * i, width: 60, height: 2);
                    }
                    Console.SetCursorPosition(0, 18);
                }
                else if (flagga == "colombia")
                {
                    DrawBackground(ConsoleColor.Yellow, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 6, width: 42, height: 3);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 9, width: 42, height: 3);
                }
                else if (flagga == "estland")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Black, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "egypten")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Black, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "spanien")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 3, width: 42, height: 6);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 9, width: 42, height: 3);
                }
                else if (flagga == "gabon")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "tyskland")
                {
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "ungern")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "indonesien")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "lichtenstein")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "litauen")
                {
                    DrawBackground(ConsoleColor.Yellow, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkRed, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "luxenburg")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "lettland")
                {
                    DrawBackground(ConsoleColor.DarkRed, width: 42, height: 10);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 4, width: 42, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.DarkRed, x: 0, y: 8, width: 42, height: 2);
                }
                else if (flagga == "monaco")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "mauritius")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 3, width: 42, height: 3);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 6, width: 42, height: 3);
                    DrawHorisontalRectangle(ConsoleColor.DarkGreen, x: 0, y: 9, width: 42, height: 3);
                }
                else if (flagga == "nicaragua")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "nederländerna")
                {
                    DrawBackground(ConsoleColor.DarkRed, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "polen")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "serbien")
                {
                    DrawBackground(ConsoleColor.Red, width: 50, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 12 / 2, width: 50, height: 6);
                }
                else if (flagga == "portugal")
                {
                    DrawBackground(ConsoleColor.DarkGreen, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 17, y: 0, width: 25, height: 12);
                }
                else if (flagga == "vatikanstaten")
                {
                    DrawBackground(ConsoleColor.Yellow, width: 42, height: 15);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 21, y: 0, width: 21, height: 15);
                }
                else if (flagga == "malta")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawVerticalRectangle(ConsoleColor.Red, x: 42 / 2, y: 0, width: 21, height: 12);
                }
                else if (flagga == "tjeckien")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 / 2, width: 42, height: 6);
                    for (int i = 0; i < 6; i++)
                    {
                        DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 0 + i, width: 1 + i * 3, height: 1);
                        DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 11 - i, width: 1 + i * 3, height: 1);
                    }
                    Console.SetCursorPosition(0, 12);
                }
                else if (flagga == "ryssland")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "slovenien")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "slovakien")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawVerticalRectangle(ConsoleColor.DarkRed, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "sierra leone")
                {
                    DrawBackground(ConsoleColor.Green, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "san marino")
                {
                    DrawBackground(ConsoleColor.White, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Blue, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "ukraina")
                {
                    DrawBackground(ConsoleColor.Blue, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.Yellow, x: 0, y: 12 / 2, width: 42, height: 6);
                }
                else if (flagga == "yemen")
                {
                    DrawBackground(ConsoleColor.Red, width: 42, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 12 / 3, width: 42, height: 4);
                    DrawHorisontalRectangle(ConsoleColor.Black, x: 0, y: 12 * 2 / 3, width: 42, height: 4);
                }
                else if (flagga == "montenegro")
                {
                    DrawBackground(ConsoleColor.Red, width: 55, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkYellow, x: 0, y: 0, width: 55, height: 1);
                    DrawVerticalRectangle(ConsoleColor.DarkYellow, x: 0, y: 0, width: 2, height: 12);
                    DrawVerticalRectangle(ConsoleColor.DarkYellow, x: 53, y: 0, width: 2, height: 12);
                    DrawHorisontalRectangle(ConsoleColor.DarkYellow, x: 0, y: 11, width: 55, height: 1);
                }
                else if (flagga == "georgien")
                {
                    DrawBackground(ConsoleColor.White, width: 80, height: 20); //ritar bakgrunden

                    DrawHorisontalRectangle(ConsoleColor.Red, x: 18, y: 2, width: 2, height: 3);  //ritar lilla korset uppe till vä
                    DrawVerticalRectangle(ConsoleColor.Red, x: 16, y: 3, width: 6, height: 1);

                    DrawHorisontalRectangle(ConsoleColor.Red, x: 18, y: 14, width: 2, height: 3); //ritar lilla korset uppe till hö
                    DrawVerticalRectangle(ConsoleColor.Red, x: 16, y: 15, width: 6, height: 1);

                    DrawHorisontalRectangle(ConsoleColor.Red, x: 60, y: 2, width: 2, height: 3);  //ritar lilla korset nere till vä
                    DrawVerticalRectangle(ConsoleColor.Red, x: 58, y: 3, width: 6, height: 1);

                    DrawHorisontalRectangle(ConsoleColor.Red, x: 60, y: 14, width: 2, height: 3); //ritar lilla korset nere till vä
                    DrawVerticalRectangle(ConsoleColor.Red, x: 58, y: 15, width: 6, height: 1);

                    DrawHorisontalRectangle(ConsoleColor.Red, x: 0, y: 8, width: 80, height: 4);  //ritar stora korset
                    DrawVerticalRectangle(ConsoleColor.Red, x: 36, y: 0, width: 8, height: 20);
                }
                else if (flagga == "grekland")
                {
                    DrawBackground(ConsoleColor.Blue, width: 60, height: 18); //ritar bakgrunden           
                    DrawHorisontalRectangle(ConsoleColor.White, x: 20, y: 2, width: 40, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 20, y: 6, width: 40, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 10, width: 60, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 14, width: 60, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 4, width: 20, height: 2);
                    DrawVerticalRectangle(ConsoleColor.White, x: 8, y: 0, width: 4, height: 10);
                    Console.SetCursorPosition(0, 18);
                }
                else if (flagga == "honduras")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 43, height: 9);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 3, width: 43, height: 3);

                    for (int i = 0; i < 3; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(15, 3);
                        Console.WriteLine("*           *");
                        Console.SetCursorPosition(21, 4);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(15, 5);
                        Console.WriteLine("*           *");                        
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 12);
                }
                else if (flagga == "usa")
                {
                    DrawBackground(ConsoleColor.DarkRed, width: 109, height: 26);

                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 2, width: 109, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 6, width: 109, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 10, width: 109, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.DarkBlue, x: 0, y: 0, width: 44, height: 14);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 14, width: 109, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 18, width: 109, height: 2);
                    DrawHorisontalRectangle(ConsoleColor.White, x: 0, y: 22, width: 109, height: 2);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(3, 1 + 2 * i);
                        Console.WriteLine("*      *      *      *      *      *");
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(2, 2 + 2 * i);
                        Console.WriteLine("    *      *      *      *      *");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 26);
                }
                else if (flagga == "eu")
                {
                    DrawBackground(ConsoleColor.DarkBlue, width: 41, height: 11);
                    for (int i = 0; i < 7; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(20, 2);
                        Console.WriteLine("*");
                        Console.SetCursorPosition(17, 3);
                        Console.WriteLine("*     *");
                        Console.SetCursorPosition(15, 4);
                        Console.WriteLine("*         *");
                        Console.SetCursorPosition(14, 5);
                        Console.WriteLine("*           *");
                        Console.SetCursorPosition(15, 6);
                        Console.WriteLine("*         *");
                        Console.SetCursorPosition(17, 7);
                        Console.WriteLine("*     *");
                        Console.SetCursorPosition(20, 8);
                        Console.WriteLine("*");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0, 11);
                }
                else
                {
                    Console.WriteLine("Tyvärr! Flaggan för det landet kan jag inte! :( ");
                }
            }
        }
        static void DrawBackground(ConsoleColor backgroundColor, int width, int height) //anropar metoden DrawLine för att ritar ut bakgrunden
        {
            int x = 0;
            int y = 0;
            DrawLine(backgroundColor, x, y, width, height);
        }

        static void DrawHorisontalRectangle(ConsoleColor rowColor, int x, int y, int width, int height) //anropar metoden DrawLine för att ritar en rektangel vertikalt med bredd och höjd width/height
        {
            DrawLine(rowColor, x, y, width, height);
        }

        static void DrawVerticalRectangle(ConsoleColor rowColor, int x, int y, int width, int height) //anropar metoden DrawLine för att ritar en rektangel med bredd och höjd width/height
        {
            DrawLine(rowColor, x, y, width, height);
        }


        static void DrawLine(ConsoleColor rowColor, int x, int y, int width, int height)
        {
            Console.BackgroundColor = rowColor;
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
