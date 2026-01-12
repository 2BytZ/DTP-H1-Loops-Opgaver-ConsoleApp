using System.Numerics;

namespace DTP_Loops_find_prime_numbers_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 30;
            FindPrimeNumbersUpToInt(number);
        }
        static void FindPrimeNumbersUpToInt(int number)
        {
            if (number < 2)
            {
                Console.WriteLine($"There are no prime numbers preceeding the number {number}.");
            }
            else
            {
                List<int> range = new List<int>(number);
                for (int i = 2; i <= number; i++)
                {
                    range.Add(i);
                }
                Console.WriteLine($"Added all numbers from 2-{number} to range"); // Debug msg
                List<int> primeNumbers = new List<int>();
                primeNumbers.Add(range[0]);
                Console.WriteLine($"Added {range[0]} to primeNumbers list.");// Debug msg
                range.Remove(range[0]);
                Console.WriteLine($"Removed {primeNumbers[0]} from range list.");// Debug msg
                for (int primeNum = 0; primeNum < primeNumbers.Count;)
                {
                    for (int numIndex = 0; numIndex < range.Count;)
                    {
                            if (range[numIndex] % primeNumbers[primeNum] == 0)
                            {
                                Console.WriteLine($"Removed {range[numIndex]} from range list."); // Debug msg
                                range.Remove(range[numIndex]);
                                Console.WriteLine($"Decremented numIndex by 1!");// Debug msg
                                numIndex--;
                                Console.WriteLine($"numIndex is now {numIndex}."); // Debug msg
                            }
                            else
                            {
                                numIndex++;
                                Console.WriteLine($"Increased numIndex by 1!"); // Debug msg
                                Console.WriteLine($"numIndex is now {numIndex}."); // Debug msg
                            }
                            
                    }
                    if (range.Count == 0)
                        break;
                    primeNumbers.Add(range[0]);
                    Console.WriteLine($"Added {range[0]} to primeNumbers list.");// Debug msg
                    range.Remove(range[0]);
                    Console.WriteLine($"Removed {primeNumbers[0]} from range list.");// Debug msg
                    Console.WriteLine("Decreased numIndex by 1!");
                        //numIndex -= 1;
                        //Console.WriteLine($"numIndex is now {numIndex}!"); // Debug msg
                    primeNum++;
                    Console.WriteLine("Increased primeNum by 1!"); // Debug msg
                }
                foreach (int item in primeNumbers)
                {
                    Console.Write($"{item}, ");
                }
                Console.Write("\n");
            }
           
        }
    }
}
