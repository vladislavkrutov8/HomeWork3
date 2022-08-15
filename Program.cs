int number = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"Введите число {number}");


if (number % 7 == 0 && number % 23 == 0)
{
Console.WriteLine("Введенное число кратно и 7 и 23");

}
else
{
    Console.WriteLine("Введенное число не кратно 7 или 23");
}

