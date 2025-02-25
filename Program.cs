using ConsoleApp.Quiz;
using System;
using System.Drawing;
using System.IO;
class Program
{
    // Main method to handle file conversion and AI processing
    static void Main()
    {
        Console.WriteLine("Upload file:");
        var filename = Console.ReadLine();

        Console.WriteLine("Output type");
        var outputType = Console.ReadLine();

        // Extract file name extension
        var extension = Path.GetExtension(filename);

        // Get appropriate file converter based on extension
        IFileConverter converter = FileConverterFactory.GetConverter(extension);
        // Get appropriate output type processor
        IOutputTypeProcessor outputProcessor = OutputTypeFactory.GetProcessor(outputType);
        // Process the converted text with AI
        IAIPrompt aiPrompt = new AIPrompt();     

        QuizAsistant quizAsistant = new QuizAsistant(converter, outputProcessor, aiPrompt);
        var text= quizAsistant.ConvertToText(filename);
        Console.WriteLine(text);
        var outputFormat = quizAsistant.GetOutputFormat();
        Console.WriteLine(outputFormat);
        var aiResult = quizAsistant.GetPrompt(outputFormat + text);
        var processedOutput = quizAsistant.ConvertOutput(aiResult);
        Console.WriteLine(processedOutput);
        
    }
}
