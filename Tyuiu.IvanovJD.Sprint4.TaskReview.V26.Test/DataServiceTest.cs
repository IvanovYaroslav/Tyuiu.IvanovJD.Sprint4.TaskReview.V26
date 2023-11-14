using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint4.TaskReview.V26.Lib;

namespace Tyuiu.IvanovJD.Sprint4.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check777()
        {
            int n = 5;
            int m = 3;
            int[,] mas = new int[n, m];
            string str = "351268459614723";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 18432;
            Assert.AreEqual(wait, res);
        }
    }
}
