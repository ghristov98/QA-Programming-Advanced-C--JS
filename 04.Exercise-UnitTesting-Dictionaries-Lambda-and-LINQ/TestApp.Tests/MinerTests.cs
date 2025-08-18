using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        //Arrange
        string[] input = new string[] { "GOLD 2", "silver 5", "Gold 10", "SILVER 23", "Copper 12" };
        string expected = "gold -> 12"
                            + Environment.NewLine
                            + "silver -> 28"
                            + Environment.NewLine
                            + "copper -> 12";

        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        //Arrange
        string[] input = new string[] { "copper 10", "gold 20", "silver 5", "gold 10", "silver 25", "copper 30" };
        string expected = "copper -> 40"
                            + Environment.NewLine
                            + "gold -> 30"
                            + Environment.NewLine
                            + "silver -> 30";

        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}