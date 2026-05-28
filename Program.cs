using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

class SecurityChatBot
{
    private static string userInput = "";

    [STAThread]
    static void Main(string[] args)
    {
        // If user passes "console" as first arg, run original console UI
        if (args.Length > 0 && args[0].Equals("console", StringComparison.OrdinalIgnoreCase))
        {
            RunConsoleMode();
            return;
        }

        ApplicationConfiguration.Initialize();
        Application.Run(new ChatForm());
    }

    static void RunConsoleMode()
    {
        DisplayBanner();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Hello! And welcome to the Information Security ChatBot! I am your chatbot, Cynthia.");
        Console.WriteLine(" Ask me about Information Security topics (type 'exit' to quit).\n");
        Console.ResetColor();

        Console.WriteLine("Before we get started, please enter your name:");
        string userName = Console.ReadLine() ?? "User";
        Console.WriteLine($"Welcome, {userName}! Ask me about cybersecurity topics.");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nYou: ");
            userInput = Console.ReadLine() ?? "";

            if (userInput.ToLower() == "exit")
                break;

            string response = fetchResponse(userInput);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cynthia: " + response);
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cynthia: I didn't catch that. Please type a question about cybersecurity.");
                Console.ResetColor();
                continue;
            }
        }
    }

    static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(33);
        }
        Console.WriteLine();
    }

    static void DisplayBanner()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("========================================");
        Console.WriteLine("   ____        __        __             ");
        Console.WriteLine("  / ___|  ___  \\ \\      / /  ___   _ __ ");
        Console.WriteLine("  \\___ \\ / _ \\  \\ \\ /\\ / /  / _ \\ | '__|");
        Console.WriteLine("   ___) | (_) |  \\ V  V /  | (_) || |   ");
        Console.WriteLine("  |____/ \\___/    \\_/\\_/    \\___/ |_|   ");
        Console.WriteLine("                                        ");
        Console.WriteLine("   Welcome to InfoSec ChatBot!          ");
        Console.WriteLine("========================================");
        Console.ResetColor();
    }

    static string fetchResponse(string input)
    {
        return GetResponse.GetResponseMessage(input);
    }
}
