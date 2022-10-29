namespace OOP.Inheritance
{
    public class Triangle : Shape  
    {
        public Triangle()
        {

        }
        public Triangle(int x, int y)
        {

        }
        public override void Draw()
        {
            System.Console.WriteLine("Triangle Drawing Task...");
            base.Draw();
        }
    }
}
