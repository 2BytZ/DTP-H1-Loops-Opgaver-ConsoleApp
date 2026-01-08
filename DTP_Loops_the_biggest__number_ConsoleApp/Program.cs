namespace DTP_Loops_the_biggest__number_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =
            {
                1,
                2,
                5,
                2,
                15,
                34,
                3,
                -20,
                0
            };
            Console.WriteLine(GetBiggestNumberInArray(array));
        }
        static int GetBiggestNumberInArray(int[] array)
        {
            int largestNum = 0;
            foreach (int item in array)
            {
                if (item > largestNum)
                {
                    largestNum = item;
                }
            }
            return largestNum;
        }
    }
}
