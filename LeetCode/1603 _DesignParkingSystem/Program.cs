using System;

namespace _1603__DesignParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ParkingSystem
    {
        int bigCount;
        int medCount;
        int smlCount;

        public ParkingSystem(int big, int medium, int small)
        {
            bigCount = big;
            medCount = medium;
            smlCount = small;
        }
        public bool addCar(int carType)
        {
            if (carType == 1 && bigCount > 0)
            {
                bigCount--;
                return true;
            }
            if (carType == 2 && medCount > 0)
            {
                medCount--;
                return true;
            }
            if (carType == 3 && smlCount > 0)
            {
                smlCount--;
                return true;
            }
            return false;
        }

    }

}

//Success

//Runtime: 172 ms, faster than 95.28% of C# online submissions for Design Parking System.

//Memory Usage: 43.4 MB, less than 39.69% of C# online submissions for Design Parking System.
