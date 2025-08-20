using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange -> подготовка на данните, с които ще работим
        Dictionary<string, int> dict1 = new(); //нов празен речник
        Dictionary<string, int> dict2 = new(); //нов празен речник

        //Act -> изпълняваме тествания метод с данните, които сме подготвили
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert -> проверка какво сме получили след изпълнението
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new(); //нов празен речник
        Dictionary<string, int> dict2 = new()
        {
            { "Desi", 4 },
            { "Pesho", 5 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Georgi", 1 },
            { "Aleks", 2 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Desi", 3 },
            { "Pesho", 4 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Georgi", 1 },
            { "Aleks", 2 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Georgi", 1 },
            { "Pesho", 4 }
        };

        Dictionary<string, int> expected = new()
        {
            { "Georgi", 1 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);
        //result:
        //"Georgi" -> 1

        //Assert
        //вариант 1: old
        Assert.That(result, Is.EqualTo(expected));
        //вариант 2: new
        Assert.That(result, Does.ContainKey("Georgi").And.ContainValue(1));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Georgi", 9 },
            { "Aleks", 2 }
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Georgi", 3 },
            { "Pesho", 4 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }
}