using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //Arrange
        Dictionary<string, int> fruitDictionary = new()
        {
            { "apple", 5 },
            { "banana", 10 },
            { "orange", 30 }
        };
        string searchedFruit = "banana";
        int expected = 10;

        //Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitDictionary = new()
        {
            { "apple", 5 },
            { "banana", 10 },
            { "orange", 30 }
        };
        string searchedFruit = "grape";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitDictionary = new(); //нов празен речник
        string searchedFruit = "grape";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitDictionary = null;
        string searchedFruit = "grape";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitDictionary = new()
        {
            { "apple", 5 },
            { "banana", 10 },
            { "orange", 30 }
        };
        string searchedFruit = null;
        int expected = 0;


        //Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}