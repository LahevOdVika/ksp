namespace alergie;

public class Location
{
    public string Name;
    public int Count;
    public int[] Alergens;
    public int peopleCount;

    public Location(string name, int count, int[] alergens, int peopleCount)
    {
        this.Name = name;
        this.Count = count;
        this.Alergens = alergens;
        this.peopleCount = peopleCount;
    }
}