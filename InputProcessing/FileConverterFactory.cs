
// Update the FileConverterFactory to include PDF support
public static class FileConverterFactory
{
    public static IFileConverter GetConverter(string extension)
    {
        switch (extension.ToLower())
        {
            case ".txt":
                return new TextFileConverter();
            case ".pdf":
                return new PdfFileConverter();
            default:
                return new UnsupportedFileConverter();
        }
    }
}
