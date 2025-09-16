using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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
        int expected = 10;

        // Act
        int result = Calculator.Add(value, value2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [DataRow(0, 9)]
    [DataRow(2, 9)]
    [DataRow(5, 6)]
    [DataRow(0, 11)]
    [TestMethod]
    public void AddTestNotEqual(int value, int value2)
    {
        // Arrange
        int notExpected = 10;

        // Act
        int result = Calculator.Add(value, value2);

        // Assert
        Assert.AreNotEqual(notExpected, result);
    }

    [DataRow(20, 10)]
    [DataRow(100, 90)]
    [DataRow(10, 0)]
    [DataRow(11, 1)]
    [TestMethod]
    public void SubtractTestEqual(int value, int value2)
    {
        // Arrange
        int expected = 10;

        // Act
        int result = Calculator.Subtract(value, value2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [DataRow(20, 30)]
    [DataRow(100, 50)]
    [DataRow(10, 1)]
    [DataRow(11, 2)]
    [TestMethod]
    public void SubtractTestNotEqual(int value, int value2)
    {
        // Arrange
        int notExpected = 10;

        // Act
        int result = Calculator.Subtract(value, value2);

        // Assert
        Assert.AreNotEqual(notExpected, result);
    }

    [DataRow(10, 10)]
    [DataRow(4, 25)]
    [DataRow(2, 50)]
    [TestMethod]
    public void MultiplyTestEqual(int value, int value2)
    {
        // Arrange
        int expected = 100;

        // Act
        int result = Calculator.Multiply(value, value2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [DataRow(9, 11)]
    [DataRow(1, 101)]
    [DataRow(3, 33)]
    [DataRow(5, 5)]
    [TestMethod]
    public void MultiplyTestNotEqual(int value, int value2)
    {
        // Arrange
        int notExpected = 100;

        // Act
        int result = Calculator.Multiply(value, value2);

        // Assert
        Assert.AreNotEqual(notExpected, result);
    }

    [DataRow(200, 2)]
    [DataRow(1000, 10)]
    [DataRow(10000, 100)]
    [TestMethod]
    public void DivideTestEqual(int value, int value2)
    {
        // Arrange
        int expected = 100;

        // Act
        int result = Calculator.Divide(value, value2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [DataRow(81, 9)]
    [DataRow(27, 3)]
    [DataRow(121, 11)]
    [DataRow(33, 3)]
    [DataRow(3, 0)]
    [TestMethod]
    public void DivideTestNotEqual(int value, int value2)
    {
        // Arrange
        int notExpected = 10;

        // Act
        int result = Calculator.Divide(value, value2);

        // Assert
        Assert.AreNotEqual(notExpected, result);
    }
}