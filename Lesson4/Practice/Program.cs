namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
      //Задача 1: Функция сложения
      def add(a, b):
          return a + b

      int result = Sum(5, 2);
      Console.WriteLine(result);

      //Задача 2: Функция проверки четности
      def is_even(number):
          return number % 2 == 0

      print(is_even(4));
      print(is_even(7));

      //Задача 3: Функция переворота строки
      def reverse_string(s):
          return s[::-1]
        
      print(reverse_string("hello"));

      //Задача 4: Функция поиска максимального элемента в массиве
      def find_max(arr):
          return max(arr)

      print(find_max([1, 5, 2, 9, 3]));

      //Задача 5: Функция вычисления зарплаты за год
      def factorial(sallary):
          return sallary * 12

      monthly_pay = 5000;
      annual_pay = calculate_annual_salary(monthly_pay);
      print(f"The annual salary is: {annual_pay}");

      //Задача 6*: Функция конвертации температур
      def celsius_to_fahrenheit(celsius):
          return celsius * 9/5 + 32

      print(celsius_to_fahrenheit(25));

      //Задача 7*: Функция поиска количества гласных в строке
      def count_vowels(s):
          vowels = "аиоуеэАИОУЕЭ"
          return sum(1 for char in s if char in vowels)

      print(count_vowels("Гласные"));

      //Задача 8*: Функция для опредления сложности взлома 4х значного пароля

      def generate_password(passtohack):
          count = 0 
          for x in range(10):
              for y in range(10):
                  for z in range(10):
                    for h in range(10):
                        count += 1 
                        generatedpass = str(x) + str(y) + str(z) + str(h)
                            if generatedpass  == passtohack:
                                print("Ура! Вы взломали пароль теперь вы хакер")
                                return count

    password = "1234";
    attempts = generate_password(password);
    print(f"Потребовалось {attempts} попыток для взлома пароля {password}");

    //Написать рекурсивную функцию для вычисления факториала числа.

    static int Factorial(int n)
    {
        if (n == 1) return 1;
        return n * Factorial(n - 1);
    }
    Console.WriteLine(Factorial(3));

    //Рекурсивно находить n-ое число Фибоначчи.
    def fibonacci_recursive(n):

    if n < 0:
    return None;
  elif n <= 1:
    return n  # Базовый случай: F(0) = 0, F(1) = 1;
  else:
    return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2);

    print(fibonacci_recursive(3));

    //Создать рекурсивную функцию для обращения строки.
    def reverse_string_recursive(s):

    if len(s) == 0:
    return s;
  else:
    return reverse_string_recursive(s[1:]) + s[0];

    print(reverse_string_recursive("hello"));

    //Написать рекурсивную функцию для нахождения суммы элементов массива.

    def sum_array_recursive(arr):

    if not arr:
    return 0;
  else:
    return arr[0] + sum_array_recursive(arr[1:]);

    print(sum_array_recursive([1, 2, 3, 4, 5]));

    //Реализовать алгоритм Евклида для нахождения НОД двух чисел с использованием рекурсии.
    
    def gcd_recursive(a, b):

    if b == 0:
    return a;
  else:
    return gcd_recursive(b, a % b);

    print(gcd_recursive(0, 5));

    //Создать рекурсивную функцию, которая проверяет, является ли строка палиндромом.

    def is_palindrome_recursive(s):

    if len(s) <= 1:
    return True;
  elif s[0] != s[-1]:
    return False;
  else:
    return is_palindrome_recursive(s[1:-1]);

    print(is_palindrome_recursive("madam"));


    }
}