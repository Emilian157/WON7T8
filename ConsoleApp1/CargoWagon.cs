public class CargoWagon
{
    private CargoType CargoType;
    private double CapacityInTons;

    public CargoWagon(CargoType type, double capacity)
    {
        CargoType = type;
        CapacityInTons = capacity;
    }

    public double GetCapacityInTons()
    {
        return CapacityInTons;
    }

    public CargoType GetCargoType()
    {
        return CargoType;
    }
}