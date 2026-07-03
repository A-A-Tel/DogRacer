namespace DogsAtTheRaces;

public class Dog
{
    private int _racetrackLength;
    public int Location { get; set; }

    private Random _randomizer = new();

    public Dog(int racetrackLength)
    {
        _racetrackLength = racetrackLength;
    }

    public bool Run()
    {
        Location += _randomizer.Next(1, 5);
        return Location >= _racetrackLength;
    }

    public void TakeStartingPosition()
    {
        Location = 0;
    }

    public override string ToString()
    {
        return "Dog";
    }
}