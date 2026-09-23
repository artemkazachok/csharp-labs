//ÂÂÎÄ ÈÍÔÎĞÌÀÖÈÈ
Console.WriteLine("Ââåäèòå ïîğÿäîê ìàòğèöû: ");
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int[,] mas = new int[n, n];

//ÈÍÈÖÈÀËÈÇÀÖÈß
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mas[i, j] = rand.Next(-100, 100);
    }
}

//ÂÛÂÎÄ ÏÅĞÂÎÍÀ×ÀËÜÍÎÃÎ ÌÀÑÑÈÂÀ
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine('\n');
}

int[] strok = new int[n]; // ÑÎÇÄÀÍÈÅ ÎÒÄÅËÜÍÛÕ ÏÅĞÌÅÍÍÛÕ ÄËß Ñ×ÅÒÀ ÑÓÌÌÛ
//ÏÎÈÑÊ ÎÏĞÅÄÅË¨ÍÍÛÕ ×ÈÑÅË
for(int j = 0; j < n; j++)
{
    for(int i = 0; i < n; i++)
    {
        if (mas[i,j] % 2 != 0 && mas[i,j] < 0)
        {
            strok[j] += Math.Abs(mas[i, j]); //ÑËÎÆÅÍÈÅ ÎÒĞÈÖÀÒÅËÜÍÛÕ ×ÈÑÅË
        }
    }
}

//ÑÎĞÒÈĞÎÂÊÀ ÏÎ ÑÓÌÌÅ
for(int p = 0; p < n-1; p++)
{
    for (int i = 0; i < n - 1 - p; i++)
    {
        if (strok[i] > strok[i + 1])
        {
            int t;
            int d = strok[i];
            strok[i] = strok[i + 1];
            strok[i + 1] = d;
            for (int j = 0; j < n; j++)
            {
                t = mas[j, i];
                mas[j, i] = mas[j, i + 1];
                mas[j, i + 1] = t;
            }
        }
    }

}
//ÂÛÂÎÄ ÈÇÌÅÍÅÍÍÎÃÎ ÌÀÑÑÈÂÀ
Console.WriteLine('\n');
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine('\n');
}

//ÂÛÂÎÄ ÑÓÌÌ ÕÀĞÀÊÒÅĞÈÑÒÈÊ
for(int i = 0; i < n; i++)
{
    Console.Write($"Çíà÷åíèå {i + 1} ñòîëáöà ğàâíà: {strok[i]}\n");
}

//ÏÎÈÑÊ ÎÒĞÈÖÀÒÅËÜÍÎÃÎ ×ÈÑËÀ Â ÑÒÎËÁÖÅ
bool[] check_negative = new bool[n];
for(int j = 0; j < n; j++)
{
    for(int i = 0; i < n; i++)
    {
        if (mas[i,j] < 0)
        {
            check_negative[j] = true;
            break;
        }
    }
}

//ÑËÎÆÅÍÈÅ ÂÑÅÕ ×ÈÑÅË ÑÒÎËÁÖÀ 
Console.WriteLine("");
int[] sum = new int[n];
for (int j = 0; j < n; j++)
{
    if (check_negative[j])
    {
        for(int i = 0; i < n; i++)
        {
            sum[j] += mas[i, j];
        }
        Console.WriteLine($"Cóììà ñòîëáöà {j+1} ó êîòîğîãî åñòü îòğèöàòåëüíîå ÷èñëî: {sum[j]}");
    }
}