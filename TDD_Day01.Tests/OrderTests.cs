using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpectedObjects;
using System.Linq;

namespace TDD_Day01.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GetSumTest_WhenPass3_ReturnCostSum()
        {
            //Arrange
            var list = GetInitList();
            var target = new OrderService();
            var expected = new List<int> { 6, 15, 24, 21 };

            //Act
            var actual = target.GetSumList<Order>(list, x => x.Cost, 3);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void GetSumTest_WhenPass4_ReturnRevenueSum()
        {
            //Arrange
            var list = GetInitList();
            var target = new OrderService();
            var expected = new List<int> { 50, 66, 60 };

            //Act
            var actual = target.GetSumList<Order>(list, x => x.Revenue, 4);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        //[TestMethod]
        //public void GetSumTest_WhenPass3_ReturnCostSum()
        //{
        //    //Arrange
        //    var list = GetInitList();
        //    var target = new OrderService(list);
        //    var expected = new List<int> { 6, 15, 24, 21 };

        //    //Act
        //    var actual = target.GetSumList(3);

        //    //Assert
        //    expected.ToExpectedObject().ShouldEqual(actual);
        //    CollectionAssert.AreEqual(expected, actual.ToList());
        //}

        //[TestMethod]
        //public void GetSumTest_WhenPass4_ReturnRevenueSum()
        //{
        //    //Arrange
        //    var list = GetInitList();
        //    var target = new OrderService(list);
        //    var expected = new List<int> { 50, 66, 60 };

        //    //Act
        //    var actual = target.GetSumList(4);

        //    //Assert
        //    expected.ToExpectedObject().ShouldEqual(actual);
        //    CollectionAssert.AreEqual(expected, actual.ToList());
        //}

        private IEnumerable<Order> GetInitList()
        {
            var list = new List<Order>()
            {
                new Order() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Order() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Order() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Order() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Order() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Order() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Order() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Order() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Order() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Order() { Id =10, Cost =10, Revenue = 20, SellPrice = 30 },
                new Order() { Id =11, Cost =11, Revenue = 21, SellPrice = 31 },
            };
            return list;
        }
    }
}
