using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace BattleTechModParser
{
    public class ParserTest
    {
        private static string OrigName = "VersionManifest.txt";
        private static string ModdedName = "VersionManifestWithChanges.txt";
        private static List<string> OrigContents;
        private static List<string> ModdedContents;

        static ParserTest()
        {
            OrigContents = GetTestFile(OrigName);
            ModdedContents = GetTestFile(ModdedName);
        }
        
        static List<string> GetTestFile(string name)
        {
            return System.IO.File.ReadAllLines(@"./resources/test/" + name).ToList();
        }
        public static void enable()
        {
            var newContents = Parser.GetFileChanges(OrigContents, true);
            newContents = Parser.GetFileChanges(newContents, true);
            newContents = Parser.GetFileChanges(newContents, true);
            newContents = Parser.GetFileChanges(newContents, true);
            CollectionAssert.AreEqual(newContents.ToArray(), ModdedContents);
        }

        public static void disable()
        {
            var newContents = Parser.GetFileChanges(ModdedContents, false);
            newContents = Parser.GetFileChanges(ModdedContents, false);
            newContents = Parser.GetFileChanges(ModdedContents, false);
            newContents = Parser.GetFileChanges(ModdedContents, false);
            CollectionAssert.AreEqual(newContents.ToArray(), OrigContents);
        }
    }
}