﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Order.MainMenu();
                Console.Clear();
                Console.WriteLine("Заказ сделан! Нажмите Esc чтобы сделать еще один заказ.");
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Escape);
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
        }
    }
}