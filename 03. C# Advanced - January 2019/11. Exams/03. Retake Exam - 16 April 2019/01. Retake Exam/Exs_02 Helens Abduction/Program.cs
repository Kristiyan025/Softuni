using System;

namespace Exs_02_Helens_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n][];
            int pi =0, pj =0;
            for (int i = 0; i < n; i++)
            {
                matrix[i] =  Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'P')
                    {
                        pi = i;
                        pj = j;
                        matrix[pi][pj] = '-';
                    }
                }
            }

            while (e!=0)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string first = commands[0];
                int si = int.Parse(commands[1]);
                int sj = int.Parse(commands[2]);
                matrix[si][sj] = 'S';
                e--;
                
                if (first == "up")
                {
                    if (pi != 0) pi--;
                }
                else if (first == "down")
                {
                    if (pi != n - 1) pi++;
                }
                else if (first == "left")
                {
                    if (pj != 0) pj--;
                }
                else
                {
                    if (pj != n - 1) pj++;
                }

                if (matrix[pi][pj] == 'S')
                {
                    e -= 2;
                    if (e <= 0)
                    {
                        matrix[pi][pj] = 'X';
                        Console.WriteLine($"Paris died at {pi};{pj}.");
                        break;
                    }
                    else
                    {
                        matrix[pi][pj] = '-';
                    }   
                }
                else if (matrix[pi][pj] == 'H')
                {
                    matrix[pi][pj] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {e}");
                    break;
                }

                if (e <= 0)
                {
                    matrix[pi][pj] = 'X';
                    Console.WriteLine($"Paris died at {pi};{pj}.");
                    break;
                }
            }
            
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }

        }
    }
}
