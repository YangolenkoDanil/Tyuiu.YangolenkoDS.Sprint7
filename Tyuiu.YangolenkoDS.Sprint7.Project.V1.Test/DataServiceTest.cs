using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint7.Project.V1.Lib;

namespace Tyuiu.YangolenkoDS.Sprint7.Project.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void GetMatrix()
        {
            string path = @"C:\DataSprint7\DataBaseSprint7V1.csv";
            string[,] res = ds.GetMatrix(path);
        }
    }
}
