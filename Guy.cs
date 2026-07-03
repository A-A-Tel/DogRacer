namespace DogsAtTheRaces;

public class Guy
{
    public string Name { get; private set; }

    public int Money => _money;

    private int _money;
    
    private Bet? _bet;

    public Guy(string name, int money)
    {
        Name = name;
        _money = money;
    }

    public void ClearBet()
    {
        _bet = null;
    }

    public void PlaceBet(int amount, int dogIndex)
    {
        _bet = new Bet(amount, dogIndex, ref _money, this);
    }

    public void Collect(int winner)
    {
        
    }

    public override string ToString()
    {
        string betString = _bet?.ToString() ?? "No bet"; 
        return $"{Name} - {betString} ({Money})";
    }
}