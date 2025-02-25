
// Unsupported output type processor implementation
public class UnsupportedOutputProcessor : IOutputTypeProcessor
{
    public string Process(string input)
    {
        return "Unsupported output type."; // No processing for unsupported output types
    }

    public string OutputFormat()
    {
        return "Unsupported";
    }
}
