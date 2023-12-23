using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint7.Project.V14.Lib;

namespace Tyuiu.SamarAA.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\Schedule1.csv";

        [TestMethod]
        public void TestMethod1()
        {
            string nom = "1";
            string[] res = ds.GetPaths(path, nom);
            string[] wait = "1;автобус;ул. Энтузиастов;Детский сад №62;Жилой массив;ул. Домостроителей;ул. Губкина;Элеватор;ул. Гилевская;Барабинская;Областная ГИБДД;ул. Одесская;Травматология;сквер Гимназистов;Родильный дом №2;Школа №37;ул. Фабричная;ул. Холодильная;ул. М. Горького;Сквер им. Немцова;площадь Центральная;ул. Первомайская;ул. Герцена;сквер Семена Пацко;Налоговая инспекция;Ипподром;ул. Таврическая;ул. Таврическая 1".Split(';');
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] res = ds.GetStat(path);
            int[] wait = new int[] { 18, 12 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod3()
        {

        }
    }
}
