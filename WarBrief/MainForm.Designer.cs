﻿namespace WarBrief
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuildLabel);
            this.Controls.Add(this.BuildTagLabel);
            this.Name = "MainForm";
            this.Text = "WarBrief";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuildTagLabel;
        private System.Windows.Forms.Label BuildLabel;
    }
}

