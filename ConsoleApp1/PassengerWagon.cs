public class PassengerWagon
{
    private int NumberOfSeats;
    public PassengerWagon(int seats)
    {
        NumberOfSeats = seats;
    }

    public void CloseDoors()
    {
        Console.WriteLine("Usile pasagerilor sunt inchise");
    }

    public void OpenDoors()
    {
        Console.WriteLine("Usile pasagerilor sunt deschise");
    }

    public int GetNumberOfSeats()
    {
        return NumberOfSeats;
    }
    }