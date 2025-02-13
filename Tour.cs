//using System;
//using System.Collections.Generic;


//    class PetrolPump
//    {
//        public int Petrol;
//        public int Distance;

//        public PetrolPump(int petrol, int distance)
//        {
//            Petrol = petrol;
//            Distance = distance;
//        }
//    }

//    class Tour
//    {
//        public static int FindStartingPump(PetrolPump[] pumps)
//        {
//            int start = 0, deficit = 0, surplus = 0;
//            int n = pumps.Length;

//            for (int i = 0; i < n; i++)
//            {
//                surplus += pumps[i].Petrol - pumps[i].Distance;
//                if (surplus < 0)
//                {
//                    start = i + 1;
//                    deficit += surplus;
//                    surplus = 0;
//                }
//            }

//            return (surplus + deficit >= 0) ? start : -1;
//        }

//        public static void Main()
//        {
//            PetrolPump[] pumps = {
//                new PetrolPump(4, 6),
//                new PetrolPump(6, 5),
//                new PetrolPump(7, 3),
//                new PetrolPump(4, 5)
//            };

//            int startIndex = FindStartingPump(pumps);

//            if (startIndex == -1)
//                Console.WriteLine("Circular tour is not possible.");
//            else
//                Console.WriteLine("Start at petrol pump: " + startIndex);
//        }
//    }


