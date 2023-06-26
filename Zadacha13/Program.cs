// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine($"Программа выдаст третью цифру из заданного целого числа введенного Вами ");
Console.WriteLine($"");
Console.Write($"Введите целое число: ");

int num = int.Parse(Console.ReadLine());

int power = 10; //для определения порядка числа
int s = num; // Временная переменная для цикла
if (num < 100)
    {
        Console.WriteLine($"Число должно быть не меньше 100 ");
        Console.Write($"Запустите программу еще раз. ");
        return;
    }

while ( s >=10)
{
    s = s/10;
    power = power*10;
}
//Console.WriteLine($"{power}");
Console.WriteLine (" ");
Console.WriteLine ($"Третья цифра -> {num/(power/1000)-(num/(power/100))*10} ");
Console.WriteLine (" ");