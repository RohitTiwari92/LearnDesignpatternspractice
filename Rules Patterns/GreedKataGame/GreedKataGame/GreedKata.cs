using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedKataGame.Rules;

namespace GreedKataGame
{
   public class GreedKata
    {
        List<ICalcualtePoints> _rules = new List<ICalcualtePoints>();
        public GreedKata()
        {
            _rules.Add(new StraightRule());
            _rules.Add(new ThreePairsRule());
            _rules.Add(new N_of_a_Kind());
            _rules.Add(new AsingleoneRule());
            _rules.Add(new AsingleFiveRule());
            
        }

        public int calcualte(int[] arr)
        {
            int points = 0;
            foreach(var rule in _rules)
            {
                int startindex = 0;
                int endindex = 0;
               points= rule.CalcualtePoints(arr, out startindex, out endindex)+points;
                if(endindex!=0)
                {
                    arr = Getnewarray(arr, startindex, endindex);
                }
            }
            return points;
        }

        private static int[] Getnewarray(int[] arr, int startindex, int endindex)
        {
            List<int> temparr = new List<int>();
            for (int i=0;i< arr.Length;i++)
            {
                if (i < startindex || i > endindex)
                {
                    temparr.Add(arr[i]);
                }
            }
            arr = temparr.ToArray();
            return arr;
        }
    }
}
