//  Доробити таблицю множення - зробити гарний вивід в консоль.

for (int i = 1; i <= 10; i++)

{
    Console.WriteLine();
    for (int j = 1; j < 6; j++)

    {
        Console.Write($"{j} * {i} = {i * j}");
        if (j != 5)
            Console.Write("\t");
    }
}

Console.WriteLine();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine();
    for (int j = 6; j <= 10; j++)
    {
        Console.Write($"{j} * {i} = {i * j}");
        Console.Write("\t");
    }
}