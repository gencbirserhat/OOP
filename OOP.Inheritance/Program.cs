namespace OOP.Inheritance
{
    class Program
    {
        static void Main()
        {
            polymorphzm();
            var s1 = new Rectangle(10, 20);
            var s2 = new Circle(155, 220);
            var s3 = new Square(5, 5);
            Console.WriteLine("{0},{1}", s1.X, s1.Y);
            Console.WriteLine("{0},{1}", s2.X, s2.Y);
            Console.WriteLine("{0},{1}", s3.X, s3.Y);
            s1.WorkWithDifferentObject(s3);
            Console.ReadKey();
        }

        private static void polymorphzm()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle(),
                new Square(),

            };

            foreach (var shape in shapes)
            {
                shape.Draw();

            }
            new Square().Calculate();
        }

        private static void virtualkeyword()
        {
            var _s1 = new Rectangle();
            var _s2 = new Circle();

            _s1.X = 10;
            _s1.Y = 100;
            Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
            _s1.Draw();

            _s2.X = 5;
            _s2.Y = 55;
            Console.WriteLine("{0},{1}", _s2.X, _s2.Y);
            _s2.Draw();

            new Triangle().Draw();
        }
    }
}
