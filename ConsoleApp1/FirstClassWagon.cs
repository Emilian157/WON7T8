public class FirstClassWagon : PassengerWagon
{
    public FirstClassWagon(int seats) : base(seats)
    {
    }

    public void StartAirConditioning()
    {
        Console.WriteLine("Aerul conditionat din clasa I a fost pornit.");
    }

    public void StopAirConditioning()
    {
        Console.WriteLine("Aerul conditionat din clasa I a fost oprit.");
    }
}