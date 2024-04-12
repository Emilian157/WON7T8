//Partea I

public class Train
{
    private string name;
    private List<object> wagons = new List<object>();

    public Train(string name)
    {
        this.name = name;
    }

    public void AddWagon(object wagon)
    {
        wagons.Add(wagon);
    }

    public void DepartureFromStation()
    {
        foreach (var wagon in wagons)
        {
            if (wagon is PassengerWagon passengerWagon)
            {
                passengerWagon.CloseDoors();
            }
            else if (wagon is Locomotive locomotive)
            {
                locomotive.Start();
            }
            if (wagon is FirstClassWagon firstClassWagon)
            {
                firstClassWagon.StartAirConditioning();
            }
        }
    }

    public void ArrivalAtStation()
    {
        foreach (var wagon in wagons)
        {
            if (wagon is PassengerWagon passengerWagon)
            {
                passengerWagon.OpenDoors();
            }
            else if (wagon is Locomotive locomotive)
            {
                locomotive.Stop();
            }
            if (wagon is FirstClassWagon firstClassWagon)
            {
                firstClassWagon.StopAirConditioning();
            }
        }
    }

    //Partea II

    private int TotalSeats()
    {
        int totalSeats = 0;

        foreach (var wagon in wagons)
        {
            if (wagon is PassengerWagon || wagon is FirstClassWagon)
            {
                if (wagon is PassengerWagon passengerWagon)
                {
                    totalSeats += passengerWagon.GetNumberOfSeats();
                }
                else if (wagon is FirstClassWagon firstClassWagon)
                {
                    totalSeats += firstClassWagon.GetNumberOfSeats();
                }
            }
        }

        return totalSeats;
    }

    public void GetTotalSeats()
    {
        int totalSeats = TotalSeats();
        Console.WriteLine($"Numarul total de locuri in tren: {totalSeats}");
    }

    private List<string> CargoSummary()
    {
        List<string> cargoSummary = new List<string>();

        foreach (var wagon in wagons)
        {
            if (wagon is CargoWagon cargoWagon)
            {
                string cargoInfo = $"Type: {cargoWagon.GetCargoType()}, Capacity: {cargoWagon.GetCapacityInTons()} tons";
                cargoSummary.Add(cargoInfo);
            }
        }

        return cargoSummary;
    }

    public void GetCargoSummary()
    {
        var cargoSummary = CargoSummary();
        Console.WriteLine("Sumar al vagonului de marfa:");
        foreach (var cargo in cargoSummary)
        {
            Console.WriteLine(cargo);
        }
    }

}