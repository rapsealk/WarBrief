using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarBrief.Models;
using WarBrief.Utils;

namespace WarBrief
{
    public partial class MainForm : Form
    {
        private ModInstaller modInstaller;

        public delegate void LogDelegate(string data);

        public MainForm()
        {
            InitializeComponent();

            GameClient.Initialize();

            Initialize();

            FileObserver fileObserver = new FileObserver();
            try
            {
                Thread fileObserverThread = new Thread(fileObserver.Run)
                {
                    IsBackground = true
                };
                fileObserverThread.Start(Path.Combine(modInstaller.PnFModsDirectory, "RLMod"));
            }
            catch (ArgumentNullException e)
            {
                Console.Error.WriteLine($"MainForm: {e}");
            }
        }

        private void Initialize()
        {
            modInstaller = new ModInstaller();

            BuildLabel.Text = GameClient.Build;
        }
    }
}
