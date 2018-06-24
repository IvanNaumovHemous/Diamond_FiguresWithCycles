using System;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            GetDrawing(size);
        }

        static void GetDrawing(int number)
        {
            int underscores = 0;
            int stars = 0;
            int middleUnderscores = 0;

            stars = number % 2 == 0 ? 2 : 1;
            underscores = (number - 1) / 2;
            middleUnderscores = stars;

            Console.WriteLine("{0}{1}{0}", new string('_', underscores), new string('*', stars));

            int rows = (number - 1) / 2;
            underscores--;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('_', underscores), new string('_', middleUnderscores));
                underscores--;
                middleUnderscores += 2;
            }

            underscores = 1;
            middleUnderscores -= 4;
            rows--;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('_', underscores), new string('_', middleUnderscores));
                underscores++;
                middleUnderscores -= 2;
            }

            stars = number % 2 == 0 ? 2 : 1;
            underscores = (number - 1) / 2;
            middleUnderscores = stars;

            Console.WriteLine("{0}{1}{0}", new string('_', underscores), new string('*', stars));
        }
    }
}
