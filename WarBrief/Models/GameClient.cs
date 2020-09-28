using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarBrief.Models
{
    class GameClient
    {
        public static string Build { get; private set; }

        public static string InstalledPath { get; private set; }

        public static void Initialize()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                string path = Path.Combine(drive.Name, "Games", "World_of_Warships_NA");
                if (Directory.Exists(path))
                {
                    InstalledPath = path;
                }
            }

            string[] buildDirectories = Directory.GetDirectories(Path.Combine(InstalledPath, "bin"));
            foreach (var buildDirectory in buildDirectories)
            {
                Build = buildDirectory.Split('\\').Last();
            }
        }
    }
}
