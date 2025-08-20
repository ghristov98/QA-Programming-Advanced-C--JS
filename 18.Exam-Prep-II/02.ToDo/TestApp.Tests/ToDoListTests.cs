using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;

    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }


    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        //Arrange
        string title = "Go shopping";
        DateTime dueDate = DateTime.Now.AddDays(2); 

        //Act
        _toDoList.AddTask(title, dueDate);

        //Assert
        Assert.That(_toDoList.DisplayTasks(), Does.Contain("[ ] Go shopping - Due: " + dueDate.ToString("MM/dd/yyyy")));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        //Arrange
        string title = "Go shopping"; 
        DateTime dueDate = DateTime.Now.AddDays(2); 
        _toDoList.AddTask(title, dueDate);

        //Act
        _toDoList.CompleteTask(title);

        //Assert
        Assert.That(_toDoList.DisplayTasks(), Does.Contain("[✓] Go shopping - Due: " + dueDate.ToString("MM/dd/yyyy")));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        //Arrange
        string title = "Go shopping"; 
        DateTime dueDate = DateTime.Now.AddDays(2); 
        _toDoList.AddTask(title, dueDate);

        //Act and Assert
        Assert.That(() => _toDoList.CompleteTask("Read book"), Throws.ArgumentException);

    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        //Arrange
        string expected = "To-Do List:";

        //Act
        string result = _toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        //Arrange
        _toDoList.AddTask("Read Book", DateTime.Now.AddDays(2));
        _toDoList.AddTask("Cook Dinner", DateTime.Now.AddDays(1));

        //Act
        string result = _toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Does.Contain("To-Do List:"));
        Assert.That(result, Does.Contain("[ ] Read Book - Due: "));
        Assert.That(result, Does.Contain("[ ] Cook Dinner - Due: "));
    }
}