using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp26;

namespace ConsoleApp26
{
    public class Order
    {
        private static Subparag Romb = new Subparag(400, "Ромб", "Форма");
        private static Subparag Triangle = new Subparag(450, "Треугольник", "Форма");
        private static Subparag Paral = new Subparag(350, "Параллелепипед", "Форма");

        private static Subparag Drish = new Subparag(150, "Дрыщуган", "Размер");
        private static Subparag Mid = new Subparag(250, "Середнячок", "Размер");
        private static Subparag Boss = new Subparag(300, "Кочка", "Размер");

        private static Subparag TasteCum = new Subparag(15, "\"Протеиновый шейк с молоком\"", "Вкус");
        private static Subparag Rock = new Subparag(40, "\"Свежие альпийские горы\"", "Вкус");
        private static Subparag TozheRock = new Subparag(22, "\"Камень\"", "Вкус");

        private static Subparag Amount = new Subparag(300, "Один корж", "Количество");
        private static Subparag Amountt = new Subparag(500, "Два коржа", "Количество");
        private static Subparag Amounttt = new Subparag(650, "Четыре коржа", "Количество");

        private static Subparag Glaze = new Subparag(300,"Ванильная глазурь", "Глазурь");
        private static Subparag Glazee = new Subparag(200, "Глазурь \"Мать моя женщина\"", "Глазурь");
        private static Subparag Glazik = new Subparag(100, "Глазурь ", "Глазурь");

        private static Subparag Goldforeat = new Subparag(2000, "Украшение \"Съедобное золото\"", "Декор");
        private static Subparag Gold = new Subparag(499, "Украшения \"Несъедобное золото\"", "Декор");
        private static Subparag Dota = new Subparag(399, "Украшение \"Аракана Пуджа\"", "Декор");

        private static List<Subparag> Form = new List<Subparag>() { Romb, Triangle, Paral };
        private static List<Subparag> Huge = new List<Subparag>() { Drish, Mid, Boss };
        private static List<Subparag> Taste = new List<Subparag>() { TasteCum, Rock, TozheRock };
        private static List<Subparag> Amount1 = new List<Subparag>() { Amount, Amountt, Amounttt };
        private static List<Subparag> Glazze = new List<Subparag>() { Glaze, Glazee, Glazik };
        private static List<Subparag> Beautiful = new List<Subparag>() { Goldforeat, Gold, Dota };



        private static bool IsDopMenu = false;
        private static string Arrow = "->";
        private static int Price = 0;
        private static int StrelkaPos = 1;

        public static void StrelkaChange(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Arrow);
        }

        public static void MainMenu()
        {
            ConsoleKeyInfo key;
            do
            {
                Text();
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Strelochki("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Strelochki("Down");
                        break;
                    case ConsoleKey.Enter:
                        switch (StrelkaPos)
                        {
                            case 2:
                                DopMenu(Form);
                                break;
                            case 3:
                                DopMenu(Huge);
                                break;
                            case 4:
                                DopMenu(Taste);
                                break;
                            case 5:
                                DopMenu(Amount1);
                                break;
                            case 6:
                                DopMenu(Glazze);
                                break;
                            case 7:
                                DopMenu(Beautiful);
                                break;
                            case 8:
                                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orders.txt", Print());
                                return;
                        }
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }

       // private string pechat()
       // {
       //     if (cake.end.count !0)
       //            {
       //         var endcake = cake.end[0]
       //     }
       // }

        private static string Print()
        {
            if (Tort.FinalTort.Count != 0)
            {
                var DoneTort = Tort.FinalTort[0];
                return $"\nЗаказ от {DateTime.Now}\n\tВаш торт: {DoneTort.NameForm}, {DoneTort.NameHuge}, {DoneTort.NameTaste}," +
                $" {DoneTort.NameHuge}, {DoneTort.NameBeautiful}," +
                $" {DoneTort.NameGlaze}\n\tЦена - {DoneTort.Sum()}\n";
            }
            else
            {
                return "Вы не сделали заказ.\n";
            }
        }

        private static void DopMenu(List<Subparag> subparags)
        {
            StrelkaPos = 0;
            IsDopMenu = true;
            ConsoleKeyInfo key;
            bool FirstTime = true;
            do
            {
                if (FirstTime)
                {
                    Console.Clear();
                    FirstTime = false;
                }
                IsDopMenu = true;
                int i = 0;
                foreach (var item in subparags)
                {
                    Console.SetCursorPosition(2, i);
                    Console.WriteLine($"{item.name} - {item.price}");
                    i++;
                }
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        Strelochki("Down");
                        break;
                    case ConsoleKey.UpArrow:
                        Strelochki("Up");
                        break;
                    case ConsoleKey.Enter:
                        switch (StrelkaPos)
                        {
                            case 0:
                                Baking(StrelkaPos, subparags);
                                break;
                            case 1:
                                Baking(StrelkaPos, subparags);
                                Price += subparags[1].price;
                                break;
                            case 2:
                                Baking(StrelkaPos, subparags);
                                Price += subparags[2].price;
                                break;
                        }
                        break;
                }
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);
            IsDopMenu = false;
            StrelkaPos = 1;
            Console.Clear();
        }

        private static void Baking(int StrPos, List<Subparag> subparags)
        {
            switch (subparags[StrelkaPos].type, Tort.FinalTort.Count)
            {
                case ("Форма", 0):
                    Tort.FinalTort.Add(new Tort(Fname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceForm = subparags[StrPos].price;
                    break;

                case ("Размер", 0):
                    Tort.FinalTort.Add(new Tort(Rname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceHuge = subparags[StrPos].price;
                    break;

                case ("Вкус", 0):
                    Tort.FinalTort.Add(new Tort(Vname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceTaste = subparags[StrPos].price;
                    break;

                case ("Глазурь", 0):
                    Tort.FinalTort.Add(new Tort(Gname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceGlaze = subparags[StrPos].price;
                    break;

                case ("Количество", 0):
                    Tort.FinalTort.Add(new Tort(Kname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceAmount = subparags[StrPos].price;
                    break;

                case ("Декор", 0):
                    Tort.FinalTort.Add(new Tort(Dname: subparags[StrPos].name));
                    Tort.FinalTort[0].PriceBeautiful = subparags[StrPos].price;
                    break;


                case ("Форма", 1):
                    Tort.FinalTort[0].NameForm = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceForm = subparags[StrPos].price;
                    break;

                case ("Размер", 1):
                    Tort.FinalTort[0].NameHuge = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceHuge = subparags[StrPos].price;
                    break;

                case ("Вкус", 1):
                    Tort.FinalTort[0].NameTaste = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceTaste = subparags[StrPos].price;
                    break;

                case ("Глазурь", 1):
                    Tort.FinalTort[0].NameGlaze = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceGlaze = subparags[StrPos].price;
                    break;

                case ("Количество", 1):
                    Tort.FinalTort[0].NameAmount = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceAmount = subparags[StrPos].price;
                    break;

                case ("Декор", 1):
                    Tort.FinalTort[0].NameBeautiful = subparags[StrPos].name;
                    Tort.FinalTort[0].PriceBeautiful = subparags[StrPos].price;
                    break;
            }
        }

       // public static void arrows(string where)
       //  {
       //     if (!ismenu)
       //     {
       //         if(posofarrow >2)
       //             {
       //                 posofarrow--;
       //                 arrowchange(0, posofarrow);
       //  }          }

        public static void Strelochki(string Where)
        {
            if (!IsDopMenu)
            {
                Console.Clear();
                if (Where == "Up")
                {
                    if (StrelkaPos > 2)
                    {
                        StrelkaPos--;
                        StrelkaChange(0, StrelkaPos);
                    }
                    else
                    {
                        StrelkaPos = 1;
                    }
                }
                else if (Where == "Down")
                {
                    if (StrelkaPos < 8)
                    {
                        StrelkaPos++;
                        StrelkaChange(0, StrelkaPos);
                    }
                    else
                    {
                        StrelkaPos = 9;
                    }
                }
            }
            else
            {
                Console.Clear();
                if (Where == "Up")
                {
                    if (StrelkaPos > 0)
                    {
                        StrelkaPos--;
                        StrelkaChange(0, StrelkaPos);
                    }
                }
                else if (Where == "Down")
                {
                    if (StrelkaPos < 2)
                    {
                        StrelkaPos++;
                        StrelkaChange(0, StrelkaPos);
                    }
                    else
                    {
                        StrelkaPos = 3;
                    }
                }
            }
        }
        //private static void Text()
        //{
        //    Console.WriteLine("\"Здравия желаю, товарищ. Выбирайте торт на свой вкус и цвет!\"");
        //    string[] list = {
        //    "ФормОчка тортика", "Размерчик тортика", "Нежный вкус коржика", "Количество коржиковвв", 
        //        "Глазуурьь", "Украшения из золота (Эксклюзив)", "Закрыть заказ"};
        //    foreach (string item in list)
        //    {
        //        int a = 2;
        //        int b = 1;
        //        Console.WriteLine(item);
        //        Console.SetCursorPosition(a,b++);
               
        //    }
        //}
        private static void Text()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Добро пожаловать! Выбирайте нужные вам характеристики торта.");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("ФормОчка тортика");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Размер тортика");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Вкус коржиков");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Количество коржиков");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Глазурь");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Декорации");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("The end.");
            Console.SetCursorPosition(2, 9);

            if (Tort.FinalTort.Count != 0)
            {
                var DoneTort = Tort.FinalTort[0];
                Console.WriteLine($"\nПрайс: {DoneTort.Sum()}");
                Console.WriteLine($"Описание вашего торта или торта: {DoneTort.NameForm}, {DoneTort.NameHuge}, {DoneTort.NameTaste}," +
                $" {DoneTort.NameAmount}, {DoneTort.NameBeautiful}," +
                $" {DoneTort.NameGlaze}");
            }
            else
            {
                Console.WriteLine($"\nПрайс: ");
                Console.WriteLine($"Описание вашего торта или торта: ");
            }
        }
    }
}