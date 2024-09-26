using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(MC))]
public class MCTest
{

    [TestMethod]
    public void TestPriceOk()
    {
        // Arrange
        MC mc = new();
        var expectedResult = 125.0;

        // Act
        var actualResult = mc.Price();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);

    }

    [TestMethod]
    [DataRow(124.0)]
    [DataRow(126.0)]
    public void TestPriceFail(double expectedFail)
    {
        // Arrange
        MC mc = new();
        
        // Act
        var actualResult = mc.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }

    [TestMethod]
    public void TestVehicleOk()
    {
        // Arrange
        MC mc = new();
        var expectedResult = "MC";
        
        // Act
        var actualResult = mc.Vehicle();
        
        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow("Car")]
    [DataRow(" ")]
    public void TestVehicleFail(string expectedFail)
    {
        // Arrange
        MC mc = new();
        
        // Act
        var actualResult = mc.Vehicle();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }
    
    
}