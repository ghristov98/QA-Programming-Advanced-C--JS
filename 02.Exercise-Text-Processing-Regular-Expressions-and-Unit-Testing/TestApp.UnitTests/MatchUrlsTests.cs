using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string input = "";

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string input = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it.";

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string input = "URL: http://alpha.judge.softuni.org";
        List<string> expected = new List<string>() { "http://alpha.judge.softuni.org" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string input = "URLs: http://alpha.judge.softuni.org, https://regex101.com, http://alpha.judge_softuni#20+=132.org end of text. ";

        List<string> expected = new List<string>();
        expected.Add("http://alpha.judge.softuni.org");
        expected.Add("https://regex101.com");
        expected.Add("http://alpha.judge_softuni#20+=132.org");

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsNotInQuotationMarks()
    {
        // Arrange
        string input = "URLs: \"http://alpha.judge.softuni.org\", \"https://regex101.com\" end of text. ";

        List<string> expected = new List<string>();
        expected.Add("http://alpha.judge.softuni.org");
        expected.Add("https://regex101.com");

        // Act
        List<string> result = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Is.EquivalentTo(expected));
    }
}