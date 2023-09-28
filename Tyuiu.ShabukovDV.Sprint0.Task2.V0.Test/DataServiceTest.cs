using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShabukovDV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShabukovDV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестрирование, методов из библиотеки
            var name = "Данил";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Приветствую, Данил", res);
        }
    }
}
