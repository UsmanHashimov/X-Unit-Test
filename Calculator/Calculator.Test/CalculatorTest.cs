namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Test()
        {
            double x = 2; double y = 3;
            double res = x + y;
            double expectedRes = 5;
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Subtract_Test()
        {
            double x = 2;
            double y = 3;
            double res = x - y;
            double expectedRes = -1;
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Multiply_Test()
        {
            double x = 2;
            double y = 3;
            double res = x * y;
            double expectedRes = 6;
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Divide_Test() 
        {
            double x = 3;
            double y = 1;
            double res = x / y;
            double expectedRes = 3;
            Assert.Equal(expectedRes, res);
        }
    }
}