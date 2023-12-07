using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


class Task
{
    public DateTime DueDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}

class Program
{
    private static List<Task> tasks = new List<Task>();

    static void Main()
    {
        loadTaskFromFile();
        Console.WriteLine();
        Console.WriteLine("Добро пожаловать в ежедневник!");
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Посмотреть задачи");
            Console.WriteLine("2. Добавить новые задачи");
            Console.WriteLine("3. Удалить задачи");
            Console.WriteLine("4. Пометить задачи выполненными");
            Console.WriteLine("5. Выход");
            Console.WriteLine();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    viemTasksMenu();
                    break;
                case "2":
                    addNewTasksMenu();
                    break;
                case "3":
                    deleteTask();
                    break;
                case "4":
                    markTaskCompleted();
                    break;
                case "5":
                    Console.WriteLine("До свидания!");
                    saveTaskToFile();
                    return;
                default:
                    Console.WriteLine("Некорректный выбор, попробуйте снова.");
                    break;

            }
        }
// Меню просмотра задач
        static void viemTasksMenu()
        {
            Console.WriteLine("Выберите тип задач:");
            Console.WriteLine("1. Задачи на сегодня");
            Console.WriteLine("2. Задачи на завтра");
            Console.WriteLine("3. Задачи на неделю");
            Console.WriteLine("4. Все задачи");
            Console.WriteLine("5. Предстоящие задачи");
            Console.WriteLine("6. Выполненные задачи");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    viemTasksForDay(DateTime.Today);
                    break;
                case "2":
                    viemTasksForDay(DateTime.Today.AddDays(1));
                    break;
                case "3":
                    viemTasksForWeek();
                    break;
                case "4":
                    viemAllTasks();
                    return;
                case "5":
                    viemUpcomingTasks();
                    return;
                case "6":
                    viemComletedTasks();
                    return;
                default:
                    Console.WriteLine("Некорректный выбор, попробуйте снова.");
                    break;
            }
            
        }
        // просмотр задач на указаную дату
        static void viemTasksForDay(DateTime date)
        {
            Console.WriteLine($"Список задач на {date.ToShortDateString()}:");

            var tasksForDay = tasks.Where(tasks => tasks.DueDate == date.Date).ToList();
            if (tasksForDay.Count > 0)
            {
                foreach (var task in tasksForDay)
                {
                    Console.WriteLine($"Название: {task.Title}");
                    Console.WriteLine($"Описание: {task.Description}");
                    Console.WriteLine($"Дата {task.DueDate}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("На выбранную дату задач нет.");
            }
            
            string temp = Console.ReadLine();
            return;
        }
        // просмотр задач на неделю
        static void viemTasksForWeek()
        {
            Console.WriteLine("Список задач на неделю");
            
            DateTime currentDate = DateTime.Now;
            DateTime endOfWeek = currentDate.AddDays(7);

            var upcomingTasks = tasks.Where(task => task.DueDate >= currentDate && task.DueDate <= endOfWeek).ToList();

            if (upcomingTasks.Count == 0)
            {
                Console.WriteLine("На следующую неделю задач нет.");
            }
            else
            {
                foreach (var task in upcomingTasks)
                {
                    Console.WriteLine($"{task.Title} - {task.DueDate.ToShortDateString()}");
                }
            }
            
            string temp = Console.ReadLine();
            return;
           
        }
        // просмотр всех задач
        static void viemAllTasks()
        {
            Console.WriteLine("Список всех задач:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.Title} - {task.DueDate.ToShortDateString()}");
                }
            }
            string temp = Console.ReadLine();
            return;
        }
        //просмотр предстоящих задач
        static void viemUpcomingTasks()
        {
            Console.WriteLine("Предстоящие задачи: ");
            
            DateTime currentDate = DateTime.Now;

            var upcomingTasks = tasks.Where(task => task.DueDate >= currentDate).ToList();

            if (upcomingTasks.Count == 0)
            {
                Console.WriteLine("Нет предстоящих задач.");
            }
            else
            {
                foreach (var task in upcomingTasks)
                {
                    Console.WriteLine($"{task.Title} - {task.DueDate.ToShortDateString()}");
                }
            }
            string temp = Console.ReadLine();
            return;
        }
        //просмотр выполненых задач
        static void viemComletedTasks()
        {
            Console.WriteLine("Список выполненых задач");

            var completedTasks = tasks.Where(task => task.IsCompleted).ToList();

            if (completedTasks.Count == 0)
            {
                Console.WriteLine("Нет выполненных задач.");
            }
            else
            {
                foreach (var task in completedTasks)
                {
                    Console.WriteLine($"{task.Title} - {task.DueDate.ToShortDateString()}");
                }
            }
            
            string temp = Console.ReadLine();
            return;
        }
        //удаление задач
        static void deleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст");
                return;
            }
            Console.WriteLine("Выберите задачу для удаления: ");
            DisplayTasks();

            int taskNumber;
            while (true)
            {
                Console.Write("Введите номер задачи для удаления (или 0 для отмены): ");
                if (int.TryParse(Console.ReadLine(),out taskNumber) && taskNumber >= 0 && taskNumber <= tasks.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }

            if (taskNumber == 0)
            {
                Console.WriteLine("Удаление отменено.");
            }
            else
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Задача успешно удалена.");
            }
            Console.WriteLine();
            string temp = Console.ReadLine();
            return;
            
        }
        //меню добавления новых задач
        static void addNewTasksMenu()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();
            
            Console.Write("Введите описание задачи: ");
            string description = Console.ReadLine();

            DateTime inputDate;
            bool validDate;

            do
            {
                Console.WriteLine("Введите дату заверешения задачи (в формате yyyy-WW-dd): ");
                string dateInput = Console.ReadLine();

                validDate = DateTime.TryParseExact(dateInput, "yyyy-MM-dd", null,
                    System.Globalization.DateTimeStyles.None, out inputDate);

                if (!validDate)
                {
                    Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                }
            } while (!validDate);

            Task newTask = new Task
            {
                Title = title,
                Description = description,
                DueDate = inputDate
            };
            tasks.Add(newTask);
            Console.WriteLine("Новая задача добавлена.");


            string temp = Console.ReadLine();
            return;
        }

        static void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Title} - {tasks[i].DueDate.ToShortDateString()}");
            }
        
        }

        static void markTaskCompleted()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст");
                return;
            }
            Console.WriteLine("Выберите задачу для удаления: ");
            DisplayTasks();

            int taskNumber;
            while (true)
            {
                Console.Write("Введите номер задачи для отметки задачи выполненной (или 0 для отмены): ");
                if (int.TryParse(Console.ReadLine(),out taskNumber) && taskNumber >= 0 && taskNumber <= tasks.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }

            if (taskNumber == 0)
            {
                Console.WriteLine("Действие отменено.");
            }
            else
            {
                tasks[taskNumber - 1].IsCompleted = true;
                Console.WriteLine("Задача помечена выполненной.");
            }
            Console.WriteLine();
            string temp = Console.ReadLine();
            return;
            
        }

        static void saveTaskToFile()
        {
            string jsonString = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", jsonString);
            Console.WriteLine("Задачи сохранены в файл.");
        }

        static void loadTaskFromFile()
        {
            if (File.Exists("tasks.json"))
            {
                string jsonString = File.ReadAllText("tasks.json");
                tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
                Console.WriteLine("Задачи загружены из файла");
            }
            else
            {
                Console.WriteLine("Файл с задачами не найден.");
            }
        }
    }
}