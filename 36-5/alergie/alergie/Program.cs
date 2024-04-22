using alergie;

StreamReader sr = new StreamReader("C:\\Users\\Lahev\\Desktop\\ksp\\36-5\\alergie\\05.in");
StreamWriter sw = new StreamWriter("C:\\Users\\Lahev\\Desktop\\ksp\\36-5\\alergie\\vystup.txt");

int[] radek = sr.ReadLine().Split(' ').Select(num => int.Parse(num.ToString())).ToArray();
int N = radek[0];
int L = radek[1];
Person[] people = new Person[N];
Location[] locations = new Location[L];

int maxPeople = 0;
string locationName = "";

for (int i = 0; i < N; i++)
{
    string name = sr.ReadLine();
    int count = Convert.ToInt32(sr.ReadLine());
    int[] alergens = sr.ReadLine().Split(' ').Select(num => int.Parse(num.ToString())).ToArray();
    people[i] = new Person(name, count, alergens);
}

for (int i = 0; i < L; i++)
{
    string name = sr.ReadLine();
    int count = Convert.ToInt32(sr.ReadLine());
    int[] alergens = sr.ReadLine().Split(' ').Select(num => int.Parse(num.ToString())).ToArray();
    locations[i] = new Location(name, count, alergens, 0);

    for (int j = 0; j < people.Length; j++)
    {
        if (!people[j].Alergens.Intersect(locations[i].Alergens).Any())
        {
            locations[i].peopleCount++;
        }
    }
}

foreach (var location in locations)
{
    if (location.peopleCount > maxPeople)
    {
        maxPeople = location.peopleCount;
        locationName = location.Name;
    }
}

Console.WriteLine("{0} {1}", maxPeople, locationName);
sw.WriteLine("{0} {1}", maxPeople, locationName);
sw.Flush();