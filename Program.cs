namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(12);

            stack.Push(5);
            stack.Push(7);
            stack.Push(2);
            stack.Push(9);

            stack.PrintAll();
            stack.PrintTop();
            stack.PrintCount();
            Console.WriteLine("**********************");
            stack.Pop();
            stack.PrintAll();
            stack.PrintTop();

        }
    }
}