using static Util.InputReader;

namespace Puzzles;

// --- Day 02: Phrase ---
public class Day02
{
    private readonly ITestOutputHelper output;

    public Day02(ITestOutputHelper output)
    {
        this.output = output;
    }

    private static int Problem1(string[] input)
    {
        return 0;
    }

    private static int Problem2(string[] input)
    {
        return 0;
    }

    [Fact]
    public void FirstStarTest()
    {
        var input = ReadLineInput();

        Assert.Equal(-1, Problem1(input));
    }

    [Fact]
    public void SecondStarTest()
    {
        var input = ReadLineInput();

        Assert.Equal(-1, Problem2(input));
    }

    [Fact]
    [Trait("Category", "Example")]
    public void FirstStarExample()
    {
        var exampleInput = ReadExampleLineInput("Example");

        Assert.Equal(-1, Problem1(exampleInput));
    }

    [Fact]
    [Trait("Category", "Example")]
    public void SecondStarExample()
    {
        var exampleInput = ReadExampleLineInput("Example");

        Assert.Equal(-1, Problem2(exampleInput));
    }
}
