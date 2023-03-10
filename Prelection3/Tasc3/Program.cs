
// O(n^2)
// Время работы программы O(n^2)


// int n = Convert.ToInt32(Console.ReadLine()); // Вводим число 
// int[, ] matrix = new int[n, n];
// for(int i = 1; i <= n; i++)
// {
//     for(int j= 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t"); // Форматируем Выводим на экран красиво
//     }
//     Console.WriteLine();
// }

// O(n^2 / 2)
int n = Convert.ToInt32(Console.ReadLine()); // Вводим число 
int[, ] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for(int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}