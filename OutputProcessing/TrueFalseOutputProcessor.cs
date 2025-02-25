
// True/False output type processor implementation
public class TrueFalseOutputProcessor : IOutputTypeProcessor
{
    public string Process(string input)
    {
        return "True/False: " + input; // Example processing logic for True/False
    }

    public string OutputFormat()
    {
        return "True/False";
    }
}
