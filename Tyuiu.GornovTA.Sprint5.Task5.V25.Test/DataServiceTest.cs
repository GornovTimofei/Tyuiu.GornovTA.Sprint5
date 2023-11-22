using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.GornovTA.Sprint5.Task5.V25.Lib;

namespace Tyuiu.GornovTA.Sprint5.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint5\Tyuiu.GornovTA.Sprint5.Task5.V25\bin\Debug\InPutDataFileTask5V25.txt";
            double res = ds.LoadFromDataFile(path);
            double wait = -5973964.557;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint5\Tyuiu.GornovTA.Sprint5.Task5.V25\bin\Debug\InPutDataFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
