using System;

namespace CAM_NOG_BUM
{
    class Program
    {
        
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
                    Console.Write("Вибери свой обєкт: ");
                    for( byte i=0;i<variant.Length;i++)
                    {
                        Console.Write($"{variant[i]}, ");    
                    }
                    Console.Write("\b\b :");
                    //камнем забити
                    //ножницами зарізати
                    //задушити бумагою
                    hod = Console.ReadLine();
                    Console.WriteLine();
                    //конвертуемо в число
                    for (byte i = 0; i < variant.Length; i++)
                    {
                        if (variant[i]==hod)
                        {
                            PLAYER_CUL = i;
                            break;
                        }
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