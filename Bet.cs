namespace DogsAtTheRaces;

public class Bet
{
    private readonly int _amount;
    private readonly int _dogIndex;
    
    private readonly Guy _bettor;

    public Bet(int amount, int dogIndex, Guy bettor)
    {
        _amount = amount;
        _dogIndex = dogIndex;
        _bettor = bettor;
    }

    public string GetDescription()
    {
        return $"{_bettor.Name} has placed {_amount} on dog {_dogIndex + 1}";
    }

    public int Payout(int winner)
    {
        return winner == _dogIndex ? _amount * 2 : -_amount;
    }

    public override string ToString()
    {
        return $"{_amount} on dog {_dogIndex + 1}";
    }
}