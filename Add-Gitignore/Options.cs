using CommandLine;

namespace Add_Gitignore;

public class Options
{
    [Value(0, MetaName = "A list of strings", Min = 1, HelpText = "Provide a list of technologies you want to ignore. For example: macos vscode")]
    public IEnumerable<string> Ignore { get; set; } = Enumerable.Empty<string>();
}