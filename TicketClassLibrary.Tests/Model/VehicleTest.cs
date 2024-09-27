using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests.Model;

[TestClass]
[TestSubject(typeof(Vehicle))]
public class VehicleTest
{

    [TestMethod]
    [DataRow("1234567")]
    [DataRow("123456")]
    [DataRow("BD")]
    public void TestLicensePlateOk(string LicensePlate)
    {
        // Arrange
        Car car = new Car
        {
            LicensePlate = LicensePlate
        };

        // Act
        var actualLicensePlate = car.LicensePlate;
        
        // Assert
        Assert.AreEqual(LicensePlate, actualLicensePlate);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestLicensePlateFail()
    {
        // Arrange
        var car = new Car();
        
        // Act
        car.LicensePlate = "12345678";
    }
    
    public void TestPriceOk()
    {
        // Arrange
        Car car = new Car();
        var expected = 125.0;

        // Act
        var actualResult = car.Price(false);
        
        // Assert
        Assert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    [DataRow(124.0)]
    [DataRow(126.0)]
    public void TestPriceFail(double expectedFail)
    {
        // Arrange
        Car car = new Car();
        
        // Act
        var actualResult = car.Price(false);
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }

    [TestMethod]
    [DataRow(118.75)]
    public void TestPriceWithBrobizzOk(double expectedResult)
    {
        // Arrange
        Car car = new Car();
        
        // Act
        var actualResult = car.Price(true);
        
        // Assert
        Assert.AreEqual(expectedResult, actualResult, 0.005);
        
    }

    [TestMethod]
    [DataRow(125.0)]
    public void TestPriceWithBrobizzFail(double expectedFail)
    {
        // Arrange
        Car car = new Car();
        
        // Act
        var actualResult = car.Price(true);
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult, 0.005);
    }
}