using System;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Program.exe <-m|--msg|-$ <message>> [name <fullname>] [-?|-h|--help] [-u|--uppercase]
            CommandLineApplication commandLineApplication = new CommandLineApplication(throwOnUnexpectedArg: false);
            commandLineApplication.Name = "ddsmsg";
            commandLineApplication.HelpOption("-? | -h | --help");

            CommandOption message = commandLineApplication.Option(
                "-m |--message <message>",
                "The message to display. The message supports a format string.",
                CommandOptionType.SingleValue);

            CommandOption uppercase = commandLineApplication.Option(
                "-upp | --uppercase", "Display the message in uppercase.",
                CommandOptionType.NoValue);
            
            commandLineApplication.OnExecute(() =>
            {
                if (message.HasValue())
                {
                    Message(message.Value(), uppercase.HasValue());
                }
                return 0;
            });
            commandLineApplication.Execute(args);
        }

        private static void Message(string message, bool useUppercase)
        {
            Console.WriteLine((useUppercase)?(String)message.ToUpper():message);
        }
    }
}
