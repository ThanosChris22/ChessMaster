using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_2
{
    //Description:

    //Write an algorithm which will appears the characters of the word "CHESSMASTER" in a two-dimensional array and dimensions the length of this word. 
    //Constraints: An line can only contains one character and cannot there be in the left diagonal.The print must contain all the information of attached photo.

    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[11, 11];
            char[] chess = new char[11] { 'C', 'H', 'E', 'S', 'S', 'M', 'A', 'S', 'T', 'E', 'R' };
            char[] abc = new char[11] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' };
            int[] spot = new int[11];
            int rand;
            Random random = new Random();

            for (int i = 0; i < 11; i++)
            {
                rand = random.Next(11);
                for (int j = 0; j < 11; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 'X';
                    }
                    do
                    {
                        if (array[i, rand] == 'X')
                            rand = random.Next(11);
                        array[i, rand] = chess[i];
                    } while (array[i, rand] == 'X');
                    spot[i] = rand;
                }
            }
            Console.WriteLine("\n\n");
            for (int i = 11; i > 0; i--)
            {
                Console.WriteLine("\t\t--------------------------------------------");
                Console.Write($"\t{i}\t");
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"| {array[11 - i, j]} ");
                }
                Console.Write($"|\t{chess[11 - i]}: ({abc[spot[11 - i]]},{11 - i})");
                Console.WriteLine();
            }
            Console.WriteLine("\t\t--------------------------------------------");
            Console.Write($"\t\t");
            foreach (char i in abc)
            {
                Console.Write($"  {i} ");
            }

            Console.ReadKey();
        }
    }
}
