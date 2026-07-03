namespace DogsAtTheRaces;

public enum ParlorState
{
    Betting,
    Racing,
    Payout
}

/**
 * A record to standardize command registration
 */
public record CommandEntry(char Input, string Description);

/**
 * This class has been refactored to fit a CLI environment.
 * It is easily configurable by modifying the const values.
 */
public class BettingParlor
{
    private const int DogAmount = 4;
    private const int TrackLength =  35;
    
    private const int MinimumBet = 5;
    private const int MaximumBet = 15;
    
    private const double ProgressBarSize = 25.0;


    private readonly System.Timers.Timer _raceTick;
    private readonly List<Guy> _guys;
    private readonly List<Dog> _dogs;
    
    private int _winner;

    private ParlorState _state = ParlorState.Betting;
    
    public BettingParlor(List<Guy> guys)
    {
        _guys = guys;

        _dogs = [];
        for (int i = 0; i < DogAmount; i++)
        {
            _dogs.Add(new Dog(TrackLength));
        }

        _raceTick = new System.Timers.Timer(1000);
        _raceTick.Elapsed += OnRaceTick;
        _raceTick.AutoReset = true;
    }

    public void Start()
    {
        while (true)
        {
            switch (_state)
            {
                case ParlorState.Betting:
                    Betting();
                    break;
                case ParlorState.Racing:
                    Racing();
                    break;
                case ParlorState.Payout:
                    Payout();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private void Betting()
    {
        Console.Clear();
        char input = Input(
            "Options",
            new CommandEntry('b', "Bet"),
            new CommandEntry('s', "Start race")
        );

        switch (input)
        {
            case 'b':
                Bet();
                break;
            case 's':
                _state = ParlorState.Racing;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Racing()
    {
        if (!_raceTick.Enabled)
        {
            foreach (Dog dog in _dogs)
            {
                dog.TakeStartingPosition();
            }
            PrintDogs();
            _raceTick.Start();
        }
        Console.ReadLine();
    }

    private void Payout()
    {
        PrintDogs();
        Console.WriteLine($"Dog {_winner + 1} won!");
        foreach (Guy guy in _guys)
        {
            guy.Collect(_winner);
        }
        _state = ParlorState.Betting;
        Console.WriteLine("Press enter to continue..");
        Console.ReadLine();
    }

    private void OnRaceTick(object? sender, EventArgs e)
    {
        for (int i = 0; i < _dogs.Count; i++)
        {
            if (!_dogs[i].Run()) continue;

            _winner = i;
            _raceTick.Stop();
            _state = ParlorState.Payout;
            
            Console.WriteLine("Race ended! Press enter to continue..");
            return;
        }
        PrintDogs();
    }

    private void PrintDogs()
    {
        Console.Clear();
        for (int i = 0; i < _dogs.Count; i++)
        {
            Dog dog = _dogs[i];
            string bar = $"Dog {i + 1} - [";

            const double stepSize = TrackLength / ProgressBarSize;
            int steps = (int)(dog.Location / stepSize);

            for (int j = 0; j < ProgressBarSize; j++)
            {
                bar += j + 1 > steps ? '-' : '=';
            }

            Console.WriteLine(bar + ']');
        }
    }

    private void Bet()
    {
        Guy guy = _guys[Input("Which guy?", _guys)];

        if (guy.Money < MinimumBet)
        {
            Console.WriteLine($"{guy.Name} does not have enough money!");
            return;
        }
        
        int amount = Input("Choose bet amount", MinimumBet, MaximumBet);

        int dogIndex = Input("Choose which dog you want to be on", _dogs);
        
        guy.PlaceBet(amount, dogIndex);
        Console.WriteLine("Bet set");
    }

    private static int Input(string title, int minimum, int maximum)
    {
        Console.WriteLine(title);
        
        int input;
        bool success;
        do
        {
            Console.WriteLine($"Enter a value between {minimum} and {maximum}");
            success = int.TryParse(Console.ReadLine(), out input);
            ClearLine();
        } while (!success || input < minimum || input > maximum);

        return input;
    }

    private static char Input(string title, params List<CommandEntry> commands)
    {
        Console.WriteLine(title);
        foreach (CommandEntry command in commands)
        {
            Console.WriteLine($"[{command.Input}] - {command.Description}");
        }

        char input;
        do
        {
            Console.WriteLine("Choose a valid option");
            input = Console.ReadKey().KeyChar;
            ClearLine();
        } while (!commands.Select(command => command.Input).Contains(input));

        return input;
    }

    private static int Input<TItem>(string title, List<TItem> items)
        where TItem : class
    {
        Console.WriteLine(title);
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] - {items[i]}");
        }

        int input;
        bool success;
        do
        { 
            Console.WriteLine("Choose a valid option");
            success = int.TryParse(Console.ReadLine(), out input);
            input -= 1;
            ClearLine();
        } while (!success || input < 0 || input >= items.Count);

        return input;
    }
    
    private static void ClearLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
}
