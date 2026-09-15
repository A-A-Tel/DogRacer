namespace DogsAtTheRaces;

public class Guy
{
    public string Name { get; }

    public int Money { get; private set; }

    private Bet? _bet;

    public Guy(string name, int money)
    {
        Name = name;
        Money = money;
    }

    public void ClearBet()
    {
        _bet = null;
    }

    public void PlaceBet(int amount, int dogIndex)
    {
        _bet = new Bet(amount, dogIndex, this);
    }

    public void Collect(int winner)
    {
        if (_bet is null) return;
        Money += _bet.Payout(winner);
    }

    public override string ToString()
    {
        string betString = _bet?.ToString() ?? "No bet"; 
        return $"{Name} - {betString} ({Money})";
    }
}