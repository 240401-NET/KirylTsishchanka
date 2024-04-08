//using System.ComponentModel.DataAnnotations;
//using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Syllabus.Tests;

public class UnitTest1
    {
    //This is a theory test, with InlineData
    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0)]
    [InlineData(10, 10, 10, 10, 10, 12.25)]
    [InlineData(50, 50, 50, 50, 50, 56.25)]
    [InlineData(90, 90, 90, 90, 90, 92.25)]
    [InlineData(100, 100, 100, 100, 100, 100)]
    public void Check_Grade_Calculator(
        double attendance, 
        double quiz, 
        double midterm1, 
        double midterm2, 
        double finalExam,
        double expected)
    {

        //Act
        double result = LogicStudent.GradeCalculatorPlus(attendance, quiz, midterm1, midterm2, finalExam);

        //Assert
        Assert.Equal(expected, result);

    }
    }