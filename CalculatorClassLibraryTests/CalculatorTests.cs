using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests;

[TestClass()]
public class CalculatorTests
{
    [DataRow(0, 10)]
    [DataRow(1, 9)]
    [DataRow(5, 5)]
    [DataRow(2, 8)]
    [TestMethod]
    public void AddTestEqual(int value, int value2)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(value, value2);

        // Assert
        Assert.AreEqual(result, 10);
    }

    [DataRow(0, 9)]
    [DataRow(2, 9)]
    [DataRow(5, 6)]
    [DataRow(0, 11)]
    [TestMethod]
    public void AddTestNotEqual(int value, int value2)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(value, value2);

        // Assert
        Assert.AreNotEqual(result, 10);
    }

    //[TestMethod]
    //public void SubtractTest()
    //{
    //    // Arrange


    //    // Act


    //    // Assert
    //    Assert.Fail();
    //}

    //[TestMethod]
    //public void MultiplyTest()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //    Assert.Fail();
    //}

    //[TestMethod]
    //public void DivideTest()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //    Assert.Fail();
    //}
}