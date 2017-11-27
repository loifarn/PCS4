using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeRecursiveMethods
{
    class MyMethods
    {

        public int sumSquares(int n)
        {
            if (n == 0) { return 0; }
            else { return sumSquares(n - 1) + (n*n); }
        }

        public int sum(int[] X, int n)
        {
            if (n == 0) { return 0; }
            else{ return sum(X, n-1) + X[n - 1]; }
        }

        public int max(int[] X, int n)
        {
            int tmp;
            if (n == 1) { return X[n]; }
                
            tmp = max(X, n - 1);
            if (X[n] > tmp) { return X[n]; }
            else { return tmp; }
        }

        public int sumOfDigits(int n)
        {
            int sum = 0;
            if (n == 0) { return sum; }
            return n % 10 + sumOfDigits(n / 10);
        }
    }
}
