using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "cat", "bear" };
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "quick", "lazy" };
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The ***** brown fox jumps over the **** dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] emptyArray = Array.Empty<string>();
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(emptyArray, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "lazy dog" };
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the ********";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}