using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame.Rules
{
    class N_of_a_Kind : ICalcualtePoints
    {
        public int CalcualtePoints(int[] arr, out int startindex, out int endindex)
        {
            int count = 0;
            int tempcount = 1;
            startindex = 0;
            endindex = 0;
            int Tempstartindex = -1;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (tempcount == 1)
                {
                    Tempstartindex = i;
                }
                if (arr[i]==arr[i+1])
                {
                    tempcount++;
                }
                if (arr[i] != arr[i + 1] || i== arr.Length - 2)
                {
                    if(tempcount>count)
                    {
                        count = tempcount;
                        tempcount = 1;
                        startindex = Tempstartindex;
                    }
                }
               
            }
            int points = 0;
            if (count > 2)
            {
                 points = calcualteextrarule(count, arr[startindex]);
                endindex = startindex + count - 1;
            }
            int spoint = 0;
            if (count==3 && endindex==2 && arr.Length==6)
            {
                int[] sarr= { arr[3], arr[4], arr[5] };
                int sinout = 0;
                int soutout = 0;
                spoint=CalcualtePoints(sarr,out sinout,out soutout);
            }
            if(spoint>0)
            {
                startindex = 0;
                endindex = 5;
                points = spoint + points;
            }
            if(points==0)
            {
                startindex = 0;
                endindex = 0;
            }
            return points;
        }

        private int calcualteextrarule(int count, int v)
        {
            int points= scoreconstant.Getstdpointfortriple(v);
            switch (count)
            {
                case 3:
                    return points;
                case 4:
                    return points * 2;
                case 5:
                    return points * 4;
                case 6:
                    return points * 8;
                default:
                    return 0;
            }
        }
    }
}
