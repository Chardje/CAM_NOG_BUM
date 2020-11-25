using System;

namespace CAM_NOG_BUM
{
    class Program
    {/*
      сделать нечю
      */
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
            Random R = new Random();
            byte bot_cul;
            byte PLAYER_CUL;
            byte raund = 0;
            byte win_bot = 0;
            byte win_Player = 0;
            string hod;
            while (true)
            {
                bot_cul = (byte)R.Next(0, 3);
                //0 kum 1 nog 2 bum
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Вибери свой обєкт(для убийства): k(kumen), n(nogniz), b(bumaga)");
                    //камнем забити
                    //ножницами зарізати
                    //задушити бумагою
                    hod = Console.ReadLine();
                    //конвертуемо в число
                    if (hod == "k")
                    {
                        PLAYER_CUL = 0;
                        break;
                    }
                    else if (hod == "n")
                    {
                        PLAYER_CUL = 1;
                        break;
                    }
                    else if (hod == "b")
                    {
                        PLAYER_CUL = 2;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                    }
                }

                if (PLAYER_CUL == bot_cul)
                {
                    //drow
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    raund++;
                    Console.WriteLine($"Раунд{raund} бил закончн ничєй");

                }
                else if ((bot_cul == 0 && PLAYER_CUL == 1) || (bot_cul == 1 && PLAYER_CUL == 2) || (bot_cul == 2 && PLAYER_CUL == 0))
                {
                    //bot win round
                    raund++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Раунд{raund} бил закончн победой бота");
                    win_bot++;
                }
                else if ((bot_cul == 1 && PLAYER_CUL == 0) || (bot_cul == 2 && PLAYER_CUL == 1) || (bot_cul == 0 && PLAYER_CUL == 2))
                {
                    //player win round
                    raund++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Раунд{raund} бил закончн победой игрока");
                    win_Player++;
                }
                else
                {
                    //если ошибка
                    Console.WriteLine("erorr");
                }
                if (win_Player + 3 == win_bot)
                {
                    //победа бота
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Игрра била закончена на раунде под номером {raund} с щотом {win_bot}/{win_Player} в пользу бота");
                    break;
                }
                else if (win_Player - 3 == win_bot)
                {
                    //победа игрока
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Игрра била закончена на раунде под номером {raund} с щотом {win_bot}/{win_Player} в пользу игрока");
                    break;
                }
            }
        }
    }
}
