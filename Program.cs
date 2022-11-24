//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Решение:

/*int NatStepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {result = result * a;}
    return result;
}
Console.WriteLine("Введите число А: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());
int stepen = NatStepen(num_a, num_b);
if (num_a > 0 && num_b > 0){
    Console.WriteLine($"Результат возведения числа {num_a} в степень {num_b} -> {stepen}");}
else Console.WriteLine("Введите два положительныхчисла.");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Решение:





//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//Решение:

/*int [] BuildArray(int min, int max)
{
    int [] array = new int [8];
    for(int i = 0; i < 8; i ++) 
    {array[i] = new Random().Next(min,max+1);}
    return array;
}
void ShowArray(int [] array)
{
    for(int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
Console.WriteLine("Введите нижнюю границу диапазона массива: ");
int digit_from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона массива: ");
int digit_to = Convert.ToInt32(Console.ReadLine());
int [] user_array = BuildArray(digit_from, digit_to);
ShowArray(user_array);
*/