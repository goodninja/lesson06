// Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами 


Console.WriteLine("Чтобы сгенерировать двумерный массив со случайными числами ->");
try
{
    Console.WriteLine("Введите высоту двумерного массива:");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину двумерного массива:");
    int k = int.Parse(Console.ReadLine());
    Console.WriteLine();
    ArrayFilling(n, k);
}
catch
{
    Console.WriteLine("Вы ввели данные в неправильном формате!");
}


static void ArrayFilling(int n, int k)
{
    var array = new int[n, k];
    var random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Массив сгенерирован");
}