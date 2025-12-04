namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("---------------------------------------");

            int summa = 0;

            for (int i = 1; i <= 10; i++)
            {
                summa += i; 
                Console.WriteLine("Summa on : " + summa);
            }

        }
    }
}
