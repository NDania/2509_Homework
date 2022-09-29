// Выведите на экран единственное целое число – номер Пети в шеренге учеников.
Console.Clear();
Console.WriteLine("Введите количество учеников: ");
int n = Convert.ToInt32(Console.ReadLine());
int []array = new int[n];
int i = 0;
Console.WriteLine("Введите рост учеников в сантиметрах в порядке невозрастания, каждого с новой строки: "); 
for (i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост Пети в см: ");
int m = Convert.ToInt32(Console.ReadLine());

for(i = n-1; i >= 0; i--)
    if(m > array[i] && m <= array[i-1])
    {
    int y = i+1;
    Console.WriteLine("Порядковый номер Пети будет = " + y);
    }


 
 

