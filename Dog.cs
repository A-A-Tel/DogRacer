namespace DogsAtTheRaces;

public class Dog
{
    private int _racetrackLength;
    public int Location { get; set; }

    private Random _randomizer;

    public Dog(int racetrackLength, Random randomizer)
    {
        _racetrackLength = racetrackLength;
        _randomizer = randomizer;
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