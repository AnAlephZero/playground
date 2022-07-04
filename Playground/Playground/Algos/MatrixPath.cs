using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algos
{
    internal class MatrixPath
    {
        int[,] theMatrix = new int[8, 8];

        private bool isValidCell(int row, int column)
        {
            if (row > 7 || column > 7)
            {
                return false;
            }

            if (row == 1 && column == 2) {
                return false;
            }
            if (row == 1 && column == 6)
            {
                return false;
            }
            if (row == 2 && column == 4)
            {
                return false;
            }
            if (row == 3 && column == 0)
            {
                return false;
            }
            if (row == 3 && column == 2)
            {
                return false;
            }
            if (row == 3 && column == 5)
            {
                return false;
            }
            if (row == 4 && column == 2)
            {
                return false;
            }
            if (row == 5 && column == 3)
            {
                return false;
            }
            if (row == 5 && column == 4)
            {
                return false;
            }
            if (row == 5 && column == 6)
            {
                return false;
            }
            if (row == 6 && column == 1)
            {
                return false;
            }
            if (row == 6 && column == 5)
            {
                return false;
            }
            return true;
        }

        public int getPathNumber (int row, int column)
        {
            if (!isValidCell(row, column))
            {
                return 0;
            }

            if (row == 7 && column == 7)
            {
                return 1;
            }

            return getPathNumber(row + 1, column) + getPathNumber(row, column + 1);
        }

    }
}
