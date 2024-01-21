using System;

namespace StringArrayFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод массива строк с клавиатуры
            Console.WriteLine("Введите элементы массива через запятую:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(", ");

            // Создание нового массива из строк, длина которых меньше или равна 3 символам
            string[] newArray = FilterArrayByLength(inputArray, 3);

            // Вывод результата
            Console.WriteLine("Результат:");
            foreach (string word in newArray)
            {
                Console.Write(word + " ");
            }
        }

        // Функция для фильтрации массива по длине строк
        static string[] FilterArrayByLength(string[] inputArray, int maxLength)
        {
            int count = 0;
            foreach (string word in inputArray)
            {
                if (word.Length <= maxLength)
                {
                    count++;
                }
            }

            string[] newArray = new string[count];
            int index = 0;
            foreach (string word in inputArray)
            {
                if (word.Length <= maxLength)
                {
                    newArray[index] = word;
                    index++;
                }
            }
            return newArray;
        }
    }
}
