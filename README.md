
# Quiz Assistant

## Description
Quiz Assistant is a console application that processes files, converts their content, and interacts with an AI to generate responses based on the file content. It supports various file formats and output types.

## Features
- Convert file content to text
- Process text into different output formats
- Generate AI responses based on the processed text

## Getting Started

### Prerequisites
- .NET 8 SDK

### Installation
1. Clone the repository:
    git clone https://github.com/yourusername/yourproject.git
2. Navigate to the project directory:
3. Restore dependencies:
     dotnet restore
    
## Usage
1. Run the application:
    2. Follow the prompts to upload a file and specify the output type.

### Example

## Classes and Interfaces

### QuizAsistant
- `ConvertToText(string filename)`: Converts the content of the specified file to text.
- `ConvertOutput(string result)`: Processes the result into the specified output format.
- `GetOutputFormat()`: Retrieves the current output format.
- `GetPrompt(string input)`: Gets the AI response based on the input.

### IFileConverter
- `string Convert(string filename)`: Converts the file content to text.

### IOutputTypeProcessor
- `string Process(string input)`: Processes the input text.
- `string OutputFormat()`: Retrieves the output format.

### IAIPrompt
- `string GetAnswer(string input)`: Gets the AI response based on the input.

## Contributing
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
