// Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = 3;
int n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0, 10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты строки:");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты столба:");
 int b = Convert.ToInt32(Console.ReadLine());
 
 if (a>m && b>n)
 Console.WriteLine("Такого числа нет!");
 else
 {
 object c = array.GetValue (a, b);
 Console.WriteLine(c);
 }