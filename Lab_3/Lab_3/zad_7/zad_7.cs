bool check = true;
double all_multi = 1;
double a = 0;
while(check)
{
    Console.Write("Введите число: ");
    a = Double.Parse(Console.ReadLine());
    if (a > 0)
    {
        all_multi *= a;
    }
    else
    {
        check = false;
    }
}
Console.WriteLine($"Произведение всех положительных чисел: {all_multi}");