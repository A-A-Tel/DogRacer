namespace DogsAtTheRaces;

public class Bet
{
    private readonly int _amount;
    private readonly int _dogIndex;
    
    private readonly Guy _bettor;

    public Bet(int amount, int dogIndex, ref int balance, Guy bettor)
    {
        _amount = amount;
        _dogIndex = dogIndex;
        balance -= amount;
        _bettor = bettor;
    }

    public string GetDescription()
    {
        return $"{_bettor.Name} has placed {_amount} on dog {_dogIndex + 1}";
    }

    public int Payout(int winner)
    {
        return winner == _dogIndex ? _amount : 0;
    }

    public override string ToString()
    {
        return $"{_amount} on dog {_dogIndex + 1}";
    }
}