namespace Exs_02_Tron_Racers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n][];
            int fi = -1, fj = -1, si = -1, sj = -1;
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new char[n];
                var row = Console.ReadLine().ToCharArray();
                matrix[i] = row;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 'f')
                    {
                        fi = i;
                        fj = j;
                    }
                    if (matrix[i][j] == 's')
                    {
                        si = i;
                        sj = j;
                    }
                }
            }
            //Console.WriteLine(fi);
            //Console.WriteLine(fj);
            //Console.WriteLine(si);
            //Console.WriteLine(sj);
            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string first = commands[0];
                string second = commands[1];

                
                if(first == "up")
                {
                    if(fi != 0) fi--;
                    else fi = n - 1;
                }
                else if(first == "down")
                {
                    if (fi != n - 1) fi++;
                    else fi = 0;
                }
                else if (first == "left")
                {
                    if (fj != 0) fj--;
                    else fj = n - 1;
                }
                else
                {
                    if (fj != n - 1) fj++;
                    else fj = 0;
                }

                if (matrix[fi][fj] == 's')
                {
                    matrix[fi][fj] = 'x';
                    break;
                }
                matrix[fi][fj] = 'f';

                if (second == "up")
                {
                    if (si != 0) si--;
                    else si = n - 1;
                }
                else if (second == "down")
                {
                    if (si != n - 1) si++;
                    else si = 0;
                }
                else if (second == "left")
                {
                    if (sj != 0) sj--;
                    else sj = n - 1;
                }
                else
                {
                    if (sj != n - 1) sj++;
                    else sj = 0;
                }

                if (matrix[si][sj] == 'f')
                {
                    matrix[si][sj] = 'x';
                    break;
                }
                
                matrix[si][sj] = 's';
                //Console.WriteLine(string.Join(Environment.NewLine,matrix
                //    .Select(x=> string.Join("", x))));
                //Console.WriteLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine,matrix
                .Select(x=> string.Join("", x))));

        }
    }
}
