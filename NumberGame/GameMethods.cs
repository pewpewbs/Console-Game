using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static NumberGame.Program;

namespace NumberGame
{/// <summary>
/// Класс для реализации игры
/// </summary>
    internal class GameMethods
    {
        /// <summary>
        /// Значение для ввода в будущем
        /// </summary>
        static string? menuValue;
        /// <summary>
        /// Число которое пишет пользователь
        /// </summary>
        static int personalValue;
        /// <summary>
        /// Рандомное число для загадываний
        /// </summary>
        static Random rnd = new Random();
        /// <summary>
        /// Переменная счетчик попыток, чтобы при победе написать их количество
        /// </summary>
        static int counter = 0;

        /// <summary>
        /// Конструктор класса который начинает игру с меню
        /// </summary>
        public GameMethods()
        {
            //очистка консоли
            Console.Clear();
            
            //вызов меню
            Menu();

        }
        /// <summary>
        /// Метод запуска меню игры
        /// </summary>
        public static void Menu()
        {
            //текст
            improveWriteLine("This is the game menu\nPlease select an action");
            improveWriteLine("'Play'\t'Instruction'\tor 'Exit'");

            //установка пустого значения для корректной работы
            menuValue = ""; 

            //цикл который будет работать бесконечно, пока не получит в переменную menuValue значение Play/play
            //либо Instruction/instruction либо Exit/exit
            while (true)
            {
                //ввод данных
                menuValue = Console.ReadLine();

                //значения при которых будет сделан выход из цикла, либо повтор цикла
                if (menuValue == "Play" || menuValue == "play" || menuValue == "Instruction" || menuValue == "instruction" || menuValue == "Exit" || menuValue == "exit")
                    break;
                else
                    improveWriteLine("Write correct data!", 80);

            }
            //условия запуска Игры, Инструкции, или же Выхода
            if (menuValue == "Play" || menuValue == "play")
            {
                //метод запуска игры
                StartGame();
            }
            else if (menuValue == "Instruction" || menuValue == "instruction")
            {
                //метод запуска инструкции
                Instruction();
            }
            else if (menuValue == "Exit" || menuValue == "exit")
            {
                //метод выхода
                Exit();
            }
            
        }
        /// <summary>
        /// Метод запуска игры
        /// </summary>
        static private void StartGame()
        {
            //рандомное число загаданное для игры
            int random = rnd.Next(0,101);

            //текст
            improveWriteLine("Ok\nI'll make up a numberic!\nTry to guess!!");

            while (true)
            {
                //очистка консоли
                Console.Clear();

                //текст
                improveWriteLine("Enter value");

                //счетчик считает количество попыток(количество пройденых итераций цикла)
                counter++;

                //число пользователя
                personalValue = Convert.ToInt32(Console.ReadLine());

                //условие для победы или подсказок для дальнейшей победы
                if (personalValue > random)
                {
                    improveWriteLine("Write less value");
                }
                else if(personalValue < random)
                {
                    improveWriteLine("Write more value");
                }
                else if(personalValue == random)
                {
                    improveWriteLine("You win!!!");
                    //вывод количества попыток

                    improveWriteLine($"number of attempts: {counter}");
                    improveWriteLine("Press enter to return to the menu");
                    Console.ReadLine();
                    improveWriteLine("Return to menu");
                    improveWriteLine("...", 1000);

                    //очистка консоли
                    Console.Clear();

                    //меню
                    Menu();
                }

                //условие если цыфра выше 100 или ниже 0
                if(personalValue > 100 || personalValue < 0)
                {
                    improveWriteLine("Your value not can be more 100 or less 0");
                }

                //пауза
                System.Threading.Thread.Sleep(300);
            }
            
        }
        /// <summary>
        /// Метод запуска инструкции
        /// </summary>
        static private void Instruction()
        {
            //пропуск 2х строк
            Console.WriteLine("\n\n");

            //вывод инструкции
            improveWriteLine("|------------------------------------------------------------------------------------------|\n|                                    Instruction                                           |\n|                                                                                          |\n|            Hello, this is my little tutorial on one very simple game.                    |\n|                  The game is to guess a number from 0 to 100.                            |\n| Just enter the numbers and the console will tell you how close you are to the target.    |\n|                                                                                          |\n|__________________________________________________________________________________________|\n", 10);
            improveWriteLine("Press enter to return to the menu");

            //ожидание ентера
            Console.ReadLine();

            improveWriteLine("Return to menu");
            improveWriteLine("...",1000);

            //очистка консоли
            Console.Clear();

            //переход в меню
            Menu();
        }
        /// <summary>
        /// Метод выхода из игры
        /// </summary>
        static private void Exit()
        {
            //Повторный вопрос действительно ли пользователь хочет покинуть игру
            improveWriteLine("are you sure?");
            improveWriteLine("Write 'Yes' or 'No'");

            //установка пустого значения для корректной работы
            menuValue = "";

            //цикл который будет работать бесконечно, пока не получит в переменную menuValue значение Yes/yes или No/no
            while (true)
            {
                //ввод данных
                menuValue = Console.ReadLine();
                //значения при которых будет сделан выход из цикла, либо повтор цикла
                if (menuValue == "Yes" || menuValue == "yes" || menuValue == "No" || menuValue == "no")
                    break;
                else
                    improveWriteLine("Write correct data!", 80);

            }

            //если 'Yes'=> выход, если 'No'=> возврат в меню
            if (menuValue == "No" || menuValue == "no")
            {
                //текст
                improveWriteLine("Return to menu");
                improveWriteLine("...", 1000);

                //очистка консоли
                Console.Clear();

                //возврат в меню
                Menu();

            }
            else if (menuValue == "Yes" || menuValue == "yes")
            {
                //текст
                improveWriteLine("Bye");

                //очистка консоли
                Console.Clear();
            }
            
        }
    }
}
