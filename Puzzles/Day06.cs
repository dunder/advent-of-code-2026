using static Util.InputReader;

namespace Puzzles;

// --- Day 06: Phrase ---
public class Day06
{
    private readonly ITestOutputHelper output;

    public Day06(ITestOutputHelper output)
    {
        this.output = output;
    }

    private static int Problem1(IList<string> input)
    {
        return 0;
    }

    private static int Problem2(IList<string> input)
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
