using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FominPT.Lab2.Review.V20.Lib;

namespace Tyuiu.FominPT.Lab2.Review.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 31.22;
            valueWaitArray[1] = 15.55;
            valueWaitArray[2] = 8.63;
            valueWaitArray[3] = 4.58;
            valueWaitArray[4] = -1.12;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 2.54;
            valueWaitArray[7] = 0.98;
            valueWaitArray[8] = 1.31;
            valueWaitArray[9] = 2.43;
            valueWaitArray[10] = -1.17;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
