// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int[] abc = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"input {i + 1} = ");
    abc[i] = int.Parse(Console.ReadLine());
}
Array.Sort(abc);
Console.WriteLine($"max = {abc[2]}, ave = {abc[1]}, min = {abc[0]}");
