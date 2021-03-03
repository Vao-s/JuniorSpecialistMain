namespace EnumerableEnumeratorTest
{
    public class Car
    {
        public string carName;
        public Car(string carName)
        {
            this.carName = carName;
        }

        public override string ToString()
        {
            return $"Car: {carName}";
        }
    }

}
