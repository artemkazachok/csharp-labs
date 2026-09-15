Double A = 0;
do
{
    Console.Write("Введите A: ");
    A = Double.Parse(Console.ReadLine());
    if (A <= 1)
    {
        Console.WriteLine("A должен быть больше 1");
    }
} while (A <= 1);
Double sum = 0;
Double N = 0;
while(sum <= A)
{
    N++;
    sum += 1.0 / N;
}
Console.WriteLine($"Кол-во N: {N} \nСумма: {sum}");

