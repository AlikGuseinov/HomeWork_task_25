// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача №25 ");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
ToDegree(a,b);

void ToDegree(int a, int b)
{
int Final = 1;

    for (int count = 0; count < b; count++)

    {
    
    Final = Final*a;

    }
    Console.WriteLine("Число "+a+" в степени "+b+" = "+Final);

}