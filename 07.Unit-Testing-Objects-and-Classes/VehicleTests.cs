﻿using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    {
        _vehicles = new Vehicles();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[] { "Car/Toyota/Camry/150", "Truck/Volvo/VNL/500", "Car/Ford/Focus/120", "Truck/Scania/460R/2000" };

        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Scania: 460R - 2000kg{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string[] emptyArray = Array.Empty<string>();
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string result = _vehicles.AddAndGetCatalogue(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}