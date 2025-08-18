using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class StudentTests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new Student();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia", "Pesho Goshov 25 Plovdiv" };
        string expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";

        // Act
        string result = _student.AddAndGetByCity(students, "Sofia");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia", "Pesho Goshov 25 Plovdiv" };

        // Act
        string result = _student.AddAndGetByCity(students, "Pernik");

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        // Arrange
        string[] emptyArray = Array.Empty<string>();

        // Act
        string result = _student.AddAndGetByCity(emptyArray, "Varna");

        // Assert
        Assert.That(result, Is.Empty);
    }

    // Test not for Judge
    [Test]
    public void Test_StudentConstructor()
    {
        Assert.That(_student.FirstName, Is.Null);
        Assert.That(_student.LastName, Is.Null);
        Assert.That(_student.Age, Is.EqualTo(0));
        Assert.That(_student.Hometown, Is.Null);
    }
}