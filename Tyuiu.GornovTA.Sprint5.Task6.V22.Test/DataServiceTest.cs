using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.GornovTA.Sprint5.Task6.V22.Lib;

namespace Tyuiu.GornovTA.Sprint5.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint5\Tyuiu.GornovTA.Sprint5.Task6.V22\bin\Debug\InPutDataFileTask6V22.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.GornovTA.Sprint5\Tyuiu.GornovTA.Sprint5.Task6.V22\bin\Debug\InPutDataFileTask6V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
