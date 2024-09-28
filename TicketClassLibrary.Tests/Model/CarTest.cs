using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(Car))]
public class CarTest
{
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
    
    [TestMethod]
    public void TestPriceOk()
    {
        // Arrange
        Car car = new Car();
        car.BroBizz = false;
        var expected = 240.0;

        // Act
        var actualResult = car.Price();
        
        // Assert
        Assert.AreEqual(expected, actualResult);
    }
    
    [TestMethod]
    [DataRow(239.0)]
    [DataRow(241.0)]
    public void TestPriceFail(double expectedFail)
    {
        // Arrange
        Car car = new Car();
        car.BroBizz = false;
        
        // Act
        var actualResult = car.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }
    
    [TestMethod]
    [DataRow(228.0)]
    public void TestPriceWithBrobizzOk(double expectedResult)
    {
        // Arrange
        Car car = new Car();
        car.BroBizz = true;
        
        // Act
        var actualResult = car.Price();
        
        // Assert
        Assert.AreEqual(expectedResult, actualResult, 0.005);
    }
    
    [TestMethod]
    [DataRow(240.0)]
    public void TestPriceWithBrobizzFail(double expectedFail)
    {
        // Arrange
        Car car = new Car();
        car.BroBizz = true;
        
        // Act
        var actualResult = car.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult, 0.005);
    }
}