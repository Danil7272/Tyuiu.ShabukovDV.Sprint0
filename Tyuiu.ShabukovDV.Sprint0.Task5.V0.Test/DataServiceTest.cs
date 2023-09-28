﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Подключение библеотеки
using Tyuiu.ShabukovDV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShabukovDV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
         [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(100, DataService.Addition(50, 50));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckendMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
