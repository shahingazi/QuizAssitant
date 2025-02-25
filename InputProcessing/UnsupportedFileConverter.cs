
// Unsupported file converter implementation
public class UnsupportedFileConverter : IFileConverter
{
    public string Convert(string filename)
    {
        return "Unsupported file type. Conversion not available.";
    }

    public string ConvertOutputFormat(string input)
    {
        return input; // No conversion for unsupported files
    }
}
