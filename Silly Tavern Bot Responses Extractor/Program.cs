using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Silly_Tavern_Bot_Responses_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            ChaLogManager  chamgr = new ChaLogManager();
            string inputPath = null;
            string outputPath = null;
            Boolean onlyBots=true;

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i].ToLower())
                {
                    case "--input":
                        if (i + 1 < args.Length) inputPath = args[i + 1];
                        i++;
                        break;
                    case "--output":
                        if (i + 1 < args.Length) outputPath = args[i + 1];
                        i++;
                        break;
                    case "--OnlyBot":
                        {
                            if (i + 1 < args.Length) onlyBots=Convert.
                                    ToBoolean( args[i + 1]);
                            i++;
                            break;
                        }
                }
            }

            if (string.IsNullOrWhiteSpace(inputPath)
                || string.IsNullOrWhiteSpace(outputPath))
            {
                Console.WriteLine("Usage: STBResponsesExtractor.exe --input <input.jsonl> --output <output.txt>");
                return;
            }

            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Input File doesnt exist: {inputPath}");
                return;
            }
            var messaages = chamgr.GetMessages(inputPath);
           var botMessages= chamgr.GetBotsResponses(messaages);
            if (onlyBots != false)
            {
                string text = chamgr.ExportMessagesToText(botMessages, true);
                Console.WriteLine(text);
                File.WriteAllText(outputPath, text, System.Text.Encoding.UTF8);
            }
            else
            {
                string text = chamgr.ExportAllMessagesToText(botMessages, false);
                Console.WriteLine(text);
                File.WriteAllText(outputPath, text, System.Text.Encoding.UTF8);
            }
            Console.WriteLine("Finished Presss Enter to Exit...");
            Console.ReadLine();
        }
    }
}
