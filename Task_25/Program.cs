﻿// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i<B; i++) 
{
    result = result * A;
    
}
Console.WriteLine(result);
//double A_sqr = Math.Pow(A,B); - Если делить буз цикла
//Console.WriteLine("Результат: "+ A_sqr); - Вывод для варианта без цикла


// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16