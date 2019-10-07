using System;
using System.Collections.Generic;
using System.Linq;

namespace LUNCHBOX
{
    class Program
    {
        //Tuple<heatingTime, eatingTime>
        static List<Tuple<int, int>> lunchBoxes = new List<Tuple<int, int>>();
        static void Main(string[] args)
        {
            //lunchBoxes.Add(Tuple.Create<int, int>(1, 1));
            //lunchBoxes.Add(Tuple.Create<int, int>(2, 2));
            //lunchBoxes.Add(Tuple.Create<int, int>(3, 1));

            //Console.WriteLine(GetLunchTime());

            lunchBoxes.Add(Tuple.Create<int, int>(2, 2));
            lunchBoxes.Add(Tuple.Create<int, int>(2, 2));
            lunchBoxes.Add(Tuple.Create<int, int>(2, 2));

            Console.WriteLine(GetLunchTime());
        }

        static int GetLunchTime()
        {
            var eatingTimeDescending = lunchBoxes.OrderByDescending(x => x.Item2).ToList();
            int totalHeatingTime = 0;
            int totalEatingTime = 0;

            for(int i = 0; i < eatingTimeDescending.Count; i++)
            {
                totalHeatingTime += eatingTimeDescending[i].Item1;  //add heatingtime 
                totalEatingTime = Math.Max(totalEatingTime, totalHeatingTime + eatingTimeDescending[i].Item2);
            }

            return totalEatingTime;
        }
    }
}
