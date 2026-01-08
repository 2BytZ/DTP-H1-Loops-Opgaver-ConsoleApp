namespace DTP_Loops_two_7s_beside_each_other_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] array =
            {
                1,2,5,6,7,7,7,8,7,7,7,7,10,20,303
            };

            Console.WriteLine(Two7sNextToEachOther(array));
        }
        static int Two7sNextToEachOther(float[] array)
        {
            int previousNum = 0;
            int i = 0; // 7 count
            foreach (int item in array)
            {
                int currentNum = item;
                if (currentNum == 7 && previousNum == 7)
                {
                    i++;
                }
                previousNum = currentNum;
            }
            return i;
        }
    }
}
