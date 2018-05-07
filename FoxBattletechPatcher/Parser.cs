using System.Collections.Generic;
using System.Linq;

namespace FoxBattletechPatcher
{
    internal static class Parser
    {
        private static readonly string ModFolder = System.IO.Path.GetFullPath(@"./resources/mods/");
        private static readonly Dictionary<string, string[]> Sections = new Dictionary<string, string[]>();
        private static string[] GetModFile(string modName)
        {
            return System.IO.File.ReadAllLines(ModFolder + modName + ".txt");
        }
        static Parser()
        {
            Sections["PlayerEmblems"] = GetModFile("PlayerEmblems");
            Sections["BackerEmblems"] = GetModFile("BackerEmblems");
        }
        public static void PatchFile(string filename, bool enable)
        {
            var fileContents = System.IO.File.ReadAllLines(filename);
            var newFileContents = GetFileChanges(fileContents.ToList(), enable);
            System.IO.File.WriteAllLines(filename, newFileContents.ToArray());
        }

        public static List<string> GetFileChanges(List<string> fileContents, bool enable)
        {
            var newFileContents = new List<string>();
            string section = null;
            foreach (var line in fileContents)
            {
                if (line.Trim().Equals(","))
                {
                    if (section != null && Sections.ContainsKey(section) && enable)
                    {
                        foreach (var sectionLine in Sections[section])
                        {
                            if (!fileContents.Contains(sectionLine))
                            {
                                newFileContents.Add(sectionLine);
                            }
                        }
                    }
                    section = null;
                }
                if (Sections.ContainsKey(line))
                {
                    section = line;
                }

                if (section != null && !enable && Sections[section].Contains(line))
                {
                    //Console.WriteLine("Skipping: " + line);
                }
                else
                {
                    newFileContents.Add(line);
                }
            }

            return newFileContents;
        }
    } 
}
