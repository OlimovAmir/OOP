
class Program
{

    class Point
    {
        public int x;  // поля класса с модификатором доступа public
        public int y;
    }
    static void Main(string[] args)
    {
        Point p = new Point();

        p.x = 1;
        p.y = 2;

        Console.WriteLine(p.y);
        Console.WriteLine(p.x);
    }
}