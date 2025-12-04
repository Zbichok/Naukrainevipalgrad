namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой текст вывести? ");
            string message = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }

        }
    }
    }

