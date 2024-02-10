namespace Hierarchy;

class Place
{
    protected string name;

    public Place(string name)
    {
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Place: {name}");
    }
}

class Region : Place
{
    protected string climate;

    public Region(string name, string climate)
        : base(name)
    {
        this.climate = climate;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Climate: {climate}");
    }
}

class Metropolis : Region
{
    protected int population;

    public Metropolis(string name, string climate, int population)
        : base(name, climate)
    {
        this.population = population;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Population: {population}");
    }
}

class City : Metropolis
{
    protected string landmark;

    public City(string name, string climate, int population, string landmark)
        : base(name, climate, population)
    {
        this.landmark = landmark;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Landmark: {landmark}");
    }
}

class Program
{
    public static void PrintOrderedArray(Place[] places)
    {
        var orderedArray = places.OrderBy(place => place.GetType().Name);

        foreach (var place in orderedArray)
        {
            place.Show();
            Console.WriteLine();
        }
    }
}
