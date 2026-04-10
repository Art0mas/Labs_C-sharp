using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class TaskTracker
    {
        TaskStorage taskStorage = new TaskStorage();

        private List<TaskItem>? tasks = new List<TaskItem>();

        public void Run()
        {
            tasks = taskStorage.Load();
            while (true)
            {
                Console.WriteLine("====================");
                Console.WriteLine("1. Додати задачу\n2. Змінити статус задач\n3. Видалити задачу\n4. Переглянути список задач" +
                    "\n5. Вийти з програми\n");
                Console.Write("Виберіть варіант зі списку: ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Clear();
                        AddTask();
                        break;
                    case 2:
                        Console.Clear();
                        ChangeStatus();
                        break;
                    case 3:
                        Console.Clear();
                        DeleteTask();
                        break;
                    case 4:
                        Console.Clear();
                        ShowTasks();
                        break;
                    case 5:
                        Console.Clear();
                        Exit();
                        break;
                }
            }
            

        }

        private void AddTask()
        {
            Console.Write("Введіть назву задачі: ");
            string? title = Console.ReadLine();
            tasks?.Add(new TaskItem {Title = title, isCompleted = false });
            Console.WriteLine("Задачу додано");
        }
        private void ChangeStatus()
        {
            int count = 0;
            foreach (var task in tasks)
            {
                count++;
                Console.WriteLine($"{count}. {task.Title} [Статус: {TaskStatus(task)}]");
            }
            Console.WriteLine();

            Console.Write("\nВиберіть задачу для зміни статусу:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x <= tasks.Count)
            {
                tasks[x - 1].isCompleted = !tasks[x - 1].isCompleted;
                Console.WriteLine("Статус задачі змінено");
            }
            else Console.WriteLine("Помилка! Задачі з таким номером не існує"); 
        }

        private void ShowTasks()
        {
            Console.WriteLine("Усі задачі: ");
            int count = 0;
            foreach (var task in tasks)
            {
                count++;
                Console.WriteLine($"{count}. {task.Title} [Статус: {TaskStatus(task)}]");
            }
            Console.WriteLine();
        }

        private void DeleteTask()
        {
            int count = 0;
            foreach (var task in tasks)
            {
                count++;
                Console.WriteLine($"{count}. {task.Title} [Статус: {TaskStatus(task)}]");
            }

            Console.Write("\nВиберіть задачу для видалення: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x <= tasks.Count)
            {
                tasks.RemoveAt(x - 1);
                Console.WriteLine("Задачу видалено");
            }
            else Console.WriteLine("Помилка! Задачі з таким номером не існує");
        }
        private void Exit()
        {
            taskStorage.Save(tasks);
            Environment.Exit(0);
        }
        private string TaskStatus(TaskItem taskItem)
        {
            if (taskItem.isCompleted == true) return "Завершено";
            else return "В процесі";
        }

    }
}
