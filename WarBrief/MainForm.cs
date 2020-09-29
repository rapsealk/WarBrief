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
using WarBrief.Views;

namespace WarBrief
{
    public partial class MainForm : Form, IGameView
    {
        private ModInstaller modInstaller;

        private Game game;

        private FileObserver fileObserver;
        private Thread fileObserverThread = null;

        public delegate void LogDelegate(string data);

        public MainForm()
        {
            InitializeComponent();

            GameClient.Initialize();

            Initialize();
        }

        private void Initialize()
        {
            modInstaller = new ModInstaller();

            game = new Game(this);

            fileObserver = new FileObserver(game);

            BuildLabel.Text = GameClient.Build;
        }

        private void ShowMessageBox(string message, string caption = "WarBrief")
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult _ = MessageBox.Show(message, caption, buttons);
        }

        private void StartFileObserver()
        {
            try
            {
                fileObserverThread = new Thread(fileObserver.Run)
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

        private void StopFileObserver()
        {
            fileObserverThread?.Interrupt();
        }

        private void ModOpenButton_Click(object sender, EventArgs e)
        {
            DialogResult result = ModOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ModOpenFileDialog.FileName;

                if (!fileName.EndsWith(".py"))
                {
                    ShowMessageBox("Python 스크립트 파일만 지원됩니다. (*.py)");
                    return;
                }

                ModPathTextBox.Text = fileName;
            }
        }

        private void ModInstallButton_Click(object sender, EventArgs e)
        {
            string modPath = ModPathTextBox.Text;

            if (modPath.Equals(string.Empty))
            {
                ShowMessageBox("경로를 설정해 주세요.");
                return;
            }

            if (!File.Exists(modPath))
            {
                ShowMessageBox("존재하지 않는 파일입니다.");
                return;
            }

            if (!modPath.EndsWith(".py"))
            {
                ShowMessageBox("Python 스크립트 파일만 지원됩니다. (*.py)");
                return;
            }

            modInstaller.InstallPythonMod("RLMod", modPath);

            ShowMessageBox("설치를 완료했습니다.");
        }

        private void RunGameButton_Click(object sender, EventArgs e)
        {
            StartFileObserver();

            RunGameButton.Enabled = false;
        }

        private void CancelGameButton_Click(object sender, EventArgs e)
        {
            StopFileObserver();

            RunGameButton.Enabled = true;
        }

        // IGameView Implementations.

        public void UpdatePlayer(Player player)
        {
            BeginInvoke((Action) delegate
            {
               PlayerHealthLabel.Text = $"{player.Health} / {player.MaxHealth} ({player.Health / player.MaxHealth * 100}%)";
               PlayerYawLabel.Text = player.Yaw.ToString();
               PlayerManeuverLabel.Text = player.Knot.ToString();
               PlayerBurningLabel.Text = player.IsVehicleBurning ? "O" : "X";
               PlayerFloodingLabel.Text = player.IsVehicleFlooding ? "O" : "X";
            });
        }

        public void UpdateOpponent(Player opponent)
        {
            BeginInvoke((Action) delegate
            {
                OpponentHealthLabel.Text = $"{opponent.Health} / {opponent.MaxHealth} ({opponent.Health / opponent.MaxHealth * 100}%)";
                OpponentYawLabel.Text = opponent.Yaw.ToString();
                OpponentBurningLabel.Text = opponent.IsVehicleBurning ? "O" : "X";
                OpponentFloodingLabel.Text = opponent.IsVehicleFlooding ? "O" : "X";
            });
        }
    }
}
