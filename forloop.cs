namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 0;
            for (; ; )
            {
                Console.WriteLine("Rida number: " + i);
                i++;

                if (i == 11)
                {
                    break; 
                }
            }


        }
    }
    }

