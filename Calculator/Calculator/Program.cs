namespace Calculator
{
    class Program
    {
        static void main(String[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Add(2, 4));
            Console.WriteLine(math.Subtract(2, 4));
            Console.WriteLine(math.Multiply(2, 4));
            Console.WriteLine(math.Divide(2, 4));
        }
    }
}