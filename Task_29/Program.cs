// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
static int [] CreateArray (int number) // Ввод массива по элементу 
{
    int [] array = new int [number];
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array; 
}
static void WriteArray (int [] array) // Вывод массива
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write( array[i]+ " ");
    }
}
Console.Write("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(lenght);
WriteArray(array);
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]