using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

public class DigitAndSymbolCounterTests
{

    [Test]
    public void Test_EmptyStringInput_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = string.Empty;
        int expected = 0;

        // Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected));
    }
    

    [Test]
    public void Test_NoDigitsStringInput_ReturnsOnlyNonDigitsCount()
    {
        // Arrange
        string input = "abc!@#";
        Dictionary<string, int> expected = new Dictionary<string, int>
        {
            { "non-digit symbol", 6 }
        };

        // Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
        Assert.That(result["non-digit symbol"], Is.EqualTo(expected["non-digit symbol"]));
        Assert.That(result.ContainsKey("even digit"), Is.False);
        Assert.That(result.ContainsKey("odd digit"), Is.False);
    }

    [Test]
    public void Test_NoOddDigitsStringInput_ReturnsOnlyEvenDigitsAndNonDigitsCount()
    {
        // Arrange
        string input = "24a68b!";
        Dictionary<string, int> expected = new Dictionary<string, int>
        {
            { "even digit", 4 },     // 2, 4, 6, 8
            { "non-digit symbol", 3 } // a, b, !
        };

        // Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
        Assert.That(result["even digit"], Is.EqualTo(expected["even digit"]));
        Assert.That(result["non-digit symbol"], Is.EqualTo(expected["non-digit symbol"]));
        Assert.That(result.ContainsKey("odd digit"), Is.False);
    }

    [Test]
    public void Test_NoEvenDigitsStringInput_ReturnsOnlyOddDigitsAndNonDigitsCount()
    {
        // Arrange
        string input = "13a57b!";
        Dictionary<string, int> expected = new Dictionary<string, int>
        {
            { "odd digit", 4 },       // 1, 3, 5, 7
            { "non-digit symbol", 3 } // a, b, !
        };

        // Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
        Assert.That(result["odd digit"], Is.EqualTo(expected["odd digit"]));
        Assert.That(result["non-digit symbol"], Is.EqualTo(expected["non-digit symbol"]));
        Assert.That(result.ContainsKey("even digit"), Is.False);
    }

    [Test]
    public void Test_SymbolsEvenAndOddDigitsStringInput_ReturnsAllTypeOfCounts()
    {
        // Arrange
        string input = "a1b2c3d4!@#";
        Dictionary<string, int> expected = new Dictionary<string, int>
        {
            { "even digit", 2 },      // 2, 4
            { "odd digit", 2 },       // 1, 3
            { "non-digit symbol", 7 } // a, b, c, d, !, @, #
        };

        // Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));
        Assert.That(result["even digit"], Is.EqualTo(expected["even digit"]));
        Assert.That(result["odd digit"], Is.EqualTo(expected["odd digit"]));
        Assert.That(result["non-digit symbol"], Is.EqualTo(expected["non-digit symbol"]));
    }
}