// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Write("Введите число X: ");
        int X = int.Parse(Console.ReadLine());

Console.Write("Введите число Y: ");
        int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится в первой четверти");
}
else 
{
if (X < 0 && Y > 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится во второй четверти");
} 
else
{
if (X < 0 && Y < 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится в третьей четверти");
}    
else
{
   Console.WriteLine($"Точка X={X} Y={Y} находится в четвертой четверти"); 
}
}
}