using Prog_POE;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Play voice greeting
        AudioPlayer.PlayGreeting();

        // Display ASCII logo
        Chatbot.DisplayLogo();

        // Get user name
        string name = Chatbot.GetUserName();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nWelcome, {name}!");
        Console.ResetColor();

        // Start chatbot
        Chatbot.Chat(name);
    }
}