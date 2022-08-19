//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while (number>0)
{
    
    summa = summa + number % 10; // Остаток от деления (%)
    number = number / 10; // деление числа типа int - остаток не учитывается 
   
}
Console.WriteLine(summa);

// 452 -> 11
// 82 -> 10
// 9012 -> 12