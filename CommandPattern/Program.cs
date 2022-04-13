using CommandPattern;

ICommand<Direction> command = new Command<Direction>(Move);

command.Execute(Direction.North);
command.Execute(Direction.East);
command.Execute(Direction.West);
command.Execute(Direction.South);

void Move(Direction direction)
{
    string? text = null;

    switch (direction)
    {
        case Direction.North:
            text = "Je vais vers le nord";
            break;
        case Direction.South:
            text = "Je vais vers le sud";
            break;
        case Direction.West:
            text = "Je vais vers l'ouest";
            break;
        case Direction.East:
            text = "Je vais vers l'est";
            break;
    }

    Console.WriteLine(text);
}
