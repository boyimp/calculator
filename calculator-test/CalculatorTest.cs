using Xunit;
using Calculator.UserDefiendClasses;
namespace calculator_test;

public class CalculatorTest
{
    [Fact]
    public void Sum() => Assert.Equal(10,new CalculatorController().sum(2,8));
    [Fact]
    public void Swap(){
        //Arrange
        double x = 5;
        double y = 10;
        //Act
        new CalculatorController().swap(ref x,ref y);
        //Assert
        Assert.Equal(10,x);
        Assert.Equal(5,y);
    }//func

    [Fact]
    public void Subtract1() => Assert.Equal(10,new CalculatorController().subtract(10,20));
    [Fact]
    public void Subtract2() => Assert.Equal(10,new CalculatorController().subtract(10,20));
}//class