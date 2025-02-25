
// Summary output type processor implementation
public class SummaryOutputProcessor : IOutputTypeProcessor
{
    public string Process(string input)
    {
        return "Summary: " + input; // Example processing logic for Summary
    }

    public string OutputFormat()
    {
        return "Summary";
    }
}
