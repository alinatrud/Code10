﻿namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
         // 1. Сумма элементов массива
         int[] numbers = { 5, 2, 7, 3, 2, 9 };
         int result = 0;

         foreach (int num in numbers)
         {
             result += num;
         }

         System.Console.WriteLine(result);

         // 2. Поиск максимального элемента

         int[] numbers = { 5, 2, 7, 3, 2, 9 };
         int result = int.MinValue;

         Array.Sort(numbers);
         result = numbers[numbers.Length - 1];
         System.Console.WriteLine(numbers[numbers.Length - 1]);

         Array.Reverse(numbers);
         result = numbers[0];

         Math.Max(numbers, numbers.Length);

         foreach (int num in numbers)
         {
             if (result < num) {
                 result = num;
             }
         }

         System.Console.WriteLine(result);

         int result;

         // 3. Обратный порядок массива

         int[] numbers = { 5, 2, 7, 3, 2, 9 };

         Array.Reverse(numbers);

         foreach (int num in numbers)
         {
             System.Console.WriteLine(num);
         }

         //4. Четные числа в массиве

         int[] numbers = { 5, 2, 7, 3, 2, 9, 4, 6 };

         foreach (int num in numbers)
         {
             if (num % 2 == 0) {
                 System.Console.WriteLine(num);
             }
         }

         //5. Подсчет отрицательных чисел

         int[] numbers = { 5, 2, -7, -3, 2, -9, 4, -6 };

         foreach (int num in numbers) {

         }

         //6. Линейный поиск
         int[] myArray = { 5, 10, 15, 20, 25, 30 };

         Console.WriteLine("Введите число для поиска:");
         string input = Console.ReadLine();

         if (int.TryParse(input, out int target))
         {
           int index = Search(myArray, target);
         }

         //7. Вывод элементов на нечетных позициях
         int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80 };

         Console.WriteLine("Элементы массива на нечетных позициях:");

         for (int i = 1; i < myArray.Length; i += 2)
         {
            Console.WriteLine("Индекс: " + i + ", Значение: " + myArray[i]);
         }
         
         //8. Минимальное и максимальное значения
         int[] numbers = { 5, 2, 7, 3, 2, 9 };
         
          int maxResult = int.MinValue;
         Array.Sort(numbers);
         maxResult = numbers[numbers.Length - 1];
         Console.WriteLine("Максимум (после сортировки): " + numbers[numbers.Length - 1]);
         Array.Reverse(numbers);

         int minResult = int.MaxValue;

          foreach (int num in numbers)
         {
            if (minResult > num)
            {
                minResult = num;
            }
         }

         Console.WriteLine("Минимум: " + minResult);
         Console.WriteLine("Максимум: " + maxResult);
         



    }
}