Vehicle angelosCar = new Vehicle("Toyota", "Camry", 2004, "Engine", "Land", 4);
Vehicle chrisSegway = new Vehicle("Segway", "miniPro", 2010, "Motors", "Land", 1);
Vehicle jacobsTruck = new Vehicle("Chevy", "Silverado 1500", 2012, "Engine", "Land", 6);

Vehicle[] classVehicles = { angelosCar, chrisSegway, jacobsTruck };

foreach (Vehicle vehicle in classVehicles)
{
    Console.WriteLine(vehicle.modelName);
}

chrisSegway.Drive("here");


Console.WriteLine($"{2,12:00#}");

class Vehicle
{
    public string ManufacturerName { get; private set; }
    public string modelName { get; private set; }
    public int year { get; private set; }

    public string propulsion { get; private set; }
    public string terrainPreference { get; private set; }
    public int capacity { get; private set; }

    public Vehicle()
    {
        modelName = "This needs a model name";
    }

    public Vehicle(string manufacturer, string model, int year, string propulsion, string terrain, int capacity)
    {
        ManufacturerName = manufacturer;
        modelName = model;
        this.year = year;
        this.propulsion = propulsion;
        terrainPreference = terrain;
        this.capacity = capacity;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address"></param>
    public void Drive(string address)
    {
        Console.WriteLine($"We've arrived at {address}");
    }
}