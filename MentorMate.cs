namespace MentorMate
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FirstLine(n);
            FirstHalfLoop(n);
            SecondHalfLoop(n);
            LastLine(n);
            Console.ReadKey();
        }
        /// <summary>
        /// Method that writes our first line.
        /// </summary>
        /// <param name="n">Param given from the user, that is needed for the details of the picture.</param>
        public static void FirstLine(int n)
        {
            Console.WriteLine("{0}{1}{0}{1}{0}{0}{1}{0}{1}{0}",
               new string('-', n),
               new string('*', n));
        }
        /// <summary>
        /// For loop, that writes half of the picture.
        /// </summary>
        /// <param name="n">Param given from the user, that is needed for the details of the picture.</param>
        public static void FirstHalfLoop(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("{0}{1}{2}{1}{0}{0}{1}{2}{1}{0}",
                    new string('-', (n - 1) - i),
                    new string('*', (n + 2) + 2 * i),
                    new string('-', (n - 2) - 2 * i));
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Second for loop, that writes the second half of the picture.
        /// </summary>
        /// <param name="n">Param given from the user, that is needed for the details of the picture.</param>
        public static void SecondHalfLoop(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{3}{2}{3}{1}{0}{0}{1}{3}{2}{3}{1}{0}",
                    new string('-', n / 2 - i),
                    new string('*', n),
                    new string('*', (2 * n - 1) - 2 * i),
                    new string('-', 1 + 2 * i));
            }
        }
        /// <summary>
        /// Method that writes our last line.
        /// </summary>
        /// <param name="n">Param given from the user, that is needed for the details of the picture.</param>
        public static void LastLine(int n)
        {
            Console.WriteLine("{1}{0}{1}{0}{1}{1}{0}{1}{0}{1}",
               new string('-', n),
               new string('*', n));
        }
    }
}
