namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loop");
            int loop = 10;
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Loop" + i);
                Console.Beep();
            }
        }
    }
}
