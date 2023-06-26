// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Clear();

Console.WriteLine($"Программа определит по веденному номеру дня недели, является ли этот день выходным ");
Console.WriteLine($"");
Console.Write($"Введите номер дня недели: ");

int numDay = int.Parse(Console.ReadLine());

if (numDay < 1 || numDay > 7)
    {
        Console.WriteLine($"В неделе семь дней.");
        Console.Write($"Запустите программу еще раз. И введите от 1 до 7");
        return;
    }
if (numDay == 6 || numDay == 7)
    {
        switch (numDay)
        {
            case (6):
                Console.Write($"Это СУББОТА - выходной день ");
                break;
            
            case (7):       
                Console.Write($"Это ВОСКРЕСЕНИЕ - выходной день ");
                break;
            
        }
        
    return;
    }

Console.Write($"Работаем. До выходных {6-numDay} дн. ");