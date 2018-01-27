namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            RaceCar car1 = new RaceCar("Test 1");
            RaceCar car2 = new RaceCar("Test 2");
            StreetCar car3 = new StreetCar("Test 3");
            string str;
            race.AddRacer(car1);
            race.AddRacer(car2);
            race.AddRacer(car3);
            str = race.PrintRacers();
        }
    }
}
