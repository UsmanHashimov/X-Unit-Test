namespace Calculator.Test
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator = new Calculator();
    
        [Theory]
        [InlineData(5, 2, 7)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        public void Add_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 0, 0)]
        public void Subtract_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 0, 0)]
        public void Multiply_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 1, 0)]
        public void Divide_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }
    }
}
