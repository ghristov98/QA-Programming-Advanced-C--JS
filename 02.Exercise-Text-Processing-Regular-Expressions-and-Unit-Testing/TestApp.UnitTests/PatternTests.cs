using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("hello", 2, "hElLohElLo")]
    [TestCase("abcd", 4, "aBcDaBcDaBcDaBcD")]
    [TestCase("-go ", 3, "-Go -Go -Go ")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
        int repetitionFactor, string expected)
    {
        // Arrange
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string emptyInput = "";
        int repetitionFactor = 3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(emptyInput, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        int repetitionFactor = -5;
        string input = "hello";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        int repetitionFactor = 0;
        string input = "hello";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}