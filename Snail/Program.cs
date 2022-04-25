using System;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
              {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
               };
            int countI = 0;
            int countJ = 0;
            int countLenght = 0;
            int countCircle = 0;
            bool dontBreak = true;
            int[] r = new int[array.Length * array.Length];

            while (dontBreak)
            {
                // right
                while (countJ < (array.Length - countCircle) && dontBreak)
                {
                    r[countLenght] = array[countI][countJ];
                    countLenght++;
                    countJ++;
                }
                countJ--;
                countLenght--;

                if (countLenght >= array.Length * array.Length)
                {
                    dontBreak = false;
                }

                //down
                while (countI < (array.Length - countCircle) && dontBreak)
                {
                    r[countLenght] = array[countI][countJ];
                    countLenght++;
                    countI++;
                }
                if (countLenght >= array.Length * array.Length)
                {
                    dontBreak = false;
                }
                countI--;
                countLenght--;

                //left
                while (countJ > (0 + countCircle) && dontBreak)
                {
                    r[countLenght] = array[countI][countJ];
                    countLenght++;
                    countJ--;
                }
                if (countLenght >= array.Length * array.Length)
                {
                    dontBreak = false;
                }

                //up
                while (countI > (0 + countCircle) && dontBreak)
                {
                    r[countLenght] = array[countI][countJ];
                    countLenght++;
                    countI--;
                }
                countCircle++;
                countI++;
                countJ++;
                if (countLenght >= array.Length * array.Length)
                {
                    dontBreak = false;
                }

            }


            Console.WriteLine(string.Join(", ",r));

        }


    }
}

