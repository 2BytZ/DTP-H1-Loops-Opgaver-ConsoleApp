namespace DTP_Loops_ConsoleApp_Multiplication_table
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                table(i);
                Console.Write("\n");
            }
        }
        static void table(int mult)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i * mult} ");
            }
        }
    }
}
