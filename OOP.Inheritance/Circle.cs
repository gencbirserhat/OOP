namespace OOP.Inheritance
{
    public class Circle : Shape
    {

        public Circle()
        {

        }
        public Circle(int x, int y) : base(x, y)
        {

        }
        public override void Draw()
        {
            System.Console.WriteLine("Circle Drawing Task...");
            //base.Draw();
        }
    }
}
