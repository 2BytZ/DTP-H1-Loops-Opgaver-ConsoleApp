namespace DTP_Loops_Sum_and_average_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = -10;
            int num2 = 0;
            GetSumAndAverage(num1, num2);

        }
        static void GetSumAndAverage(int num1, int num2)
        {
            List<float> findAverage = new List<float>();
            float sumOfIntegers = 0;
            for (int i = num1; i <= num2; i++)
            {
                sumOfIntegers += i;
            }
            float average = sumOfIntegers / (num2 - num1+1);
            Console.WriteLine($"Sum: {sumOfIntegers}, Average: {average}");
        }
    }
}
