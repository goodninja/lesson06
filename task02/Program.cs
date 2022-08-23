// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[,] coefficient = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coefficient.GetLength(0); i++)
    {
        Console.Write($"Установите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coefficient.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент для k: ");
            else Console.Write($"Введите коэффициент для b: ");
            coefficient[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coefficient)
{
    crossPoint[0] = (coefficient[1, 1] - coefficient[0, 1]) / (coefficient[0, 0] - coefficient[1, 0]);
    crossPoint[1] = crossPoint[0] * coefficient[0, 0] + coefficient[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coefficient)
{
    if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] == coefficient[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coefficient[0, 0] == coefficient[1, 0] && coefficient[0, 1] != coefficient[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Decision(coefficient);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(coefficient);
