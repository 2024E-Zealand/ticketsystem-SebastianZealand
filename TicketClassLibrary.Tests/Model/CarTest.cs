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
}