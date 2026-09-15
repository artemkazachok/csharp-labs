static class all_zad
{
    public static void Run()
    {
        Int32 x;
        do
        {
            Console.WriteLine("Какое задание запустить: ");
            x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                    break;
                case 1:
                    zad1.Run();
                    break;
                case 2:
                    zad2.Run();
                    break;
                case 3:
                    zad3.Run();
                    break;
                case 4:
                    zad4.Run();
                    break;
                default:
                    Console.WriteLine("Нет такого задания!");
                    break;
            }
        } while (x != 0);
    }
}