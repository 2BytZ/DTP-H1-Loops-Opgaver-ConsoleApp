namespace DTP_Loops_Three_increasing_adjacent_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] array = { 7, 3, 5, 8, 9, 3, 1, 4 };
            Console.WriteLine(ThreeIncreasingAdjacent(array));
        }
        static bool ThreeIncreasingAdjacent(float[] array)
        {
            for (int i = 0; i < array.Length-2; i++)
            {
                if (array[i + 1] == array[i] + 1 && array[i + 2] == array[i + 1] + 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
