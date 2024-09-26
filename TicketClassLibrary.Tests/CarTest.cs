using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(Car))]
public class CarTest
{
    [TestMethod]
    public void TestPriceOk()
    {
        // Arrange
        Car car = new Car();
        var expected = 125.0;

        // Act
        var actualResult = car.Price();
        
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
        var actualResult = car.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }

    [TestMethod]
    public void TestVehicleOk()
    {
        // Arrange
        var car = new Car();
        var expected = "Car";

        // Act
        var actualResult = car.VehicleType();
        
        // Assert
        Assert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    [DataRow("MC")]
    [DataRow("Bike")]
    public void TestVehicleFail(string expectedFail)
    {
        // Arrange
        var car = new Car();
        
        // Act
        var actualResult = car.VehicleType();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }
}