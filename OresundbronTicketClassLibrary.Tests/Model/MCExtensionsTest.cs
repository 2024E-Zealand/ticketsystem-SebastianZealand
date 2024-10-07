using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary.Model;
using TicketClassLibrary;

namespace OresundbronTicketClassLibrary.Tests.Model;

[TestClass]
[TestSubject(typeof(MCExtensions))]
public class MCExtensionsTest
{

    [TestMethod]
    [DataRow(73.0)]
    public void TestGetOresundbronPrice_WithBrobizzOk(double expectedTicketPrice)
    {
        // Arrange
        var mc = new MC()
        {
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = mc.GetOresundbronPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(210.0)]
    public void TestGetOresundbronPrice_WithoutBrobizzOk(double expectedTicketPrice)
    {
        // Arrange
        var mc = new MC()
        {
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = mc.GetOresundbronPrice();

        // Assert
        Assert.AreEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    
    [TestMethod]
    [DataRow(210.0)]
    [DataRow(72.0)]
    [DataRow(74.0)]
    public void TestGetOresundbronPrice_WithBrobizzNotOk(double expectedTicketPrice)
    {
        // Arrange
        var mc = new MC()
        {
            BroBizz = true
        };
        
        // Act
        var actualTicketPrice = mc.GetOresundbronPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }
    [TestMethod]
    [DataRow(73.0)]
    [DataRow(209.0)]
    [DataRow(211.0)]
    public void TestGetOresundbronPrice_WithoutBrobizzNotOk(double expectedTicketPrice)
    {
        // Arrange
        var mc = new MC()
        {
            BroBizz = false
        };
        
        // Act
        var actualTicketPrice = mc.GetOresundbronPrice();

        // Assert
        Assert.AreNotEqual(expectedTicketPrice, actualTicketPrice, 0.05);
    }

    [TestMethod]
    [DataRow("Oresund MC")]
    public void TestGetOresundbronVehicleTypeOk(string expectedVehicleType)
    {
        // Arrange
        var mc = new MC();
        
        // Act
        var actualVehicleType = mc.GetOresundbronVehicleType();
        
        // Assert
        Assert.AreEqual(expectedVehicleType, actualVehicleType);
        
    }
    
    [TestMethod]
    [DataRow("MC")]
    public void TestGetOresundbronVehicleTypeNotOk(string expectedVehicleType)
    {
        // Arrange
        var mc = new MC();
        
        // Act
        var actualVehicleType = mc.GetOresundbronVehicleType();
        
        // Assert
        Assert.AreNotEqual(expectedVehicleType, actualVehicleType);
        
    }
}