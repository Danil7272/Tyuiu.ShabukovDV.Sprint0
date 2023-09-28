using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShabukovDV.Sprint0.Task3.V0.Lib;
namespace Tyuiu.ShabukovDV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {            
            Assert.AreEqual(20, DataService.Sum(10, 10));
        }
    }
}
