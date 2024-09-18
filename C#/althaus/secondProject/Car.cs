class Car
{
    public string Name;
    public string Colour;
    public int CurrentSpeed;
    private int OilLevcelPercent;
    public int wheelNum;

    public Car()
    {
        Name = "";
        CurrentSpeed = 0;
        Colour = "";
        OilLevcelPercent = 0;
        wheelNum = 4;
    }

    public void FillOil()
    {
        OilLevcelPercent = 100;
    }

    public void DecreaseOil()
    {
        OilLevcelPercent = OilLevcelPercent - 1;
    }

    public int getOilLevel()
    {
        return OilLevcelPercent;
    }

    public int setOilLevel(int oil)
    {
        OilLevcelPercent = oil;
        return oil;
    }

    public virtual void EngineNoise()
    {
        Console.WriteLine("Car noise");
    }
}

class Electric() : Car
{
    public override void EngineNoise()
    {
        Console.WriteLine("Eeeeeeeeee");
    }
}

class Petrol() : Car
{
    public override void EngineNoise()
    {
        Console.WriteLine("Vroom");
    }
}

class Diesel() : Car
{
    public override void EngineNoise()
    {
        Console.WriteLine("Brummmmm");
    }
}