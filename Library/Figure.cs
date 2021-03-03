namespace Library
{
    public abstract partial class Figure
    {
        public string Color { get; private set; }

        public Figure(string color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
