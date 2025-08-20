using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }

    //преди всеки един тест се създава нов празен склад: _inventory

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //Arrange -> подготвихме си данните, с които ще добавяме продукт
        string name = "Bread";
        int quantity = 10;
        double price = 2.30;
        string expected = "Product Inventory:" + Environment.NewLine + "Bread - Price: $2.30 - Quantity: 10";

        //Act -> доабвяме дадения продукт към склада
        _inventory.AddProduct(name, price, quantity);

        //Assert
        //вариант 1:
        Assert.That(_inventory.DisplayInventory(), Does.Contain("Bread - Price: $2.30 - Quantity: 10"));
        //вариант 2:
        Assert.That(_inventory.DisplayInventory(), Is.EqualTo(expected));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expected = "Product Inventory:";

        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.30, 10);
        _inventory.AddProduct("Water", 1.40, 20);
        string expected = "Product Inventory:"
                           + Environment.NewLine
                           + "Bread - Price: $2.30 - Quantity: 10"
                           + Environment.NewLine
                           + "Water - Price: $1.40 - Quantity: 20";

        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        //вариант 1:
        Assert.That(result, Is.EqualTo(expected));
        //вариант 2:
        Assert.That(result, Does.Contain("Bread - Price: $2.30 - Quantity: 10"));
        Assert.That(result, Does.Contain("Water - Price: $1.40 - Quantity: 20"));

    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //Arrange
        double expected = 0;

        //Act
        double result = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.30, 10); //23 lv 
        _inventory.AddProduct("Water", 1.40, 20); //28 lv
        double expected = 51; //23 lv + 28 lv = 51 lv

        //Act
        double result = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}