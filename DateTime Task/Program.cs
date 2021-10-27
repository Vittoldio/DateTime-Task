using System;
namespace DateTime_Task
{
    class Program
    {
        public static int InputNumber()
        {
            string s = Console.ReadLine();
            Int16 result;
            while(!Int16.TryParse(s, out result))
            {
                Console.WriteLine("Введите число!");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int years = InputNumber();
            Console.WriteLine("Введите месяц:");
            int months = InputNumber();
            while (months > 12 || months<1)
            {
                if (months > 12 || months < 1)
                {
                    Console.WriteLine("Вы ввели неверный месяц, месяцы от 1 до 12.............");
                    months = InputNumber();
                }
            }
            Console.WriteLine("введите название дня недели, даты которого вы ходите знать в ведённом месяце");
            string selection = Console.ReadLine();
            selection.ToLower();
            switch(selection)
            {
                case "понедельник":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "понедельник")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "вторник":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "вторник")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "среда":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "среда")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "четверг":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "четверг")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "пятница":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "пятница")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "суббота":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "суббота")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                case "воскресенье":
                    {
                        for (int day = 1; day < 31; day++)
                        {
                            DateTime date = new DateTime(years, months, day);
                            if (date.ToString("dddd") == "воскресенье")
                            {
                                date.ToString("d");
                                Console.WriteLine($"date");
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели неверный день недели");
                        break;
                    }
            }
            
        }

    }
}
