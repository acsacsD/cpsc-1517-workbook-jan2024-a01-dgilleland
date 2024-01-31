﻿namespace AssortedDemos.Specs;
using Assorted;

public class Angle_Should
{
    [Fact]
    public void Construct_From_Degrees_Value()
    {
        // Arrange
        double given = 45;
        // Act
        Angle actual = new(given);
        // Assert
        actual.Degrees.Should().Be(given);
    }

    [Fact]
    public void Allow_Degreees_To_Be_Changed()
    {
        // Arrange
        Angle sut = new(45);
        // Act
        sut.Degrees = 90;
        // Assert
        sut.Degrees.Should().Be(90);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(180, Math.PI)]
    public void Calculate_Angle_In_Radians(double givenDegrees, double expectedRadians)
    {
        // Arrange
        Angle sut = new(givenDegrees);
        // Act
        double actual = sut.Radians;
        // Assert
        actual.Should().Be(expectedRadians);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(180, 200)]
    public void Calculate_Angle_In_Grads(double givenDegrees, double expectedGrads)
    {
        // Arrange
        Angle sut = new(givenDegrees);
        // Act
        double actual = sut.Grads;
        // Assert
        actual.Should().Be(expectedGrads);
    }
}
