namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();
            ferrari.Brand = "Ferrari";
            ferrari.Color = "Red";
            ferrari.MaxSpeed = 350;
            ferrari.HorsePower = 600;
            ferrari.CarType = CarType.Gas;


            Car volvo = new Car();
            volvo.Brand = "Volvo";
            volvo.Color = "Black";
            volvo.MaxSpeed = 250;
            volvo.HorsePower = 300;
            volvo.CarType = CarType.Hybrid;

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
