using System;
using System.Collections.Generic;

namespace BattleTechModParser
{
    class Utils
    {
        public static string GetSteamFolder(string prefix)
        {
            return prefix + @"\Steam\SteamApps\common\BATTLETECH\BattleTech_Data\StreamingAssets\data\VersionManifest.csv";
        }
        public static List<string> GetDefaultLocations()
        {
            var locations = new List<string>();

            locations.Add(GetSteamFolder(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));
            locations.Add(GetSteamFolder(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)));

            return locations;
        }
        public static string FindValidLocation(List<string> locations)
        {
            foreach (var location in locations)
            {
                if (System.IO.File.Exists(location))
                {
                    return location;
                }
            }
            return null;
        }
        public static string GetBestFileGuess()
        {
            return FindValidLocation(GetDefaultLocations());
        }
    }
}
