int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array [i] = Convert.ToInt32(Console.ReadLine()!);// заполняем числами
//Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("[" + string.Join(", ", array) + "]");

// // Задача 1 сколько времени нужно на поиск элемента под номером [3]
// Console.WriteLine(array[3]);
// // Сложность алгоритма O(1)

// ЗАдача 2 Узнать сумму массива. 
// Сколько операций необходимо чтобы узнать сумму массива
// [4,5,3,1,2]
