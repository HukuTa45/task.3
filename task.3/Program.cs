using System;

namespace task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Начало работы");
            var queue = new Queue();
            var stack = new Stack();


            int[] numbers = {5, 10, 15, 20, 25};
            var getValue = "Получил значение: ";
            var deleteValue = "Удалил значение: ";

            Console.WriteLine("Переменные инициализированы");

            for (var i = 0; i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
                stack.Push(numbers[i]);
            }

            Console.WriteLine("Очередь и стек заполнены\n");

            Console.WriteLine("Работа с Очередью:");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{getValue} {queue.Peek()}");
                Console.WriteLine($"{deleteValue} {queue.Dequeue()}");
            }

            Console.WriteLine("\nРабота со Стеком:");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{getValue} {stack.Peek()}");
                Console.WriteLine($"{deleteValue} {stack.Pop()}");
            }
        }
    }
}