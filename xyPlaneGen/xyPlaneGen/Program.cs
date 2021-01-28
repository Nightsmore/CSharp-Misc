using System;

namespace xyPlaneGen
{
    class Program
    {
        static int chunkSize = 50;
        public static int terrainSizeX, terrainSizeZ;


        static int[,] mapArray;
        static void Main(string[] args)
        {
            mapArray = new int[10, 10];
            terrainSizeX = 10;
            terrainSizeZ = 10;
            int iter;
            for (int i = 0; i != terrainSizeX; ++i)
            {
                iter = 0;
              
                try
                {
                    mapArray[i, 0] = mapArray[i - 1, 0] + chunkSize;
                }
                catch (System.IndexOutOfRangeException)
                {

                }

                for (int ii = 0; ii != terrainSizeZ; ++ii)
                {
                    iter += chunkSize;
                    try
                    {
                        mapArray[i, ii+1] = iter;
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                    }
                }
            }
 

            for (int i = 0; i != terrainSizeX; ++i)
            {

                for (int ii = 0; ii != terrainSizeZ; ++ii)
                {
                    Console.Write("{0},", mapArray[i, ii]);
                }
                Console.WriteLine();
            }
        }
    }
}
