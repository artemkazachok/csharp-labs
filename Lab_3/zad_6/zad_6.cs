Int32 a = 0;
do
{
    Console.Write("Введите 1 натуральное число: ");
    a = Int32.Parse(Console.ReadLine());
    if(a <= 0)
    {
        Console.WriteLine("Натуральное число должно быть больше 0");
    }
} while (a <= 0);
Int32 b = 0;
do
{
    Console.Write("Введите 2 натуральное число: ");
    b = Int32.Parse(Console.ReadLine());
    if (b <= 0)
    {
        Console.WriteLine("Натуральное число должно быть больше 0");
    }
} while (b <= 0);
bool check = true;
Int32 NOK = 0;
Int32 sumA = a;
while(check)
{
    if(sumA % b == 0 && sumA % a == 0)
    {

        NOK = sumA;
        check = false;
    }
    else
    {
        sumA += a;
    }
}
Console.WriteLine($"Наименьшее общее кратное: {NOK}");