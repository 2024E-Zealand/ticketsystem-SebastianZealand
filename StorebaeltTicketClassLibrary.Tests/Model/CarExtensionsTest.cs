using System;
using System.Runtime.InteropServices.JavaScript;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary.Model;
using TicketClassLibrary;

namespace StorebaeltTicketClassLibrary.Tests.Model;

[TestClass]
[TestSubject(typeof(CarExtensions))]
public class CarExtensionsTest
{

    [TestMethod]
    [DataRow(182.4, "2024-09-28")] // Saturday
    [DataRow(182.4, "2024-09-29")] // Sunday
    public void TestGetStorebaeltPrice_BothBrobizzAndWeekendDiscountOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(192, "2024-09-28")] // Saturday
    [DataRow(192, "2024-09-29")] // Sunday
    public void TestGetStorebaeltPrice_NoBrobizzButWeekendDiscountOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(228, "2024-09-24")] // Tuesday
    [DataRow(228, "2024-09-25")] // Wednesday
    public void TestGetStorebaeltPrice_BrobizzButNoWeekendDiscountOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(240, "2024-09-24")] // Tuesday
    [DataRow(240, "2024-09-25")] // Wednesday
    public void TestGetStorebaeltPrice_BothNoBrobizzAndNoWeekendDiscountOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(240.0, "2024-09-28")] // Saturday
    [DataRow(240.0, "2024-09-29")] // Sunday
    public void TestGetStorebaeltPrice_BothBrobizzAndWeekendDiscountNotOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(182.4, "2024-09-28")] // Saturday
    [DataRow(182.4, "2024-09-29")] // Sunday
    public void TestGetStorebaeltPrice_NoBrobizzButWeekendDiscountNotOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(192, "2024-09-24")] // Tuesday
    [DataRow(192, "2024-09-25")] // Wednesday
    public void TestGetStorebaeltPrice_BrobizzButNoWeekendDiscountNotOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(228, "2024-09-24")] // Tuesday
    [DataRow(228, "2024-09-25")] // Wednesday
    public void TestGetStorebaeltPrice_BothNoBrobizzAndNoWeekendDiscountNotOk(double expectedTicketPrice, string dateString)
    {
        // Arrange
        var car = new Car()
        {
            Date = DateTime.Parse(dateString),
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetStorebaeltPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
}