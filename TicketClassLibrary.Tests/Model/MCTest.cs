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
    
    
}