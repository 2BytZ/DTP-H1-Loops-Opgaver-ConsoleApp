namespace DTP_Loops_Draw_a_triangle_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Work smarter, not harder ;)
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            Console.Write(
                "         *\n" + 
                "        ***\n" + 
                "       *****\n" + 
                "      *******\n" + 
                "     *********\n" + 
                "    ***********\n" + 
                "   *************\n" + 
                "  ***************\n" + 
                " *****************\n" + 
                "*******************\n"
             );
        }
    }
}
