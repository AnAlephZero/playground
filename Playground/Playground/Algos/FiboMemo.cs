using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algos
{
    internal class FiboMemo
    {
        private Dictionary<int, int> memo = new Dictionary<int, int>();

        public int Fibo(int n)
        {
            if (n <= 0) return 0;

            if (n == 1) return 1;

            if (!memo.ContainsKey(n))
            {
                memo[n] = Fibo(n - 1) + Fibo(n - 2);
            }
            return memo[n];

        }
    }
}
