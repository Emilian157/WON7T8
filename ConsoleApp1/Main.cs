class Program
{
    static void Main(string[] args)
    {
        Train train = new Train("Orient Express");

        //Partea I

        Locomotive locomotive = new Locomotive();
        train.AddWagon(locomotive);

        CargoWagon cargoWagon1 = new CargoWagon(CargoType.Cereals, 137.5);
        train.AddWagon(cargoWagon1);

        PassengerWagon passengerWagon1 = new PassengerWagon(83);
        train.AddWagon(passengerWagon1);

        FirstClassWagon firstClassWagon = new FirstClassWagon(26);
        train.AddWagon(firstClassWagon);

        train.DepartureFromStation();

        Console.WriteLine("Trenul isi incepe calatoria. CHU CHU");

        train.ArrivalAtStation();

        //Partea II

        train.GetTotalSeats();

        train.GetCargoSummary();

        
    }
}
