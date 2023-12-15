
using OOP;

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
    };

    
   
    static Student GetStudent() {
        OOP.Student student = new OOP.Student();


        student.lastName = "Amir";
        student.firstName = "Olimov";
        student.middleName = "Muhamadaminovich";
        student.age = 36;
        student.Id = Guid.NewGuid();
        student.group = Group.IT;

        return student; 
    }

    static void Print(Student student)
    {
        Console.WriteLine("info obout Student");
        Console.WriteLine($"ID: {student.Id}");
        Console.WriteLine($"lastName: {student.lastName}");
        Console.WriteLine($"firstName: {student.firstName}");
        Console.WriteLine($"middleName: {student.middleName}");
        Console.WriteLine($"age: {student.age}");
        Console.WriteLine($"group: {student.group}");
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

        var student = GetStudent();

        Print(student);
    }
}