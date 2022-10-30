namespace OOP.Interfaces.LooselyCoupled
{

    class Program
    {
        static void Main()
        {
            var stack = new Stack(new LinkedListStack());

            stack.Pop();
            stack.Push(5);
        }
    }
}