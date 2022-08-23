// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите число М (= количество чисел): ");

int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNum = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        massiveNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] massiveNum)
{
    int count = 0;
    for (int i = 0; i < massiveNum.Length; i++)
    {
        if (massiveNum[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Чисел больше 0 -> {Comparison(massiveNum)} ");
