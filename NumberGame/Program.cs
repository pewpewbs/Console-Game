#region using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;
#endregion
namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //очищение консоли
            Console.Clear();

            //начальный текст
            improveWriteLine("Hey!");
            Console.ReadLine();
            improveWriteLine("I don't know why you came here, but you got into my game!", 90);
            Console.ReadLine();
            improveWriteLine("Have a desire to play?");
            improveWriteLine("Write 'Yes' or 'No'");

            //переменная для ответа
            string? value;

            //ввод ответа до бесконечности пока не будет Yes/yes либо No/no
            while (true)
            {
                value = Console.ReadLine();
                if (value == "Yes" || value == "yes" || value == "No" || value == "no")
                    break;
                else
                    improveWriteLine("Write correct data!", 80);

            }

            //если 'Yes'=> запуск игры, если 'No'=> выход
            if (value == "Yes" || value == "yes")
            {
                //создание обьекта и вызов его конструткора без параметров
                GameMethods game = new GameMethods();

            }
            else if (value == "No" || value == "no")
            {
                //текст
                improveWriteLine("Bye");

                //очистка консоли
                Console.Clear();
            }


        }
        /// <summary>
        /// Улучшенная версия WriteLine которая сможет выводить текст по буквам
        /// </summary>
        /// <param name="improveText">Передача строки для её обработки</param>
        /// <param name="time">время в ms для паузы после каждой буквы</param>
         
        // улучшеный метод вывода информации сделанный специально под эту программу с ручной установкой паузы
        public static void improveWriteLine(string improveText, int time)
        {
            //превращение строки в массив символов
            char[] textArray = improveText.ToCharArray();

            //цикл вывода строки по буквам с паузой
            for (int i = 0; i < textArray.Length; i++)
            {
                //размер паузы который указывается при вызове метода improveWriteLine в параметре time
                System.Threading.Thread.Sleep(time);
                //вывод символа
                Console.Write(textArray[i]);
            }
            //переход на новую строку
            Console.Write("\n");
        }
        /// <summary>
        /// Улучшенная версия WriteLine которая сможет выводить текст по буквам
        /// </summary>
        /// <param name="improveText">Передача строки для её обработки</param>

        //улучшеный метод вывода информации сделанный специально под эту программу
        public static void improveWriteLine(string improveText)
        {
            //превращение строки в массив символов
            char[] textArray = improveText.ToCharArray();

            //цикл вывода строки по буквам с паузой
            for (int i = 0; i < textArray.Length; i++)
            {
                //размер паузы 80ms
                System.Threading.Thread.Sleep(80);

                //вывод символа
                Console.Write(textArray[i]);
            }
            //переход на новую строку
            Console.Write("\n");
        }

    }
}