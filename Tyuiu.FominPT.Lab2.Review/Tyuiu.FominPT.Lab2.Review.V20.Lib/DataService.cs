using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FominPT.Lab2.Review.V20.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Pow(2, -x) + (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x), 2);
                if ((3 * Math.Pow(x, 3)) == 0)
                {
                    valueArray[count] = 0;  
                }
                else
                {
                    valueArray[count] = y;
                }
                count++;
            }
            return valueArray;
        }
    }
}
