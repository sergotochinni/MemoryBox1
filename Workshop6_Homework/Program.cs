﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Без применения массива. 
/*
void CountNum(string num)
{   
    int sum = 0;
    int number = Convert.ToInt32(num);

    if (number is int) 
    {
        if (number > 0) 
        {
            Console.WriteLine("Your number, please: ");
            sum += number;
            CountNum(Console.ReadLine());
        }
        else 
        {
            Console.WriteLine("Number, please: ");
            CountNum(Console.ReadLine());
        }
    }
    else  Console.WriteLine($" .{sum}. ");
}

Console.WriteLine("Hello! I'll count all your numbers what are positive. When you get tired, write something else.");
string number = Console.ReadLine();
CountNum(number);
*/
/*
void CheckNum (string num)
{
    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        checked(number is int);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Thank you");
    }
}

CheckNum(Console.ReadLine());
*/

/*
void Fuck (string num)
{
    int sum = 0;
    var number = Convert.ToInt32(Console.ReadLine());
    if (number.GetType is int)
    {
        sum += num;
        Console.WriteLine("....");
    }
    else Console.WriteLine("Thank you");
}

God(Console.ReadLine());
*/

/*
void Something(string num)
{
    var number = num;
    if (number.GetType is int)
    {
        Console.WriteLine("...");
    }
    else Console.WriteLine("!!!!");
}

Something(Console.ReadLine());
*/

/*
void CheckNum (string num)
{
    int num = 0;
    while (num != "stop")
    {
        int number = Convert.ToInt32(num);
        if (number > 0)  
        {
            sum += number;
            Console.WriteLine("Input your number: ");
            string curnum = Console.ReadLine();
            CheckNum(curnum);
        }
        else
        {
            Console.WriteLine("Please, input next number: ");
            string curnum = Console.ReadLine();
            CheckNum(curnum);
        }
    }
    Console.WriteLine($"Thank you. The result is {sum}.");
}

Console.WriteLine("Hello! I'll count all positive numbers that you input. When you get tired just write 'stop': ");
string somenumber = Console.ReadLine();
CheckNum(somenumber);
*/


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



