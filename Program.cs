namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int gameAttempts = 0;

            while (true)
            {
                Console.Clear();
                int randNumber = random.Next(1, 1000);
                int attempts = 0;
                gameAttempts++;

                Console.WriteLine($"Игра {gameAttempts}");
                Console.WriteLine("Было загадано число от 1 до 1000, угадай его");
                Console.WriteLine("Введите команду или текст (/restart для перезапуска, /exit для выхода):");

                while (true)
                {
                    Console.WriteLine("Введите число или команду");
                    string input = Console.ReadLine();  
                    
                    try
                    {
                        attempts++;

                        if (input == "/restart")
                        {
                            break;
                        }
                        else if (input == "/exit")
                        {
                            Console.Clear();
                            Console.WriteLine($"Игра {gameAttempts} окончена");
                            return;
                        }

                        if (!int.TryParse(input, out int guess))
                        {
                            throw new FormatException("Получены некорректные данные, введи целое число или команду!");
                        }

                        if (guess > randNumber)
                        {
                            Console.WriteLine("Введеное вами число больше загаданного!");
                        }
                        else if (guess < randNumber)
                        {
                            Console.WriteLine("Введеное вами число меньше загаданного!");
                        }
                        else
                        {
                            Console.WriteLine("Вы угадали число с " + attempts + " попытки:");
                        }
                        
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    }
                }

                }
            }

        }
    }
