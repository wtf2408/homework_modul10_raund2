using System;
using System.IO;
using System.Security;
using System.Xml.Serialization;

using Newtonsoft.Json;


namespace modul10
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            bool appIsWork = true;
            string path = "D:\\test_json";

            string clientInfo = File.ReadAllText(path);

            Command inputCommand; // команда, которую выберет пользователь для работы с данными

            string inputData; // временная переменная для данных, которые нужно установить или изменить

            Console.WriteLine("\n1 - Consultant\n2 - Manager"); // выбор работника

            var position = (WorkerPosition)int.Parse(Console.ReadLine());

            switch (position)
            {
                case WorkerPosition.Consultant: // если выбрали консультанта
                    Consultant consultant = JsonConvert.DeserializeObject<Consultant>(clientInfo);
                    while (appIsWork)
                    {
                        Console.WriteLine("Выбирите действие: \n" +
                            "1 - Вывести инф. о клиенте\n" +
                            "2 - Изменить/Установить номер телефона клиента\n" +
                            "3 - Посмотреть историю изиенений\n");

                        inputCommand = (Command)int.Parse(Console.ReadLine());

                        switch (inputCommand)
                        {
                            case Command.PrintInfo:

                                Console.WriteLine($"{consultant.GetPhoneNumber()}\n" +
                                    $"{consultant.GetPassport()}\n" +
                                    $"{consultant.GetLastlName()}\n" +
                                    $"{consultant.GetFirstlName()}");
                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;


                            case Command.SetPhoneNumber:

                                Console.Write("Введите телефон: ");
                                inputData = Console.ReadLine();
                                consultant.SetPhoneNumber(inputData);
                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                            case Command.ShowChanges:

                                consultant.PrintChange();
                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;
                                
                        }
                    }
                    break;
                case WorkerPosition.Manager: // если выбрали менеджера

                    Manager manager = JsonConvert.DeserializeObject<Manager>(File.ReadAllText(path));

                    while (appIsWork)
                    {
                        Console.WriteLine("Выбирите действие: \n" +
                            "1 - Вывести инф. о клиенте\n" +
                            "2 - Изменить/Установить номер телефона клиента\n" +
                            "3 - Посмотреть историю изиенений\n" +
                            "4 - Изменить/Установить серию и номер паспорта\n" +
                            "5 - Изменить/Установить Фамилию\n" +
                            "6 - Изменить/Установить Имя");

                        inputCommand = (Command)int.Parse(Console.ReadLine());

                        switch (inputCommand)
                        {
                            case Command.PrintInfo:

                                Console.WriteLine($"{manager.GetPhoneNumber()}\n" +
                                    $"{manager.GetPassport()}\n" +
                                    $"{manager.GetFirstlName()}\n" +
                                    $"{manager.GetLastlName()}\n");

                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                            case Command.SetPhoneNumber:

                                Console.Write("Введите телефон: ");
                                inputData = Console.ReadLine();
                                manager.SetPhoneNumber(inputData);

                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                            case Command.ShowChanges:

                                manager.PrintChange();
                                break;

                            case Command.SetPassport:

                                Console.Write("Введите паспорт: ");
                                inputData = Console.ReadLine();
                                manager.SetPassport(inputData);

                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                            case Command.SetLastName:

                                Console.Write("Введите фамилию: ");
                                inputData = Console.ReadLine();
                                manager.SetLastName(inputData);

                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                            case Command.SetFirstName:

                                Console.Write("Введите имя: ");
                                inputData = Console.ReadLine();
                                manager.SetFirstName(inputData);

                                Console.WriteLine("\nХотите продолжить?\n" +
                                    "Да - надмите Y\n" +
                                    "Нет - любую другую");
                                if (Console.ReadKey().Key != ConsoleKey.Y) appIsWork = false;
                                break;

                        }
                    }
                    break;

            }
        }
    }
}
