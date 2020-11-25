using System;

namespace CAM_NOG_BUM
{
    class Program
    {
        /*
      сделать нечю
      */
        const byte rock = 0;
        const byte scissors = 1;
        const byte paper = 2;
        const byte spock = 3;
        const byte lizard = 4;
        static void Main(string[] args)
        {
            /*\
            1)бот делаєт рандом викидивает
            2) пользователь викидивает 
            3)хто виграл раунд
            4)поверка на вийграш до 3 побед
             */
            /*
             длаем переменнине
             */
            #region peremennie
            Random R = new Random();
            byte bot_cul;
            string[] variant = { "rock", "scissors", "paper", "spock", "lizard" };
            byte PLAYER_CUL;
            byte round = 0;
            byte win_bot = 0;
            byte win_Player = 0;
            string hod;
            #endregion

            while (true)
            {
                #region zapis xoda
                bot_cul = (byte)R.Next(0, 5);
                //0 kum 1 nog 2 bum 3 spock 4 lizard
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Вибери свой обєкт: r(rock), sc(scissors), p(paper), sp(spock), l(lizard): ");
                    //камнем забити
                    //ножницами зарізати
                    //задушити бумагою
                    hod = Console.ReadLine();
                    Console.WriteLine();
                    //конвертуемо в число
                    if (hod == "r")
                    {
                        PLAYER_CUL = rock;
                        break;
                    }
                    else if (hod == "sc")
                    {
                        PLAYER_CUL = scissors;
                        break;
                    }
                    else if (hod == "p")
                    {
                        PLAYER_CUL = paper;
                        break;
                    }
                    else if (hod == "sp")
                    {
                        PLAYER_CUL = spock;
                        break;
                    }
                    else if (hod == "l")
                    {
                        PLAYER_CUL = lizard;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                    }
                }
                #endregion
                #region hto pobedil
                if (PLAYER_CUL == bot_cul)
                {
                    //drow
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    round++;
                    Console.WriteLine($"Раунд{round} был закончн ничьёй, бота и игрока совпали выборы");

                }
                else if ((bot_cul == rock && (PLAYER_CUL == scissors || PLAYER_CUL == lizard))
                    || (bot_cul == paper && (PLAYER_CUL == rock || PLAYER_CUL == spock))
                    || (bot_cul == scissors && (PLAYER_CUL == paper || PLAYER_CUL == lizard))
                    || (bot_cul == lizard && (PLAYER_CUL == spock || PLAYER_CUL == paper))
                    || (bot_cul == spock && (PLAYER_CUL == rock || PLAYER_CUL == scissors)))
                {
                    //bot win round
                    round++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Раунд{round} был закончн победой бота, бот ходил {variant[bot_cul]}, а игрок {variant[PLAYER_CUL]}");

                    win_bot++;
                }
                else if ((PLAYER_CUL == rock && (bot_cul == scissors || bot_cul == lizard))
                    || (PLAYER_CUL == paper && (bot_cul == rock || bot_cul == spock))
                    || (PLAYER_CUL == scissors && (bot_cul == paper || bot_cul == lizard))
                    || (PLAYER_CUL == lizard && (bot_cul == spock || bot_cul == paper))
                    || (PLAYER_CUL == spock && (bot_cul == rock || bot_cul == scissors)))
                {
                    //player win round
                    round++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Раунд{round} был закончн победой игрока, бот ходил {variant[bot_cul]}, а игрок {variant[PLAYER_CUL]}");
                    win_Player++;
                }
                else
                {
                    //если ошибка
                    Console.WriteLine("erorr");
                }
                #endregion
                #region esli pobeda
                if (win_Player + 3 == win_bot)
                {
                    //победа бота
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Игрра била закончена на раунде под номером {round} с щотом {win_bot}/{win_Player} в пользу бота");
                    break;
                }
                else if (win_Player - 3 == win_bot)
                {
                    //победа игрока
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Игрра била закончена на раунде под номером {round} с щотом {win_bot}/{win_Player} в пользу игрока");
                    break;
                }
                #endregion
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
