namespace PrivateMultipleObjects;

public class Club
{
    private string _clubName;
    private int _establishedYear;
    private int _memberCount;

    public Club()
    {
        _clubName = string.Empty;
        _establishedYear = 0;
        _memberCount = 0;
    }

    public Club(string name, int year, int members)
    {
        _clubName = name;
        _establishedYear = year;
        _memberCount = members;
    }

    public string GetClubName()
    {
        return _clubName;
    }

    public void SetClubName(string name)
    {
        _clubName = name;
    }

    public int GetEstablishedYear()
    {
        return _establishedYear;
    }

    public void SetEstablishedYear(int year)
    {
        _establishedYear = year;
    }

    public int GetMemberCount()
    {
        return _memberCount;
    }

    public void SetMemberCount(int members)
    {
        _memberCount = members;
    }

    public virtual void addChange()
    {
        Console.Write("Club Name=");
        SetClubName(Console.ReadLine());
        Console.Write("Establishment Year=");
        SetEstablishedYear(int.Parse(Console.ReadLine()));
        Console.Write("Membership Count=");
        SetMemberCount(int.Parse(Console.ReadLine()));
    }

    public virtual void print()
    {
        Console.WriteLine();
        Console.WriteLine($"Club Name: {GetClubName()}");
        Console.WriteLine($"Establishment Year: {GetEstablishedYear()}");
        Console.WriteLine($"Members: {GetMemberCount()}");
    }
}

public class GamingClub : Club
{
    private string _gamingPlatform;
    private int _gameCount;

    public GamingClub()
    {
        _gamingPlatform = string.Empty;
        _gameCount = 0;
    }

    public GamingClub(string name, int year, int members, string platform, int games)
        : base(name, year, members)
    {
        _gamingPlatform = platform;
        _gameCount = games;
    }

    public string GetGamingPlatform()
    {
        return _gamingPlatform;
    }

    public void SetGamingPlatform(string platform)
    {
        _gamingPlatform = platform;
    }

    public int GetGameCount()
    {
        return _gameCount;
    }

    public void SetGameCount(int games)
    {
        _gameCount = games;
    }

    public override void addChange()
    {
        base.addChange();
        Console.Write("Gaming Platform=");
        SetGamingPlatform(Console.ReadLine());
        Console.Write("Game Count=");
        SetGameCount(int.Parse(Console.ReadLine()));
    }

    public override void print()
    {
        base.print();
        Console.WriteLine($"Gaming Platform: {GetGamingPlatform()}");
        Console.WriteLine($"Game Count: {GetGameCount()}");
    }
}

class Program
{
    static void Main()
    {
        Club[] clubs = new Club[2];
        clubs[0] = new Club("Book Club", 2000, 50);
        clubs[1] = new GamingClub("Gamer's Club", 2010, 100, "PC", 30);

        foreach (var club in clubs)
        {
            club.print();
            club.addChange();
            Console.WriteLine("-------------");
        }
    }
}