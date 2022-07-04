using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algos
{
    internal class FiboBase
    {
        public int Fibo (int n)
        {
            if (n <= 0) return 0;

            if (n == 1) return 1;

            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
