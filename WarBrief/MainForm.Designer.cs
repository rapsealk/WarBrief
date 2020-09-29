namespace WarBrief
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildTagLabel = new System.Windows.Forms.Label();
            this.BuildLabel = new System.Windows.Forms.Label();
            this.ModOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ModPathTextBox = new System.Windows.Forms.TextBox();
            this.ModTagLabel = new System.Windows.Forms.Label();
            this.ModOpenButton = new System.Windows.Forms.Button();
            this.ModInstallButton = new System.Windows.Forms.Button();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerTagLabel = new System.Windows.Forms.Label();
            this.PlayerHealthTagLabel = new System.Windows.Forms.Label();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerPositionTagLabel = new System.Windows.Forms.Label();
            this.PlayerPositionLabel = new System.Windows.Forms.Label();
            this.PlayerYawTagLabel = new System.Windows.Forms.Label();
            this.PlayerYawLabel = new System.Windows.Forms.Label();
            this.PlayerManeuverLabel = new System.Windows.Forms.Label();
            this.PlayerManeuverTagLabel = new System.Windows.Forms.Label();
            this.PlayerBurningLabel = new System.Windows.Forms.Label();
            this.PlayerBurningTagLabel = new System.Windows.Forms.Label();
            this.PlayerFloodingLabel = new System.Windows.Forms.Label();
            this.PlayerFloodingTagLabel = new System.Windows.Forms.Label();
            this.OpponentPanel = new System.Windows.Forms.Panel();
            this.OpponentFloodingLabel = new System.Windows.Forms.Label();
            this.OpponentFloodingTagLabel = new System.Windows.Forms.Label();
            this.OpponentBurningLabel = new System.Windows.Forms.Label();
            this.OpponentBurningTagLabel = new System.Windows.Forms.Label();
            this.OpponentYawLabel = new System.Windows.Forms.Label();
            this.OpponentYawTagLabel = new System.Windows.Forms.Label();
            this.OpponentPositionLabel = new System.Windows.Forms.Label();
            this.OpponentPositionTagLabel = new System.Windows.Forms.Label();
            this.OpponentHealthLabel = new System.Windows.Forms.Label();
            this.OpponentHealthTagLabel = new System.Windows.Forms.Label();
            this.OpponentTagLabel = new System.Windows.Forms.Label();
            this.RunGameButton = new System.Windows.Forms.Button();
            this.CancelGameButton = new System.Windows.Forms.Button();
            this.PlayerPanel.SuspendLayout();
            this.OpponentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildTagLabel
            // 
            this.BuildTagLabel.AutoSize = true;
            this.BuildTagLabel.Location = new System.Drawing.Point(26, 27);
            this.BuildTagLabel.Name = "BuildTagLabel";
            this.BuildTagLabel.Size = new System.Drawing.Size(37, 12);
            this.BuildTagLabel.TabIndex = 0;
            this.BuildTagLabel.Text = "Build:";
            // 
            // BuildLabel
            // 
            this.BuildLabel.AutoSize = true;
            this.BuildLabel.Location = new System.Drawing.Point(83, 27);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(11, 12);
            this.BuildLabel.TabIndex = 1;
            this.BuildLabel.Text = "0";
            // 
            // ModOpenFileDialog
            // 
            this.ModOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ModPathTextBox
            // 
            this.ModPathTextBox.Enabled = false;
            this.ModPathTextBox.Location = new System.Drawing.Point(85, 50);
            this.ModPathTextBox.Name = "ModPathTextBox";
            this.ModPathTextBox.Size = new System.Drawing.Size(414, 21);
            this.ModPathTextBox.TabIndex = 2;
            // 
            // ModTagLabel
            // 
            this.ModTagLabel.AutoSize = true;
            this.ModTagLabel.Location = new System.Drawing.Point(26, 53);
            this.ModTagLabel.Name = "ModTagLabel";
            this.ModTagLabel.Size = new System.Drawing.Size(34, 12);
            this.ModTagLabel.TabIndex = 3;
            this.ModTagLabel.Text = "Mod:";
            // 
            // ModOpenButton
            // 
            this.ModOpenButton.Location = new System.Drawing.Point(505, 48);
            this.ModOpenButton.Name = "ModOpenButton";
            this.ModOpenButton.Size = new System.Drawing.Size(75, 23);
            this.ModOpenButton.TabIndex = 4;
            this.ModOpenButton.Text = "Open";
            this.ModOpenButton.UseVisualStyleBackColor = true;
            this.ModOpenButton.Click += new System.EventHandler(this.ModOpenButton_Click);
            // 
            // ModInstallButton
            // 
            this.ModInstallButton.Location = new System.Drawing.Point(586, 48);
            this.ModInstallButton.Name = "ModInstallButton";
            this.ModInstallButton.Size = new System.Drawing.Size(75, 23);
            this.ModInstallButton.TabIndex = 5;
            this.ModInstallButton.Text = "Install";
            this.ModInstallButton.UseVisualStyleBackColor = true;
            this.ModInstallButton.Click += new System.EventHandler(this.ModInstallButton_Click);
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.Controls.Add(this.PlayerFloodingLabel);
            this.PlayerPanel.Controls.Add(this.PlayerFloodingTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerBurningLabel);
            this.PlayerPanel.Controls.Add(this.PlayerBurningTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerManeuverLabel);
            this.PlayerPanel.Controls.Add(this.PlayerManeuverTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerYawLabel);
            this.PlayerPanel.Controls.Add(this.PlayerYawTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerPositionLabel);
            this.PlayerPanel.Controls.Add(this.PlayerPositionTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerHealthLabel);
            this.PlayerPanel.Controls.Add(this.PlayerHealthTagLabel);
            this.PlayerPanel.Controls.Add(this.PlayerTagLabel);
            this.PlayerPanel.Location = new System.Drawing.Point(28, 99);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(300, 229);
            this.PlayerPanel.TabIndex = 6;
            // 
            // PlayerTagLabel
            // 
            this.PlayerTagLabel.AutoSize = true;
            this.PlayerTagLabel.Location = new System.Drawing.Point(16, 14);
            this.PlayerTagLabel.Name = "PlayerTagLabel";
            this.PlayerTagLabel.Size = new System.Drawing.Size(41, 12);
            this.PlayerTagLabel.TabIndex = 0;
            this.PlayerTagLabel.Text = "Player";
            // 
            // PlayerHealthTagLabel
            // 
            this.PlayerHealthTagLabel.AutoSize = true;
            this.PlayerHealthTagLabel.Location = new System.Drawing.Point(16, 41);
            this.PlayerHealthTagLabel.Name = "PlayerHealthTagLabel";
            this.PlayerHealthTagLabel.Size = new System.Drawing.Size(44, 12);
            this.PlayerHealthTagLabel.TabIndex = 1;
            this.PlayerHealthTagLabel.Text = "Health:";
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(87, 41);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(121, 12);
            this.PlayerHealthLabel.TabIndex = 2;
            this.PlayerHealthLabel.Text = "18400 / 18400 (100%)";
            // 
            // PlayerPositionTagLabel
            // 
            this.PlayerPositionTagLabel.AutoSize = true;
            this.PlayerPositionTagLabel.Location = new System.Drawing.Point(16, 68);
            this.PlayerPositionTagLabel.Name = "PlayerPositionTagLabel";
            this.PlayerPositionTagLabel.Size = new System.Drawing.Size(54, 12);
            this.PlayerPositionTagLabel.TabIndex = 3;
            this.PlayerPositionTagLabel.Text = "Position:";
            // 
            // PlayerPositionLabel
            // 
            this.PlayerPositionLabel.AutoSize = true;
            this.PlayerPositionLabel.Location = new System.Drawing.Point(87, 68);
            this.PlayerPositionLabel.Name = "PlayerPositionLabel";
            this.PlayerPositionLabel.Size = new System.Drawing.Size(67, 12);
            this.PlayerPositionLabel.TabIndex = 4;
            this.PlayerPositionLabel.Text = "(0.25, 0.25)";
            // 
            // PlayerYawTagLabel
            // 
            this.PlayerYawTagLabel.AutoSize = true;
            this.PlayerYawTagLabel.Location = new System.Drawing.Point(16, 95);
            this.PlayerYawTagLabel.Name = "PlayerYawTagLabel";
            this.PlayerYawTagLabel.Size = new System.Drawing.Size(34, 12);
            this.PlayerYawTagLabel.TabIndex = 5;
            this.PlayerYawTagLabel.Text = "Yaw:";
            // 
            // PlayerYawLabel
            // 
            this.PlayerYawLabel.AutoSize = true;
            this.PlayerYawLabel.Location = new System.Drawing.Point(87, 95);
            this.PlayerYawLabel.Name = "PlayerYawLabel";
            this.PlayerYawLabel.Size = new System.Drawing.Size(21, 12);
            this.PlayerYawLabel.TabIndex = 6;
            this.PlayerYawLabel.Text = "0.0";
            // 
            // PlayerManeuverLabel
            // 
            this.PlayerManeuverLabel.AutoSize = true;
            this.PlayerManeuverLabel.Location = new System.Drawing.Point(87, 122);
            this.PlayerManeuverLabel.Name = "PlayerManeuverLabel";
            this.PlayerManeuverLabel.Size = new System.Drawing.Size(88, 12);
            this.PlayerManeuverLabel.TabIndex = 8;
            this.PlayerManeuverLabel.Text = "0.0 kts (STOP)";
            // 
            // PlayerManeuverTagLabel
            // 
            this.PlayerManeuverTagLabel.AutoSize = true;
            this.PlayerManeuverTagLabel.Location = new System.Drawing.Point(16, 122);
            this.PlayerManeuverTagLabel.Name = "PlayerManeuverTagLabel";
            this.PlayerManeuverTagLabel.Size = new System.Drawing.Size(65, 12);
            this.PlayerManeuverTagLabel.TabIndex = 7;
            this.PlayerManeuverTagLabel.Text = "Maneuver:";
            // 
            // PlayerBurningLabel
            // 
            this.PlayerBurningLabel.AutoSize = true;
            this.PlayerBurningLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayerBurningLabel.Location = new System.Drawing.Point(87, 149);
            this.PlayerBurningLabel.Name = "PlayerBurningLabel";
            this.PlayerBurningLabel.Size = new System.Drawing.Size(13, 12);
            this.PlayerBurningLabel.TabIndex = 10;
            this.PlayerBurningLabel.Text = "X";
            // 
            // PlayerBurningTagLabel
            // 
            this.PlayerBurningTagLabel.AutoSize = true;
            this.PlayerBurningTagLabel.Location = new System.Drawing.Point(16, 149);
            this.PlayerBurningTagLabel.Name = "PlayerBurningTagLabel";
            this.PlayerBurningTagLabel.Size = new System.Drawing.Size(52, 12);
            this.PlayerBurningTagLabel.TabIndex = 9;
            this.PlayerBurningTagLabel.Text = "Burning:";
            // 
            // PlayerFloodingLabel
            // 
            this.PlayerFloodingLabel.AutoSize = true;
            this.PlayerFloodingLabel.Location = new System.Drawing.Point(87, 176);
            this.PlayerFloodingLabel.Name = "PlayerFloodingLabel";
            this.PlayerFloodingLabel.Size = new System.Drawing.Size(13, 12);
            this.PlayerFloodingLabel.TabIndex = 12;
            this.PlayerFloodingLabel.Text = "X";
            // 
            // PlayerFloodingTagLabel
            // 
            this.PlayerFloodingTagLabel.AutoSize = true;
            this.PlayerFloodingTagLabel.Location = new System.Drawing.Point(16, 176);
            this.PlayerFloodingTagLabel.Name = "PlayerFloodingTagLabel";
            this.PlayerFloodingTagLabel.Size = new System.Drawing.Size(57, 12);
            this.PlayerFloodingTagLabel.TabIndex = 11;
            this.PlayerFloodingTagLabel.Text = "Flooding:";
            // 
            // OpponentPanel
            // 
            this.OpponentPanel.Controls.Add(this.OpponentFloodingLabel);
            this.OpponentPanel.Controls.Add(this.OpponentFloodingTagLabel);
            this.OpponentPanel.Controls.Add(this.OpponentBurningLabel);
            this.OpponentPanel.Controls.Add(this.OpponentBurningTagLabel);
            this.OpponentPanel.Controls.Add(this.OpponentYawLabel);
            this.OpponentPanel.Controls.Add(this.OpponentYawTagLabel);
            this.OpponentPanel.Controls.Add(this.OpponentPositionLabel);
            this.OpponentPanel.Controls.Add(this.OpponentPositionTagLabel);
            this.OpponentPanel.Controls.Add(this.OpponentHealthLabel);
            this.OpponentPanel.Controls.Add(this.OpponentHealthTagLabel);
            this.OpponentPanel.Controls.Add(this.OpponentTagLabel);
            this.OpponentPanel.Location = new System.Drawing.Point(361, 99);
            this.OpponentPanel.Name = "OpponentPanel";
            this.OpponentPanel.Size = new System.Drawing.Size(300, 229);
            this.OpponentPanel.TabIndex = 13;
            // 
            // OpponentFloodingLabel
            // 
            this.OpponentFloodingLabel.AutoSize = true;
            this.OpponentFloodingLabel.Location = new System.Drawing.Point(87, 176);
            this.OpponentFloodingLabel.Name = "OpponentFloodingLabel";
            this.OpponentFloodingLabel.Size = new System.Drawing.Size(13, 12);
            this.OpponentFloodingLabel.TabIndex = 12;
            this.OpponentFloodingLabel.Text = "X";
            // 
            // OpponentFloodingTagLabel
            // 
            this.OpponentFloodingTagLabel.AutoSize = true;
            this.OpponentFloodingTagLabel.Location = new System.Drawing.Point(16, 176);
            this.OpponentFloodingTagLabel.Name = "OpponentFloodingTagLabel";
            this.OpponentFloodingTagLabel.Size = new System.Drawing.Size(57, 12);
            this.OpponentFloodingTagLabel.TabIndex = 11;
            this.OpponentFloodingTagLabel.Text = "Flooding:";
            // 
            // OpponentBurningLabel
            // 
            this.OpponentBurningLabel.AutoSize = true;
            this.OpponentBurningLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpponentBurningLabel.Location = new System.Drawing.Point(87, 149);
            this.OpponentBurningLabel.Name = "OpponentBurningLabel";
            this.OpponentBurningLabel.Size = new System.Drawing.Size(13, 12);
            this.OpponentBurningLabel.TabIndex = 10;
            this.OpponentBurningLabel.Text = "X";
            // 
            // OpponentBurningTagLabel
            // 
            this.OpponentBurningTagLabel.AutoSize = true;
            this.OpponentBurningTagLabel.Location = new System.Drawing.Point(16, 149);
            this.OpponentBurningTagLabel.Name = "OpponentBurningTagLabel";
            this.OpponentBurningTagLabel.Size = new System.Drawing.Size(52, 12);
            this.OpponentBurningTagLabel.TabIndex = 9;
            this.OpponentBurningTagLabel.Text = "Burning:";
            // 
            // OpponentYawLabel
            // 
            this.OpponentYawLabel.AutoSize = true;
            this.OpponentYawLabel.Location = new System.Drawing.Point(87, 95);
            this.OpponentYawLabel.Name = "OpponentYawLabel";
            this.OpponentYawLabel.Size = new System.Drawing.Size(21, 12);
            this.OpponentYawLabel.TabIndex = 6;
            this.OpponentYawLabel.Text = "0.0";
            // 
            // OpponentYawTagLabel
            // 
            this.OpponentYawTagLabel.AutoSize = true;
            this.OpponentYawTagLabel.Location = new System.Drawing.Point(16, 95);
            this.OpponentYawTagLabel.Name = "OpponentYawTagLabel";
            this.OpponentYawTagLabel.Size = new System.Drawing.Size(34, 12);
            this.OpponentYawTagLabel.TabIndex = 5;
            this.OpponentYawTagLabel.Text = "Yaw:";
            // 
            // OpponentPositionLabel
            // 
            this.OpponentPositionLabel.AutoSize = true;
            this.OpponentPositionLabel.Location = new System.Drawing.Point(87, 68);
            this.OpponentPositionLabel.Name = "OpponentPositionLabel";
            this.OpponentPositionLabel.Size = new System.Drawing.Size(67, 12);
            this.OpponentPositionLabel.TabIndex = 4;
            this.OpponentPositionLabel.Text = "(0.25, 0.25)";
            // 
            // OpponentPositionTagLabel
            // 
            this.OpponentPositionTagLabel.AutoSize = true;
            this.OpponentPositionTagLabel.Location = new System.Drawing.Point(16, 68);
            this.OpponentPositionTagLabel.Name = "OpponentPositionTagLabel";
            this.OpponentPositionTagLabel.Size = new System.Drawing.Size(54, 12);
            this.OpponentPositionTagLabel.TabIndex = 3;
            this.OpponentPositionTagLabel.Text = "Position:";
            // 
            // OpponentHealthLabel
            // 
            this.OpponentHealthLabel.AutoSize = true;
            this.OpponentHealthLabel.Location = new System.Drawing.Point(87, 41);
            this.OpponentHealthLabel.Name = "OpponentHealthLabel";
            this.OpponentHealthLabel.Size = new System.Drawing.Size(121, 12);
            this.OpponentHealthLabel.TabIndex = 2;
            this.OpponentHealthLabel.Text = "18400 / 18400 (100%)";
            // 
            // OpponentHealthTagLabel
            // 
            this.OpponentHealthTagLabel.AutoSize = true;
            this.OpponentHealthTagLabel.Location = new System.Drawing.Point(16, 41);
            this.OpponentHealthTagLabel.Name = "OpponentHealthTagLabel";
            this.OpponentHealthTagLabel.Size = new System.Drawing.Size(44, 12);
            this.OpponentHealthTagLabel.TabIndex = 1;
            this.OpponentHealthTagLabel.Text = "Health:";
            // 
            // OpponentTagLabel
            // 
            this.OpponentTagLabel.AutoSize = true;
            this.OpponentTagLabel.Location = new System.Drawing.Point(16, 14);
            this.OpponentTagLabel.Name = "OpponentTagLabel";
            this.OpponentTagLabel.Size = new System.Drawing.Size(59, 12);
            this.OpponentTagLabel.TabIndex = 0;
            this.OpponentTagLabel.Text = "Opponent";
            // 
            // RunGameButton
            // 
            this.RunGameButton.Location = new System.Drawing.Point(28, 376);
            this.RunGameButton.Name = "RunGameButton";
            this.RunGameButton.Size = new System.Drawing.Size(471, 23);
            this.RunGameButton.TabIndex = 14;
            this.RunGameButton.Text = "Run";
            this.RunGameButton.UseVisualStyleBackColor = true;
            this.RunGameButton.Click += new System.EventHandler(this.RunGameButton_Click);
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.Location = new System.Drawing.Point(518, 376);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(143, 23);
            this.CancelGameButton.TabIndex = 15;
            this.CancelGameButton.Text = "Cancel";
            this.CancelGameButton.UseVisualStyleBackColor = true;
            this.CancelGameButton.Click += new System.EventHandler(this.CancelGameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelGameButton);
            this.Controls.Add(this.RunGameButton);
            this.Controls.Add(this.OpponentPanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.ModInstallButton);
            this.Controls.Add(this.ModOpenButton);
            this.Controls.Add(this.ModTagLabel);
            this.Controls.Add(this.ModPathTextBox);
            this.Controls.Add(this.BuildLabel);
            this.Controls.Add(this.BuildTagLabel);
            this.Name = "MainForm";
            this.Text = "WarBrief";
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.OpponentPanel.ResumeLayout(false);
            this.OpponentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuildTagLabel;
        private System.Windows.Forms.Label BuildLabel;
        private System.Windows.Forms.OpenFileDialog ModOpenFileDialog;
        private System.Windows.Forms.TextBox ModPathTextBox;
        private System.Windows.Forms.Label ModTagLabel;
        private System.Windows.Forms.Button ModOpenButton;
        private System.Windows.Forms.Button ModInstallButton;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.Label PlayerHealthTagLabel;
        private System.Windows.Forms.Label PlayerTagLabel;
        private System.Windows.Forms.Label PlayerPositionLabel;
        private System.Windows.Forms.Label PlayerPositionTagLabel;
        private System.Windows.Forms.Label PlayerYawLabel;
        private System.Windows.Forms.Label PlayerYawTagLabel;
        private System.Windows.Forms.Label PlayerManeuverLabel;
        private System.Windows.Forms.Label PlayerManeuverTagLabel;
        private System.Windows.Forms.Label PlayerFloodingLabel;
        private System.Windows.Forms.Label PlayerFloodingTagLabel;
        private System.Windows.Forms.Label PlayerBurningLabel;
        private System.Windows.Forms.Label PlayerBurningTagLabel;
        private System.Windows.Forms.Panel OpponentPanel;
        private System.Windows.Forms.Label OpponentFloodingLabel;
        private System.Windows.Forms.Label OpponentFloodingTagLabel;
        private System.Windows.Forms.Label OpponentBurningLabel;
        private System.Windows.Forms.Label OpponentBurningTagLabel;
        private System.Windows.Forms.Label OpponentYawLabel;
        private System.Windows.Forms.Label OpponentYawTagLabel;
        private System.Windows.Forms.Label OpponentPositionLabel;
        private System.Windows.Forms.Label OpponentPositionTagLabel;
        private System.Windows.Forms.Label OpponentHealthLabel;
        private System.Windows.Forms.Label OpponentHealthTagLabel;
        private System.Windows.Forms.Label OpponentTagLabel;
        private System.Windows.Forms.Button RunGameButton;
        private System.Windows.Forms.Button CancelGameButton;
    }
}

