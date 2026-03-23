using CalculatorConsole;

public class CalculatorConsoleUnitTests
{
    Calculator calculator = new Calculator();
    [Fact]
    public void TestAddition()
    {
        int result = calculator.Addition(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestSubtraction()
    {
        int result = calculator.Subtraction(5, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void TestMultiplication()
    {
        int result = calculator.Multiplication(4, 3);
        Assert.Equal(12, result);
    }
    [Fact]
    public void TestDivision()
    {
        int result = calculator.Division(10, 2);
        Assert.Equal(5, result);
    }
    [Fact]
    public void TestDivisionByZero()
    {
        int result = calculator.Division(10, 0);
        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData(5)]
    public void TestForExit(double input)
    {
        Assert.True(input == 5);
    }

    [Theory]
    [InlineData(6)]
    [InlineData(-1)]
    [InlineData(-10)]
    [InlineData(0)]
    public void TestForInvalidInput(double input)
    {
        Assert.True(input > 5 || input <= 0);
    }

}
