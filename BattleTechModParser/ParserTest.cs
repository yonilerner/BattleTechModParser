using NUnit.Framework;

namespace BattleTechModParser
{
    public class ParserTest
    {
        private static string OrigName = "VersionManifest.txt";
        private static string ModdedName = "VersionManifestWithChanges.txt";
        private static string[] OrigContents;
        private static string[] ModdedContents;

        static ParserTest()
        {
            OrigContents = GetTestFile(OrigName);
            ModdedContents = GetTestFile(ModdedName);
        }
        
        static string[] GetTestFile(string name)
        {
            return System.IO.File.ReadAllLines(@"./resources/test/" + name);
        }
        public static void enable()
        {
            var newContents = Parser.GetFileChanges(OrigContents, true);
            CollectionAssert.AreEqual(newContents.ToArray(), ModdedContents);
        }

        public static void disable()
        {
            var newContents = Parser.GetFileChanges(ModdedContents, false);
            CollectionAssert.AreEqual(newContents.ToArray(), OrigContents);
        }
    }
}