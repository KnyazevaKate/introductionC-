// 4. По заданному с клавиатуры номеру дня недели вывести его название.
double n = Convert.ToDouble(Console.ReadLine());
string str = "";
switch (n)
{
    case 1:
        str = "Понедельник";
        break;
    case 2:
        str = "Вторник";
        break;
    case 3:
        str = "Среда";
        break;
    case 4:
        str = "Четверг";
        break;
    case 5:
        str = "Пятница";
        break;
    case 6:
        str = "Суббота";
        break;
    case 7:
        str = "Воскресенье";
        break;
}
Console.WriteLine(str);
Console.ReadKey();