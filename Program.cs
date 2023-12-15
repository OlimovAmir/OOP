
class Program
{
    enum Color
    {
        red,
        green,
        blue, 
        alpha
    }

    class Point
    {
        public int x;  // поля класса с модификатором доступа public
        public int y;
        public Color color;
    }
    static void Main(string[] args)
    {
        Point p = new Point();
        p.x = 1;
        p.y = 2;
        p.color = Color.red;

        Point p2 = new Point();
        p2.x = 3;
        p2.y = 4;
        p2.color = Color.green;

        Console.WriteLine($"X: {p.x} | Y: {p.y} | color: {p.color}");
        Console.WriteLine($"X: {p2.x} | Y: {p2.y} | color: {p2.color}");
    }
}