namespace OOPTest
{
    internal abstract class Figure
    {
        public string Color { get; private set; }
        public Figure(string color)
        {
            Color = color;
        }
        public abstract void PrintInfo();
    }
}
