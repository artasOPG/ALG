using System;
using System.Windows;

namespace Zadanie
{
    class Program
    {
        public string number;
        public void choose() {
            Console.WriteLine("Выберете интересующее вас задание: (-1, -2, -3) ");
            number = Console.ReadLine();
            if (number == "1")
            {
                task1();
            }
                else if (number == "2")
                {
                    task2();
                }
                    else if (number == "3")
                    {
                        task3();
                    }
                        else { Console.WriteLine("Возможные вариванты ответы: 1, 2, 3. Введите один из них."); }
        }
        protected void task1()
        {
            Console.WriteLine("ВЫБРАНО ЗАДАНИЕ 1\nВведите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>7)
            {
                Console.WriteLine("Привет");
            }
        }
        protected void task2()
        {
            String name;
            Console.WriteLine("ВЫБРАНО ЗАДАНИЕ 2\nВведите имя: ");
            name = Console.ReadLine();
            if (name.ToLower() == "вячеслав"||name.ToLower()=="вячеслав ")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
                else
                {
                Console.WriteLine("Нет такого имени");
                }
        }
        protected void task3()
        {
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mass[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}-й элемент = {1}", i+1, mass[i]);
            }
            Console.WriteLine("Элементы массива, кратные 3: ");
                for (int i=0;i<n;i++)
                {
                    if (((double)mass[i]%3)==0)
                    {
                        Console.WriteLine("{0}-й элемент = {1}", i + 1, mass[i]);
                    }
                }
        }    
    }
    class MainClass
    {
        static void Main(string[] arg)
        {
            Program obj = new Program();
            bool sourse = true;
            string answer;
            while (sourse)
            {
                Console.WriteLine("Начать работу? (-y, -n)");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    obj.choose();
                }
                else if (answer == "n")
                {
                    sourse = false;
                }
                else {
                    Console.WriteLine("Повторите попытку ввода ");
                }
            }
                }

            }
        }