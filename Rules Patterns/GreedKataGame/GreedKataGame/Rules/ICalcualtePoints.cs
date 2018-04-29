using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame.Rules
{
   public interface ICalcualtePoints
    {
        int CalcualtePoints(int[] arr, out int startindex, out int endindex);
    }
}
