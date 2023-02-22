// ЗАдача 2 Узнать сумму массива. 
// Сколько операций необходимо чтобы узнать сумму массива
// [4,5,3,1,2]
// Количество операций O(n)
// Сортировка [1,2,3,4,5] = O(n * log n)
// ((5 + 1)/2) * 5 = O(1) сумма арифметической прогрессии 
// n < n * log + 1



int n = 5;
int[] array = new int[n];
for (int i = 0; i < 5; i++)
    array [i] = Convert.ToInt32(Console.ReadLine()!);// заполняем числами
Console.WriteLine("[" + string.Join(", ", array) + "]");


// n < n * log + 1
int summ = 0;
for (int i = 0; i < n; i++)
    summ += array[i]; 
Console.WriteLine(summ);
// Затраченое время O(n)