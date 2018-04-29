using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame.Rules
{
    class StraightRule : ICalcualtePoints
    {
        public int CalcualtePoints(int[] arr, out int startindex, out int endindex)
        {
            startindex = 0;
            endindex = 0;
            if (arr.Length == 6)
                if (arr[0]==1&& arr[1]==2 && arr[2] ==3 && arr[3]==4 && arr[4] ==5 && arr[5]==6)
                {
                    endindex = 5;
                    return scoreconstant.Straight;
                }
            return 0;
        }
    }
}
