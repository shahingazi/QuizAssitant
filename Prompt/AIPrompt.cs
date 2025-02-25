
// AI prompt class to interact with AI for processing
using ConsoleApp.Quiz;

public class AIPrompt: IAIPrompt
{
    public string GetAnswer(string input)
    {
        // Simulate AI processing
        return "Processed by AI: " + input;
    }
}
