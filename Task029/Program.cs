// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Введите последовательно восемь чисел, каждое с новой строки: ");
int []array = new int[8];

for (int i = 0;i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
