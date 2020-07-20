using System;

namespace Codility_Exams
{
    public class COdility
    {
        public static void Main(string[] args)
        {

            

            Console.WriteLine("Hello World!");
        }

        public int Solution1(string S)
        {
            //Check if string is null or empty
            if (String.IsNullOrEmpty(S))
            {
                return 0;
            }

            //Initialize our count tracking variables
            int totalA = 0, totalB = 0, totalDelete = 0;
            
            //Covert string to char array & loop through the array updating our tracking variables
            var charArr = S.ToCharArray();
            foreach (char ch in charArr)
            {
                if (ch == 'A')
                {
                    totalA++;
                    if (totalB > totalDelete)
                    {
                        totalDelete++;
                    }
                }
                else
                {
                    totalB++;
                }
            }

            int minTotalBToDelete = Math.Min(totalB, totalDelete);
            int finalTotalMin = Math.Min(totalA, minTotalBToDelete);

            return finalTotalMin;
        }

        public int Solution2(int[] ranks)
        {
            //Get the length of our ranks
            int rankLen = ranks.Length;

            //Sort our ranks in order
            Array.Sort(ranks);

            //Initialize reporting soldier & base rank
            int reportingSoldier = 0, baserank = 0;

            foreach(var rank in ranks)
            {
                var upperRank = rank + 1;
                if(Array.Exists(ranks, element => element == upperRank))
                {
                    if(baserank != rankLen)
                    {
                        reportingSoldier++;
                    }
                }

                baserank++;
            }

            
            //Return reporting soldier
            return reportingSoldier;
        }

        public int Solution3(int[] blocks)
        {
            int blocklen = blocks.Length;

            int firstBlock, secondBlock;

            firstBlock = secondBlock = int.MaxValue;

            if (blocklen < 2)
            {
                return 0;
            }

            for (int i = 0; i < blocklen; i++)
            {
                if (blocks[i] <= firstBlock)
                {
                    secondBlock = firstBlock;
                    firstBlock = blocks[i];
                }

                else if (blocks[i] < secondBlock && blocks[i] != firstBlock)
                {
                    secondBlock = blocks[i];
                }

            }

            return secondBlock + 1;
        }

        public int Solution4(int[] blocks)
        {
            int block = 0;

            for (int i = 0; i < blocks.Length; ++i)
            {
                if (blocks[i] != blocks[blocks.Length - 1] || blocks[0] != blocks[blocks.Length - 1 - i])
                {
                    block = blocks.Length - i - 1;

                    break;
                }
                else
                {
                    block++;
                }
            }
               

            return block;
        }
    }
}
