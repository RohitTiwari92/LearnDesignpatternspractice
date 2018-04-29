using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame
{
    public static class scoreconstant
    {
        public static readonly int singleone = 100;
        public static readonly int singlefive = 50;
        public static readonly int tripleones = 1000;
        public static readonly int tripletwos = 200;
        public static readonly int triplethrees = 300;
        public static readonly int triplefours = 400;
        public static readonly int triplefives = 500;
        public static readonly int triplesixs = 600;
        public static readonly int ThreePairs  = 800;
        public static readonly int Straight = 1200;

        public static int Getstdpointfortriple(int i)
        {
            switch (i)
            {
                case 1:
                    return tripleones;
                case 2:
                    return tripletwos;
                case 3:
                    return triplethrees;
                case 4:
                    return triplefours;
                case 5:
                    return triplefives;
                case 6:
                    return triplesixs;
                default:
                    return 0;
            }
        }

    }
}