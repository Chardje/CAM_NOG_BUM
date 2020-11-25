using System;

namespace CAM_NOG_BUM
{
    class Program
    {
        const byte rock = 0;
        const byte gun = 1;
        const byte lighting = 2;
        const byte devil = 3;
        const byte dragon = 4;
        const byte water = 5;
        const byte air = 6;
        const byte paper = 7;
        const byte sponge = 8;
        const byte wolf = 9;
        const byte tree = 10;
        const byte human = 11;
        const byte snake = 12;
        const byte scissors = 13;
        const byte fire = 14;
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
            string[] variant = { "rock", "gun", "lighting", "devil", "dragon", "water", "air", "paper", "sponge", "wolf", "tree", "human", "lighting", "snake", "scissors", "fire" };
            byte PLAYER_CUL;
            byte round = 0;
            byte win_bot = 0;
            byte win_Player = 0;
            string hod;
            #endregion

            while (true)
            {
                #region zapis xoda
                bot_cul = (byte)R.Next(0, 15);
                //0 kum 1 nog 2 bum 3 spock 4 lizard
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Вибери свой обєкт: r(rock), g(gun), l(lighting), de(devil), dr(dragon), wa(water), a(air), p(paper), sp(sponge), wo(wolf), t(tree), h(human), sn(snake), sc(scissors),f(fire) : ");
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
                    else if (hod == "g")
                    {
                        PLAYER_CUL = gun;
                        break;
                    }
                    else if (hod == "l")
                    {
                        PLAYER_CUL = lighting;
                        break;
                    }
                    else if (hod == "de")
                    {
                        PLAYER_CUL = devil;
                        break;
                    }
                    else if (hod == "dr")
                    {
                        PLAYER_CUL = dragon;
                        break;
                    }
                    else if (hod == "wa")
                    {
                        PLAYER_CUL = water;
                        break;
                    }
                    else if (hod == "a")
                    {
                        PLAYER_CUL = air;
                        break;
                    }
                    else if (hod == "p")
                    {
                        PLAYER_CUL = paper;
                        break;
                    }
                    else if (hod == "sp")
                    {
                        PLAYER_CUL = sponge;
                        break;
                    }
                    else if (hod == "wo")
                    {
                        PLAYER_CUL = wolf;
                        break;
                    }
                    else if (hod == "t")
                    {
                        PLAYER_CUL = tree;
                        break;
                    }
                    else if (hod == "h")
                    {
                        PLAYER_CUL = human;
                        break;
                    }
                    else if (hod == "sn")
                    {
                        PLAYER_CUL = snake;
                        break;
                    }
                    else if (hod == "sc")
                    {
                        PLAYER_CUL = scissors;
                        break;
                    }
                    else if (hod == "f")
                    {
                        PLAYER_CUL = fire;
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
                    Console.WriteLine($"Раунд {round} был закончн ничьёй, бота и игрока совпали выборы");

                }
                else if (PLAYER_CUL>=bot_cul-7|| PLAYER_CUL >= bot_cul -7+15)
                {
                    //bot win round
                    round++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Раунд {round} был закончн победой бота, бот ходил {variant[bot_cul]}, а игрок {variant[PLAYER_CUL]}");

                    win_bot++;
                }
                else if (bot_cul >= PLAYER_CUL - 7 || bot_cul >= PLAYER_CUL - 7 + 15)
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
