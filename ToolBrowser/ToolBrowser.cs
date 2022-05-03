namespace ToolBrowser;

internal class ToolBrowser : IToolBrowser
{
    public Task Execute()
    {
        DescribeTheProgram();

        return Task.CompletedTask;
    }

    private void DescribeTheProgram()
    {
        Console.WriteLine("Scrapes the websites of Victorinox and Leatherman");
        Console.WriteLine("to generate a static site that allows visitors");
        Console.WriteLine("to browse the tools in a fun and useful way.");
    }
}
