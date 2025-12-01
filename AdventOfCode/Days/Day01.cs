namespace AdventOfCode.Days;

public class Day01 : BaseDay
{
    private readonly string[] _input;

    public Day01()
    {
        _input = File.ReadAllLines(InputFilePath);
    }

    public override ValueTask<string> Solve_1()
    {
        var count = 0;
        var value = 50;

        foreach (var rotation in _input)
        {
            if (rotation[0] == 'L')
            {
                value -= int.Parse(rotation[1..]);
            }
            else
            {
                value += int.Parse(rotation[1..]);
            }

            if (value % 100 == 0)
                count++;

        }

        return new($"{count}");
    }

    public override ValueTask<string> Solve_2()
    {
        var count = 0;
        var value = 50;

        foreach (var rotation in _input)
        {
            var increment = rotation[0] == 'L' ? 1 : -1;

            for (var i = 0; i < int.Parse(rotation[1..]); i++)
            {
                value += increment;

                if (value % 100 == 0)
                    count++;
            }

        }

        return new($"{count}");
    }
}
