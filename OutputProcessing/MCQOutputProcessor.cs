
// MCQ output type processor implementation
public class MCQOutputProcessor : IOutputTypeProcessor
{
    public string Process(string input)
    {
        return "MCQ: " + input; // Example processing logic for MCQ
    }

    public string OutputFormat()
    {
        return "MCQ";
    }
}
