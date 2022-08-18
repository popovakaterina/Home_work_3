// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
double A_sqr = Math.Pow(A,B);
Console.WriteLine("Результат: "+ A_sqr);
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16