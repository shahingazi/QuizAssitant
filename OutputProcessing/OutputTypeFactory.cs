
// Output type factory to get appropriate processor
public static class OutputTypeFactory
{
    public static IOutputTypeProcessor GetProcessor(string outputType)
    {
        switch (outputType.ToLower())
        {
            case "mcq":
                return new MCQOutputProcessor();
            case "truefalse":
                return new TrueFalseOutputProcessor();
            case "summary":
                return new SummaryOutputProcessor();
            default:
                return new UnsupportedOutputProcessor();
        }
    }
}
