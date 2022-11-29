namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Shape(4);
            Shape triangle = new Shape(3);
            Shape circle = new Shape(0);

            Console.WriteLine(square.NoOfSides);
            Console.WriteLine(triangle.NoOfSides);
            Console.WriteLine(circle.NoOfSides);
        }
    }
}