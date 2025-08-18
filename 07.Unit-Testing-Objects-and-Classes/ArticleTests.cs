using NUnit.Framework;

using System;
using System.Collections;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = new string[]
        {
            "Elon_Musk Instagram... Georgi_Hristov",
            "Car_maker_Stellantis The_company_behind_the_brands_Vauxhall... Rachel_Clun",
            "Title3 Content3 Author3"
        };

        // Act
        Article result = _article.AddArticles(articles);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Elon_Musk"));
        Assert.That(result.ArticleList[0].Content, Is.EqualTo("Instagram..."));
        Assert.That(result.ArticleList[0].Author, Is.EqualTo("Georgi_Hristov"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("The_company_behind_the_brands_Vauxhall..."));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        string[] articles = new string[]
       {
            "Title3 Content3 Author3",
            "Elon_Musk Instagram... Georgi_Hristov",
            "Car_maker_Stellantis The_company_behind_the_brands_Vauxhall... Rachel_Clun"
       };
        _article = _article.AddArticles(articles);

        string expected = $"Car_maker_Stellantis - The_company_behind_the_brands_Vauxhall...: Rachel_Clun" +
            $"{Environment.NewLine}Elon_Musk - Instagram...: Georgi_Hristov" +
            $"{Environment.NewLine}Title3 - Content3: Author3";

        // Act
        string result = _article.GetArticleList(_article, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] articles = new string[]
       {
            "Title3 Content3 Author3",
            "Elon_Musk Instagram... Georgi_Hristov",
            "Car_maker_Stellantis The_company_behind_the_brands_Vauxhall... Rachel_Clun"
       };
        _article = _article.AddArticles(articles);

        // Act
        string result = _article.GetArticleList(_article, "invalidCriteria");

        // Assert
        Assert.That(result, Is.Empty);
    }
}