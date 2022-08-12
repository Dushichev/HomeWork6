/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/

Console.WriteLine("введите длину последовательности");
int numbers = int.Parse(Console.ReadLine());
int[] arr = new int[numbers];

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("в веденной последовательности " + count + " чисел больше 0");

