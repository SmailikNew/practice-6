using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_6
{
    class Pair
    {
        private int first;
        private int second;

        public int First
        {
            get { return first; }
        }

        public int Second
        {
            get { return second; }
        }

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public int Sum()
        {
            return first + second;
        }

        public static Pair operator --(Pair pair1)
        {
            return new Pair(pair1.first - 1, pair1.second -1);
        }

        public Pair Sum(Pair pair)
        {
            return new Pair(first + pair.first, second + pair.second);
        }

        public static Pair operator +(Pair pair1, Pair pair2)
        {
            return new Pair(pair1.first + pair2.first, pair1.second + pair2.second);
        }
    }
}
