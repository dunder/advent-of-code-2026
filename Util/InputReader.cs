using System.Runtime.CompilerServices;

namespace Util;

public static class InputReader
{
    public static string[] ReadLineInput([CallerFilePath] string callerPath = "") => File.ReadAllLines(InputPath(callerPath));

    public static string[] ReadExampleLineInput(string exampleName, [CallerFilePath]string callerPath = "") => File.ReadAllLines(InputPath(callerPath, exampleName));

    public static string ReadInput([CallerFilePath]string callerPath = "") => File.ReadAllText(InputPath(callerPath)).TrimEnd();

    public static string ReadExampleInput(string exampleName, [CallerFilePath]string callerPath = "") => File.ReadAllText(InputPath(callerPath, exampleName)).TrimEnd();

    private static string InputPath(string callerPath, string fileNameAppendix = "")
    {
        string directory = Path.GetDirectoryName(callerPath) ?? throw new ArgumentException($"Could not determine the directory of '{callerPath}'", nameof(callerPath));

        return Path.Combine(directory, "Input", $"{Path.GetFileNameWithoutExtension(callerPath)}{fileNameAppendix}.txt");
    }
}