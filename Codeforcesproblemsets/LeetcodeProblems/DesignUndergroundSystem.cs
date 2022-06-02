using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class DesignUndergroundSystem
    {
        private Dictionary<int, (string station, int t)> checksIns;
        private Dictionary<string, (int sum, int cnt)> distances;
        public DesignUndergroundSystem()
        {
            checksIns = new Dictionary<int, (string station, int t)>();
            distances = new Dictionary<string, (int sum, int cnt)>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            checksIns[id] = (stationName, t);
        }

        public void CheckOut(int id, string stationName, int t)
        {
            var begin = checksIns[id];
            
            var key = $"{begin.station}-{stationName}";

            if (!distances.ContainsKey(key))
                distances[key] = (0, 0);

            distances[key] = (distances[key].sum + t - begin.t, distances[key].cnt + 1);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var key = $"{startStation}-{endStation}";
            if (!distances.ContainsKey(key))
                return 0;

            return (double)distances[key].sum / distances[key].cnt;

        }
    }
}
