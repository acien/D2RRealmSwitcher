using System;
using Microsoft.Win32;

namespace D2RRealmSwitcher
{
    class Program
    {
        static void Main(string[] args)
        {
            const string keyName = "HKEY_CURRENT_USER\\Software\\Blizzard Entertainment\\Battle.net\\Launch Options\\OSI";
            string region = (string)Registry.GetValue(keyName, "REGION", "Could not find the Region key");
            Console.WriteLine("Current Region is: {0}", region);
            Console.WriteLine("1) NA = North America");
            Console.WriteLine("2) EU = Europe");
            Console.WriteLine("3) KR = Asia");
            Console.WriteLine("Please enter a number to switch regions or anything else to exit:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Registry.SetValue(keyName, "REGION", "NA");
                    break;

                case "2":
                    Registry.SetValue(keyName, "REGION", "EU");
                    break;

                case "3":
                    Registry.SetValue(keyName, "REGION", "KR");
                    break;
                default:
                    break;
            }

        }
    }
}
