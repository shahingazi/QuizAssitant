namespace ConsoleApp.Quiz
{
    public class QuizAsistant
    {
        private readonly IFileConverter _fileConverter;
        private readonly IOutputTypeProcessor _outputTypeProcessor;
        private readonly IAIPrompt _aiPrompt;

        public QuizAsistant(IFileConverter fileConverter, IOutputTypeProcessor outputTypeProcessor, IAIPrompt aiPrompt)
        {
            _fileConverter = fileConverter;
            _outputTypeProcessor = outputTypeProcessor;
            _aiPrompt=aiPrompt;
        }

        public string ConvertToText(string filename)
        {
            return _fileConverter.Convert(filename);
        }
        public string ConvertOutput(string result)
        {
            return _outputTypeProcessor.Process(result);
        }
        public string GetOutputFormat()
        {
            return _outputTypeProcessor.OutputFormat();
        }
        public string GetPrompt(string input)
        {
            return _aiPrompt.GetAnswer(input);
        }
    }
}
