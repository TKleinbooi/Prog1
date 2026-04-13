using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_POE
{
    internal class Chatbot
    {
        // ASCII Logo
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   _____                 _                     _             
  / ____|               | |                   | |            
 | |     _ __ ___  _   _| |__   ___  _ __ ___ | |__   ___    
 | |    | '_ ` _ \| | | | '_ \ / _ \| '_ ` _ \| '_ \ / _ \   
 | |____| | | | | | |_| | |_) | (_) | | | | | | |_) | (_) |  
  \_____|_| |_| |_|\__,_|_.__/ \___/|_| |_| |_|_.__/ \___/   

        CYBERSECURITY AWARENESS BOT
===========================================================
        ");

            Console.ResetColor();
        }

        // Get user name with validation
        public static string GetUserName()
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write(" Please enter a valid name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        // Typing effect (for extra marks)
        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        // Chat system
        public static void Chat(string name)
        {
            TypeEffect($"\nHi {name}, I’m your Cybersecurity Assistant. Ask me anything!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                // Input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Bot: ");
                Console.ResetColor();

                if (input.Contains("how are you"))
                {
                    Console.WriteLine("I'm just code, but I'm here to help you stay safe online 😄");
                }
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine("My purpose is to educate you about cybersecurity and keep you safe online.");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("Use strong passwords with uppercase, lowercase, numbers, and symbols. Never reuse them.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("Phishing is when attackers trick you into giving personal info. Always verify emails before clicking links.");
                }
                else if (input.Contains("link"))
                {
                    Console.WriteLine("Avoid clicking suspicious links. Always check the URL before opening.");
                }
                else if (input.Contains("safe browsing"))
                {
                    Console.WriteLine("Use secure websites (https), avoid public Wi-Fi for sensitive tasks, and keep your browser updated.");
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Stay safe online 👋");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                }
            }
        }
    }
}