using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint6.Review.Lib;

namespace Tyuiu.UleevRI.Sprint6.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            // Сумма элементов массива в заданной строке от k до l
            DataService ds = new DataService();
            int x = 5;
            int[,] num = new int[5, 5]
            {{ x, 1, 2, 3, x},
             {4, x, x, 5, x },
             {x, 6, x ,7, 8 },
             {x, x, 9 ,1, x },
             {2, 3, x ,x, 5 },
            };
            int res = ds.CalculateMatrix(num, 1, 9, 0, 4, 3);
            int wait = 25;
            Assert.AreEqual(wait, res);
        }
    }
}
