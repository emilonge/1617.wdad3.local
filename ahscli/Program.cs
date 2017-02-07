using System;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Program.exe <-m|--msg|-$ <message>> [name <fullname>] [-?|-h|--help] [-u|--uppercase]
            CommandLineApplication commandLineApplication = new CommandLineApplication(throwOnUnexpectedArg: false);
            commandLineApplication.Name = "ahscli";
            commandLineApplication.HelpOption("-? | -h | --help");

            commandLineApplication.Command("msg", (command) =>
            {
                command.Description = "Print a message.";
                command.HelpOption("-?|-h|--help");

                var uppercaseOption = command.Option("-upp|--uppercae|",
                                "Display the message in uppercase.",
                                CommandOptionType.NoValue);

                var messageArgument = command.Argument("[message]",
                                       "The message to display. The message supports a format string.", false);

                command.OnExecute(() =>
                {
                    var message = String.IsNullOrEmpty(messageArgument.Value) ? "Hello earthling!" : messageArgument.Value;
                    
                    Message(message, uppercaseOption.HasValue());

                    Console.WriteLine();

                    return 0;
                });
            });

            commandLineApplication.Command("sys", (command) =>
            {
                command.Description = "Print the system information.";
                command.HelpOption("-?|-h|--help");

                command.OnExecute(() =>
                {   
                    SystemInformation();

                    Console.WriteLine();

                    return 0;
                });
            });

            commandLineApplication.Execute(args);
        }

        private static void Message(string message, bool useUppercase)
        {
            Console.WriteLine((useUppercase)?(String)message.ToUpper():message);
        }

        private static void SystemInformation()
        {
            var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var isOSX = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            var isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            var os = "Unknown";

            if(isWindows) 
            {
                os = "Windows";
            }
            else if(isOSX) 
            {
                os = "OSX";
            }
            if(isLinux) 
            {
                os = "Linus";
            }

            Console.WriteLine($@"
Runtime:
    OS:              {os}
    OS Description:  {RuntimeInformation.OSDescription}
    OS Architecture: {RuntimeInformation.OSArchitecture}
    Process:         {RuntimeInformation.ProcessArchitecture}
    Framework:       {RuntimeInformation.FrameworkDescription}"
            );
            var ae = PlatformServices.Default.Application;
            Console.WriteLine($@"
IApplicationEnvironment:
    Base Path:      {ae.ApplicationBasePath}
    App Name:       {ae.ApplicationName}
    App Version:    {ae.ApplicationVersion}
    Runtime:        {ae.RuntimeFramework}"
            );
            Console.WriteLine($@"
Environment:
    Machine name:    {System.Environment.MachineName}
    Processors:      {System.Environment.ProcessorCount}"
            );
        }
    }
}
