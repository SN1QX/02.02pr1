using _02._02pr1.Managers;
using System;
using _02._02pr1.Models;

namespace _02._02pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Personal To-Do Manager!");

            //Создаем экземпляр менеджера списка дел
            var todoManadger = new TodoListManager();

            //Теперь вызываем методы через экземпляр менеджера
            todoManadger.DisplayTodoList();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}