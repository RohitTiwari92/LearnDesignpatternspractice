using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame.Rules
{
    class AsingleoneRule : ICalcualtePoints
    {
        public int CalcualtePoints(int[] arr, out int startindex, out int endindex)
        {
            startindex = 0;
            endindex = 0;
            int points = 0;
            foreach(int i in arr)
            {
                if(i==1)
                {
                    points = points + scoreconstant.singleone;
                }
            }
            return points;
        }
    }
}
