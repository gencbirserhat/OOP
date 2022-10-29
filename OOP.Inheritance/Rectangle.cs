namespace OOP.Inheritance
{
    public  class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y)
        {
              
        }
        public sealed override void Draw()
        {
            System.Console.WriteLine("Rectangle Drawing Task...");
            //base.Draw();
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated by Rectangle...");
        }
    }

    
}
