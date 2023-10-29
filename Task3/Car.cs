namespace Task3
{
    internal class Car
    {
        string color;
        string type;
        int year;


        public Car(string color, string type, int year)
        {
            this.color = color;
            this.type = type;
            this.year = year;
        }
        public void Start()
        {
            Console.WriteLine("Автомобиль заведён");
        }
        public void TurnOff()
        {
            Console.WriteLine("Автомобиль заглушен");
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}

