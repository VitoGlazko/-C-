//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.WriteLine("Введите первое начальное число :");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе начальное число :");
int num1 = int.Parse(Console.ReadLine()!);

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int num, int num1, int sum)
{
    if (num > num1) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {num} до {num1}: {sum}"); 
        return;
    }
    sum = sum + (num++);
    GapNumberSum(num, num1, sum);
}

GapNumberSum(num, num1, 0);

