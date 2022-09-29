// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени: ");
int b = Convert.ToInt32(Console.ReadLine());
int a1 = a;
for(int i = 1; i < b; i ++)
    a1 = a1 * a;
Console.WriteLine(a1);
