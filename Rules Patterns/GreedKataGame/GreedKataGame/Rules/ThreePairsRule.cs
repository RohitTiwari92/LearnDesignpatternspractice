using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame.Rules
{
    class ThreePairsRule : ICalcualtePoints
    {
        public int CalcualtePoints(int[] arr, out int startindex, out int endindex)
        {
            startindex = 0;
            endindex = 0;
           if(arr.Length==6)
           if((arr[0]==arr[1]) && (arr[2] == arr[3]) && (arr[4] == arr[5]) && (arr[0]!=arr[2]) &&(arr[2] != arr[4]))
            {
                    endindex = 5;
                    return scoreconstant.ThreePairs;
            }
            return 0;
        }
    }
}
