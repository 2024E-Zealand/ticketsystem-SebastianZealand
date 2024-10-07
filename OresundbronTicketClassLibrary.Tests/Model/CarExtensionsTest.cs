using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary.Model;
using TicketClassLibrary;

namespace OresundbronTicketClassLibrary.Tests.Model;

[TestClass]
[TestSubject(typeof(CarExtensions))]
public class CarExtensionsTest
{

    [TestMethod]
    [DataRow(161.0)]
    public void TestGetOresundbronPrice_WithBrobizzOk(double expectedTicketPrice)
    {
        // Arrange
        var car = new Car()
        {
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetOresundbronPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(410.0)]
    public void TestGetOresundbronPrice_WithoutBrobizzOk(double expectedTicketPrice)
    {
        // Arrange
        var car = new Car()
        {
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetOresundbronPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(410.0)]
    [DataRow(162.0)]
    [DataRow(163.0)]
    public void TestGetOresundbronPrice_WithBrobizzNotOk(double expectedTicketPrice)
    {
        // Arrange
        var car = new Car()
        {
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = car.GetOresundbronPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    [TestMethod]
    [DataRow(161.0)]
    [DataRow(409.0)]
    [DataRow(411.0)]
    public void TestGetOresundbronPrice_WithoutBrobizzNotOk(double expectedTicketPrice)
    {
        // Arrange
        var car = new Car()
        {
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = car.GetOresundbronPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }

    [TestMethod]
    [DataRow("Oresund car")]
    public void TestGetOresundbronVehicleTypeOk(string expectedVehicleType)
    {
        // Arrange
        var car = new Car();
        
        // Act
        var actualVehicleType = car.GetOresundbronVehicleType();
        
        // Assert
        Assert.AreEqual(expectedVehicleType, actualVehicleType);
        
    }
    
    [TestMethod]
    [DataRow("Car")]
    public void TestGetOresundbronVehicleTypeNotOk(string expectedVehicleType)
    {
        // Arrange
        var car = new Car();
        
        // Act
        var actualVehicleType = car.GetOresundbronVehicleType();
        
        // Assert
        Assert.AreNotEqual(expectedVehicleType, actualVehicleType);
        
    }
}