using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint4.V9.Reviev.Lib;

namespace Tyuiu.IvanchikovDA.Sprint4.V9.Reviev.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {

            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "864299753";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
