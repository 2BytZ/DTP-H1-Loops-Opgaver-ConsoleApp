namespace DTP_Loops_Extract_stringM_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "##abc##def";
            Console.WriteLine(ExtractM(input));
        }
        static string ExtractM (string input)
        {
            int startIndex = input.IndexOf("##");
            if (startIndex == 0)
            {
                startIndex += 2;
            }
            int endIndex = input.LastIndexOf("##");
            if (startIndex >= endIndex)
            {
                return "";
            }
            string output = input.Substring(Math.Abs(startIndex), Math.Abs(endIndex));
            return output.Replace("##", "");

        }
    }
}
