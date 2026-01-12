namespace DTP_Loops_Full_sequence_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create array to hold chars of the alphabet
            char[] alphabet =
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
            };
            string input = "or";
            // split up and translate input to char values
            char[] inputChar = input.ToCharArray();
            //check if values in input is actually a part of the alphabet
            if (!alphabet.Contains(inputChar[0]) || !alphabet.Contains(inputChar[1]))
                Console.WriteLine("One or more chars in input is not in the alphabet");
            else
                LetterSequence(alphabet,inputChar);
            Console.WriteLine();
        }
        static void LetterSequence(char[] letters, char[] inputChar)
        {
            Dictionary<int, string> lowercaseAlphabet = new Dictionary<int, string>
                {
                    {1, "a"}, {2, "b"}, {3, "c"}, {4, "d"}, {5, "e"}, {6, "f"}, {7, "g"}, {8, "h"}, {9, "i"}, {10, "j"}, {11, "k"}, {12, "l"}, {13, "m"}, {14, "n"}, {15, "o"}, {16, "p"}, {17, "q"}, {18, "r"}, {19, "s"}, {20, "t"}, {21, "u"}, {22, "v"}, {23, "w"}, {24, "x"}, {25, "y"}, {26, "z"}
                };

            for (int i = inputChar[0]; i <= inputChar[1]; i++)
            {
                int j = i - 96;
                Console.Write(lowercaseAlphabet[j]); 
            }
            return;
        }
    }
}
