int[] R = new int[9];
Random rand = new Random();
for(int i = 0; i < 9; i++)
{
    R[i] = rand.Next(0, 1000);
}
int index_max = -1;
for (int i = 0; i < 9; i++)
{ 
    if (R[i] % 2 != 0)
    {
        index_max = i;
        break;
    }
}
if(index_max == -1)
{
    Console.WriteLine("Нет нечетного числа!");
    return;
}
for (int i = index_max + 1; i < 9;i++)
{
    if (R[i] % 2 != 0 && R[i] > R[index_max])
    {
        index_max = i;
    }
}
Console.WriteLine($"Наибольшее нечетное число: {R[index_max]}\nЕго индекс: {index_max}");
