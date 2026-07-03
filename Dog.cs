namespace DogsAtTheRaces;

public class Dog
{
    private int _racetrackLength;
    private int _location;

    private Random _randomizer = new();

    public Dog(int racetrackLength)
    {
        _racetrackLength = racetrackLength;
    }

    public bool Run()
    {
        _location += _randomizer.Next(1, 5);
        return _location >= _racetrackLength;
    }

    public void TakeStartingPosition()
    {
        _location = 0;
    }

    public override string ToString()
    {
        return "Dog";
    }
}