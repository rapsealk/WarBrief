using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBrief.Models;

namespace WarBrief.Utils
{
    class ModInstaller
    {
        public string RootDirectory { get; set; }
        public string PnFModsDirectory { get; set; }

        public ModInstaller()
        {
            Initialize();
        }

        private void Initialize()
        {
            RootDirectory = Path.Combine(GameClient.InstalledPath, "bin", GameClient.Build, "res_mods");
            File.Create(Path.Combine(RootDirectory, "PnFModsLoader.py"));

            string pnfMods = Path.Combine(RootDirectory, "PnFMods");
            if (!Directory.Exists(pnfMods))
            {
                Directory.CreateDirectory(pnfMods);
            }
            PnFModsDirectory = pnfMods;
        }

        public void InstallPythonMod(string modName, string pythonModScriptPath)
        {
            string modDirectory = Path.Combine(PnFModsDirectory, modName);
            if (!Directory.Exists(modDirectory))
            {
                Directory.CreateDirectory(modDirectory);
            }

            string targetModPath = Path.Combine(modDirectory, "Main.py");
            File.Copy(pythonModScriptPath, targetModPath, overwrite: true);
        }
    }
}
