using Microsoft.Win32;
using System;
using System.Runtime.Versioning;

// Task - Create Registry commands to edit language, font and theme inside the program.

namespace RegistryControl
{
    // specify supported version
    [SupportedOSPlatform("windows")]
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey programKey = key.CreateSubKey("NewProgram");

            // create language and font subkeys with data
            programKey.SetValue("language", "UK");
            programKey.SetValue("language", "UA");

            programKey.SetValue("font", "18");
            programKey.SetValue("font", "20");

            Console.WriteLine("Languages available: UA, UK. \nType the language you wish to choose:");
            string language = Console.ReadLine();

            if (language == "UK")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\NewProgram", "language", "UK");
                Console.WriteLine("UK is chosen.");
            }
            else if (language == "UA")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\NewProgram", "language", "UA");
                Console.WriteLine("UA is chosen.");
            }
            else
            {
                Console.WriteLine("Error.");
                return;
            }

            Console.WriteLine("Font sizes available: 18, 20. \nChoose the font:");
            string font = Console.ReadLine();

            if (font == "18")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\NewProgram","font", 18);
                Console.WriteLine("Font size is 18.");
            }
            else if (font == "20")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\NewProgram","font", 20);
                Console.WriteLine("Font size is 20.");
            }
            else
            {
                Console.WriteLine("Error.");
                return;
            }

            // light/dark mode
            programKey.SetValue("lightMode", 0);

            int res = (int)Registry.GetValue(
                keyName: @"HKEY_CURRENT_USER\NewProgram",
                "lightMode", null);
            Console.WriteLine("0 if Light mode isn't used and 1 if used. \nCurrent satus:" + res);

            Console.WriteLine("Type 1 to set Light mode or other button to exit : ");
            int input = Console.Read();

            if (input == 1)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\NewProgram","lightMode", 1);
            }
            else
            {
                return;
            }
        }
    }
}
