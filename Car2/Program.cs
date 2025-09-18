namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ferrari = new Car("Ferrari", "Red", 350, 600, CarType.Gas);
            


            var volvo = new Car("Volvo", "Black", 250, 300, CarType.Hybrid);


            
            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();

            volvo.ShowInfo();
            volvo.Drive();
            volvo.Honk();
            volvo.Fuel();

            volvo.IsFasterThan(ferrari);


        }
    }
}
