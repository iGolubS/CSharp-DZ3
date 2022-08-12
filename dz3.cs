// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет    12821 -> да    23432 -> да

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// while (num<10000 && num<99999)
// {
//     Console.Write("Вы ввели не пятизначное число, исправьте: ");
//     int num2=Convert.ToInt32(Console.ReadLine());
//     if (num2>9999 && num2<100000)
//     {
//         num=num2;
//     }
// }
// if (num/10000==num%10 && num/1000%10==num/10%10)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
// else
// {
//     Console.WriteLine($"Число {num} не является палиндромом");
// }



// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве.    A (3,6,8); B (2,1,-7), -> 15.84    A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.Write("Введите координату x1: ");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2=Convert.ToInt32(Console.ReadLine());
// double dis = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
// Console.WriteLine($"dis={dis:f2}");



// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27    5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N, я выведу таблицу кубов чисел от 1 до N: ");
int N=Convert.ToInt32(Console.ReadLine());
int ind = 1;
if (N>0)
{
    while (ind<=N)
    {
        Console.Write(Math.Pow(ind,3) + ", ");
        ind=ind+1;
    }
}
else
{
    while (ind>=N)
    {
        Console.Write(Math.Pow(ind,3) + ", ");
        ind=ind-1;
    }
}