namespace DogsAtTheRaces;
/**
 * This file is the replacement for the all UI systems
 */


public enum ParlorState
{
    Betting,
    Racing,
    Payout
}

public class BettingParlor
{
    private ParlorState _state = ParlorState.Betting;
    private Dog[] _dogs;
    private Guy[] _guys;
    
    public BettingParlor(Dog[] dogs, Guy[] guys)
    {
        _dogs = dogs;
        _guys = guys;
    }

    public void Start()
    {
        
    }
    
    
}
