using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests;

[TestClass]
[TestSubject(typeof(MC))]
public class MCTest
{
    [TestMethod]
    public void TestVehicleOk()
    {
        // Arrange
        MC mc = new();
        var expectedResult = "MC";
        
        // Act
        var actualResult = mc.VehicleType();
        
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
        var actualResult = mc.VehicleType();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }
    
    [TestMethod]
    public void TestPriceOk()
    {
        // Arrange
        MC mc = new MC();
        mc.BroBizz = false;
        var expected = 125.0;

        // Act
        var actualResult = mc.Price();
        
        // Assert
        Assert.AreEqual(expected, actualResult);
    }
    
    [TestMethod]
    [DataRow(124.0)]
    [DataRow(126.0)]
    public void TestPriceFail(double expectedFail)
    {
        // Arrange
        MC mc = new();
        mc.BroBizz = false;
        
        // Act
        var actualResult = mc.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult);
    }
    
    [TestMethod]
    [DataRow(118.75)]
    public void TestPriceWithBrobizzOk(double expectedResult)
    {
        // Arrange
        MC mc = new();
        mc.BroBizz = true;
        
        // Act
        var actualResult = mc.Price();
        
        // Assert
        Assert.AreEqual(expectedResult, actualResult, 0.005);
    }
    
    [TestMethod]
    [DataRow(125.0)]
    public void TestPriceWithBrobizzFail(double expectedFail)
    {
        // Arrange
        MC mc = new();
        mc.BroBizz = true;
        
        // Act
        var actualResult = mc.Price();
        
        // Assert
        Assert.AreNotEqual(expectedFail, actualResult, 0.005);
    }
}