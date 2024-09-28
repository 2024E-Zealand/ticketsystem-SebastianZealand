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
}