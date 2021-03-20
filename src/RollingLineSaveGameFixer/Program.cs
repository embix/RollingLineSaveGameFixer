using System;
using System.IO;

namespace RollingLineSaveGameFixer
{
    class Program
    {
        static void Main(String[] args)
        {
            if (args.Length!=1)
            {
                PrintUsage();
                return;
            }
            TryFixFile(args[0]);
        }

        static void PrintUsage()
        {
            Console.WriteLine("Usage: RollingLineSaveGameFixer filename");
        }

        static void TryFixFile(String fullFileName)
        {
            var rawSave = File.ReadAllText(fullFileName);
            // false: don't load wagons - that's usually the messed part of the savegame
            var savegameObj = new GameSave(rawSave,false);
            if (savegameObj.sucessfullLoad)
            {
                File.WriteAllText(fullFileName+".backup", rawSave);
                var fixedContent = savegameObj.Save(true);
                File.WriteAllText(fullFileName, fixedContent);
                Console.WriteLine("hopefully fixed the file, also created backup");
            }
            else
            {
                Console.WriteLine("Sorry: could not even load without wagons :-(");
            }
        }
    }
}
