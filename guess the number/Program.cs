namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Random random = new Random();
                int rand = random.Next(1, 1000);
                Console.WriteLine("Было загадано число от 1 до 1000, угадай его");
                int i = 0;
                
                while (true)
                {
                    i++;
                    int number = int.Parse(Console.ReadLine());
                    if (number > rand)
                    {
                        Console.WriteLine("Указанное число больше загаданного!");
                        Console.WriteLine("Кол-во попыток " + i + ":");
                    }
                    if (number < rand)
                    {
                        Console.WriteLine("Указанное  число меньше загаданного!");
                        Console.WriteLine("Кол-во попыток " + i + ":");
                    }
                    else if (number == rand)
                    {
                        Console.WriteLine("Вы угадали число с " + i + " попытки:");
                        Console.WriteLine("для перезапуска нажмите 1 для выхода нажмите 2");
                        int value = int.Parse(Console.ReadLine());
                        if (value == 1)
                        {
                            break;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

        }
    }
}