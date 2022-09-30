//namespace Home_Work_exercise_1_2
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.CursorVisible = false;
//            while (true)
//            {
//                int modeId = selectGameMode(new string[] { "Играть вдвоём.", "Игра с ботом." });
//                beginGame(modeId);
//            }
//        }
//        private static int selectGameMode(string[] modeTitles)
//        {
//            int modeId = 0;
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("\t\t*** КРЕСТИКИ-НОЛИКИ ***");
//                for (int i = 0; i < modeTitles.Length; i++)
//                {
//                    if (i == modeId)
//                    {
//                        Console.BackgroundColor = ConsoleColor.White;
//                        Console.ForegroundColor = ConsoleColor.Black;
//                    }
//                    Console.WriteLine(modeTitles[i]);
//                    Console.ResetColor();
//                }
//                var key = Console.ReadKey().Key;
//                if (key == ConsoleKey.Enter || key == ConsoleKey.Spacebar)
//                {
//                    return modeId;
//                }
//                else if (key == ConsoleKey.DownArrow) modeId++;
//                else if (key == ConsoleKey.UpArrow) modeId--;
//                modeId = clamp(modeId, 0, modeTitles.Length - 1);
//            }
//        }
//        private static void beginGame(int gameMode)
//        {
//            Field gameField = new Field();
//            gameField.Restart(beginFromX: true, withBot: gameMode == 1);
//            int x = 0;
//            int y = 0;
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("УПРАВЛЕНИЕ:\nArrows - переместиться\nSpace - сделать ход\nEsc - сброс\n\n");
//                Console.WriteLine("Ход для {0}:\n", gameField.TurnX ? "КРЕСТИКА" : "НОЛИКА");
//                for (int i = 0; i < 3; i++)
//                {
//                    for (int j = 0; j < 3; j++)
//                    {
//                        if (i == y && j == x)
//                        {
//                            Console.BackgroundColor = ConsoleColor.White;
//                            Console.ForegroundColor = ConsoleColor.Black;
//                        }
//                        Console.Write($" {gameField[i, j]} ");
//                        Console.ResetColor();
//                    }
//                    Console.WriteLine();
//                }
//                Field.State state = gameField.GetState;
//                if (state == Field.State.ZeroWins)
//                    Console.WriteLine("НОЛИКИ ПОБЕДИЛИ!!!");
//                else if (state == Field.State.CrossWins)
//                    Console.WriteLine("КРЕСТИКИ ПОБЕДИЛИ!!!");
//                else if (state == Field.State.Friedship)
//                    Console.WriteLine("НИЧЬЯ!");
//                // обработка клавиш
//                var key = Console.ReadKey(true).Key;
//                if (key == ConsoleKey.Spacebar)
//                {
//                    gameField.Turn(x, y);

//                    if (gameField.WithBot)
//                    {
//                        gameField.TurnBot();
//                    }
//                }
//                else if (key == ConsoleKey.LeftArrow) x--;
//                else if (key == ConsoleKey.RightArrow) x++;
//                else if (key == ConsoleKey.UpArrow) y--;
//                else if (key == ConsoleKey.DownArrow) y++;
//                else if (key == ConsoleKey.Escape)
//                {
//                    return;
//                }
//                x = clamp(x, 0, 2);
//                y = clamp(y, 0, 2);
//            }
//        }
//        private static int clamp(int value, int min, int max)
//        {
//            if (value < min) return min;
//            if (value > max) return max;
//            return value;
//        }
//    }
//    public class Field
//    {
//        public enum State
//        {
//            None, CrossWins, ZeroWins, Friedship
//        }
//        public State GetState => getFieldState();
//        public bool TurnX { get; private set; }
//        public bool WithBot { get; private set; }
//        private char[,] _field;
//        private const char X = 'X';
//        private const char O = 'O';
//        private const char EMPTY = '-';
//        private Random _rand = new Random();
//        public char this[int y, int x] => _field[y, x];
//        public void Restart(bool beginFromX = true, bool withBot = false)
//        {
//            if (_field == null)
//                _field = new char[3, 3];
//            for (int i = 0; i < 9; i++)
//                _field[i / 3, i % 3] = EMPTY;
//            TurnX = beginFromX;
//            WithBot = withBot;
//        }
//        public void Turn(int x, int y)
//        {
//            if (x < 0 || x > 2) return;
//            if (y < 0 || y > 2) return;
//            if (_field[y, x] != EMPTY) return;
//            if (GetState != State.None) return;
//            _field[y, x] = TurnX ? X : O;
//            TurnX = !TurnX;
//        }
//        public void TurnBot()
//        {
//            int cell = _rand.Next(9);
//            for (int i = 0; i < 9; i++)
//            {
//                int x = cell % 3;
//                int y = cell / 3;
//                if (_field[y, x] == EMPTY)
//                {
//                    Turn(x, y);
//                    break;
//                }
//                cell = ++cell % 9;
//            }
//        }
//        private State getFieldState()
//        {
//            int XXX = X * 3;
//            int OOO = O * 3;
//            for (int i = 0; i < 3; i++)
//            {
//                // строка
//                int resRow = _field[i, 0] + _field[i, 1] + _field[i, 2];
//                // колонка
//                int resCol = _field[0, i] + _field[1, i] + _field[2, i];
//                if (resRow == XXX || resCol == XXX) return State.CrossWins;
//                else if (resRow == OOO || resCol == OOO) return State.ZeroWins;
//            }
//            //диагонали
//            int d1 = _field[0, 0] + _field[1, 1] + _field[2, 2];
//            int d2 = _field[2, 0] + _field[1, 1] + _field[0, 2];
//            if (d1 == XXX || d2 == XXX) return State.CrossWins;
//            else if (d1 == OOO || d2 == OOO) return State.ZeroWins;
//            // нет победы, но остались пустые  места
//            for (int i = 0; i < 9; i++)
//                if (_field[i / 3, i % 3] == EMPTY) return State.None;
//            // нет победы и нет пустых мест
//            return State.Friedship;
//        }
//    }
//}





//namespace Home_Work_exercise_1
//{
//    class Program
//    {
//        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//        static int player = 1;
//        static int choice;
//        static int flag = 0;
//        static void Main(string[] args)
//        {


//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Игрок1 : X и Игрок2 : O");
//                Console.WriteLine("\n");
//                if (player % 2 == 0)
//                {
//                    Console.WriteLine("Ход игрока2: ");
//                }
//                else
//                {
//                    Console.WriteLine("Ход игрока1: ");
//                }
//                Console.WriteLine("\n");
//                Field();
//                choice = int.Parse(Console.ReadLine());
//                if (arr[choice] != 'X' && arr[choice] != 'O')
//                {
//                    if (player % 2 == 0)
//                    {
//                        arr[choice] = 'O';
//                        player++;
//                    }
//                    else
//                    {
//                        arr[choice] = 'X';
//                        player++;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Такой ход уже был, сделайте другой ход: ", choice, arr[choice]);
//                    Console.WriteLine("\n");
//                    Console.WriteLine("Ход уже был, поле щас обновится: ");
//                    Thread.Sleep(1000);
//                }
//                flag = CheckWin();
//            }
//            while (flag != 1 && flag != -1);
//            Console.Clear();
//            Field();
//            if (flag == 1)
//            {
//                Console.WriteLine("Победа: {0} ", (player % 2) + 1);
//            }
//            else
//            {
//                Console.WriteLine("Ничия: ");
//            }
//            Console.ReadLine();
//        }
//        private static void Field()
//        {
//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
//            Console.WriteLine("_____|_____|_____ ");
//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
//            Console.WriteLine("_____|_____|_____ ");
//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
//            Console.WriteLine("     |     |      ");
//        }
//        private static int CheckWin()
//        {
//            #region Horzontal Winning Condtion
//            if (arr[1] == arr[2] && arr[2] == arr[3])
//            {
//                return 1;
//            }
//            else if (arr[4] == arr[5] && arr[5] == arr[6])
//            {
//                return 1;
//            }
//            else if (arr[6] == arr[7] && arr[7] == arr[8])
//            {
//                return 1;
//            }
//            #endregion
//            #region vertical Winning Condtion
//            else if (arr[1] == arr[4] && arr[4] == arr[7])
//            {
//                return 1;
//            }
//            else if (arr[2] == arr[5] && arr[5] == arr[8])
//            {
//                return 1;
//            }
//            else if (arr[3] == arr[6] && arr[6] == arr[9])
//            {
//                return 1;
//            }
//            #endregion
//            #region Diagonal Winning Condition
//            else if (arr[1] == arr[5] && arr[5] == arr[9])
//            {
//                return 1;
//            }
//            else if (arr[3] == arr[5] && arr[5] == arr[7])
//            {
//                return 1;
//            }
//            #endregion
//            #region Checking For Draw
//            else if (arr[1] != '1' && arr[2] != '2' && arr[3]
//                != '3' && arr[4] != '4' && arr[5] != '5' && arr[6]
//                != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
//            {
//                return -1;
//            }
//            #endregion
//            else
//            {
//                return 0;
//            }
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberForum
{
    class Program
    {
        static void Main(string[] args)
        {
            string startText;
            //Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
            startText = Console.ReadLine();
            startText = Morse.ConverToMorse.TextToMorse(startText);

            //Console.WriteLine();
            //Console.WriteLine("Введите текст для перевода: ");
            //int morse = int.Parse(Console.ReadLine());
            int qtySymbols = int.Parse(Console.ReadLine());
            // какое-то слово (только буквы)
            string hello = "helloworld";

            // перевели слово в Морзе


            // перевели из Морзе в слово
            Console.WriteLine(FromMorse(morse));
        }
        // словарь Морзе-Буква
        public static Dictionary<string, string> MorseToAbc = new Dictionary<string, string>()
        {
            { ".-", "A"}, { "-...", "B"},{ "-.-.", "C"},{ "-..", "D"},
            { ".", "E"}, { "..-.", "F"}, { "--.", "G"}, { "....", "H"},
            { "..", "I"}, { ".---", "J"}, { "-.-", "K"}, { ".-..", "L"},
            { "--", "M"}, { "-.", "N"}, { "---", "O"}, { ".--.", "P"},
            { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
            { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"},
            { "-.--", "Y"},{ "--..", "Z"},
        };
        // словарь Буква-Морзе
        public static Dictionary<string, string> AbsToMorse = MorseToAbc.ToDictionary(k => k.Value, v => v.Key);
        // перевод текста в Морзе
        static string ToMorse(string input)
        {
            input = input.ToUpper();
            string[] encoded = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                encoded[i] = AbsToMorse[input[i].ToString()];
            }
            return string.Join(" ", encoded);
        }
        // перевод из Морзе в текст
        static string FromMorse(string input)
        {
            string[] morse = input.Split();
            string[] decoded = new string[morse.Length];
            for (int i = 0; i < morse.Length; i++)
            {
                decoded[i] = MorseToAbc[morse[i]];
            }
            return string.Concat(decoded);
        }
    }
}


//using System.Text;

//namespace Classwork16_09Task2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string startText;
//            Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
//            startText = Console.ReadLine();

//            startText = Morse.ConverToMorse.TextToMorse(startText);
//            Console.WriteLine("Текст в виде азбуки Морзе:\t{0}" + startText);
//        }
//    }
//}
//namespace Morse
//{
//    class ConverToMorse
//    {
//        public static string TextToMorse(string alphaText)
//        {
//            char[] chars = alphaText.ToLower().ToCharArray();
//            string[] MassiveMorse = new string[] { "*-", "-***", "*--", "--*", "-**", };
//            string[] MassiveAlphabet = new string[] { "а", "б", "в", "г", "д", };
//            string BetaText;
//            int count = 0;
//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < chars.Length; i++)
//            {
//                foreach (string str in MassiveAlphabet)
//                {
//                    if (chars[i] == str[0])
//                    {
//                        sb.Append(MassiveMorse[count]);
//                    }
//                    count++;
//                }
//                count = 0;
//            }
//            return BetaText = sb.ToString();
//        }
//        static string MorseToText()
//        {
//            return "";
//        }
//    }
//}

