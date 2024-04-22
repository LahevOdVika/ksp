namespace alergie;

public class Person
{
    public string Name;
    public int Count;
    public int[] Alergens;

    public Person(string name, int count, int[] alergens)
    {
        this.Name = name;
        this.Count = count;
        this.Alergens = alergens;
    }


}