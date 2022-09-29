// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] a = new int[n];
int b = 0;
for(int i = 0; i < a.Length; i ++)
{
    a[i] = n % 10;
    b = b + a[i];
    n = n / 10;
}
Console.WriteLine(b);