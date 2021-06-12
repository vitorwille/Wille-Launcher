
namespace CmlLibWinFormSample
{
    partial class ForgeInstall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgeInstall));
            this.txtMC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtForge = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnInstall = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMC
            // 
            this.txtMC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtMC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtMC.BorderColor = System.Drawing.Color.White;
            this.txtMC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMC.DefaultText = "";
            this.txtMC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMC.DisabledState.Parent = this.txtMC;
            this.txtMC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMC.FillColor = System.Drawing.Color.Black;
            this.txtMC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMC.FocusedState.Parent = this.txtMC;
            this.txtMC.Font = new System.Drawing.Font("Arial", 9F);
            this.txtMC.ForeColor = System.Drawing.Color.White;
            this.txtMC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMC.HoverState.Parent = this.txtMC;
            this.txtMC.Location = new System.Drawing.Point(122, 9);
            this.txtMC.Name = "txtMC";
            this.txtMC.PasswordChar = '\0';
            this.txtMC.PlaceholderText = "";
            this.txtMC.SelectedText = "";
            this.txtMC.ShadowDecoration.Parent = this.txtMC;
            this.txtMC.Size = new System.Drawing.Size(189, 29);
            this.txtMC.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Minecraft Version:";
            // 
            // txtForge
            // 
            this.txtForge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtForge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtForge.BorderColor = System.Drawing.Color.White;
            this.txtForge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtForge.DefaultText = "";
            this.txtForge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtForge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtForge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtForge.DisabledState.Parent = this.txtForge;
            this.txtForge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtForge.FillColor = System.Drawing.Color.Black;
            this.txtForge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtForge.FocusedState.Parent = this.txtForge;
            this.txtForge.Font = new System.Drawing.Font("Arial", 9F);
            this.txtForge.ForeColor = System.Drawing.Color.White;
            this.txtForge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtForge.HoverState.Parent = this.txtForge;
            this.txtForge.Location = new System.Drawing.Point(122, 44);
            this.txtForge.Name = "txtForge";
            this.txtForge.PasswordChar = '\0';
            this.txtForge.PlaceholderText = "";
            this.txtForge.SelectedText = "";
            this.txtForge.ShadowDecoration.Parent = this.txtForge;
            this.txtForge.Size = new System.Drawing.Size(189, 29);
            this.txtForge.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Forge Version:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "ex) 1.7.10 (Minecraft version)\r\n      10.13.4.1614 (Forge version)";
            // 
            // pbProgress
            // 
            this.pbProgress.ForeColor = System.Drawing.Color.DarkViolet;
            this.pbProgress.Location = new System.Drawing.Point(15, 146);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(296, 25);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 33;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(12, 174);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 34;
            this.lbStatus.Text = "status";
            // 
            // btnInstall
            // 
            this.btnInstall.CheckedState.Parent = this.btnInstall;
            this.btnInstall.CustomImages.Parent = this.btnInstall;
            this.btnInstall.FillColor = System.Drawing.Color.White;
            this.btnInstall.Font = new System.Drawing.Font("Arial", 9F);
            this.btnInstall.ForeColor = System.Drawing.Color.Black;
            this.btnInstall.HoverState.Parent = this.btnInstall;
            this.btnInstall.Location = new System.Drawing.Point(15, 115);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.ShadowDecoration.Parent = this.btnInstall;
            this.btnInstall.Size = new System.Drawing.Size(296, 25);
            this.btnInstall.TabIndex = 35;
            this.btnInstall.Text = "Install";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // txtLog
            // 
            this.txtLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtLog.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtLog.BackBrush = null;
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.CharHeight = 14;
            this.txtLog.CharWidth = 8;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLog.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.IndentBackColor = System.Drawing.Color.Black;
            this.txtLog.IsReplaceMode = false;
            this.txtLog.LineNumberColor = System.Drawing.Color.DarkViolet;
            this.txtLog.Location = new System.Drawing.Point(15, 190);
            this.txtLog.Name = "txtLog";
            this.txtLog.Paddings = new System.Windows.Forms.Padding(0);
            this.txtLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtLog.ServiceColors")));
            this.txtLog.Size = new System.Drawing.Size(296, 113);
            this.txtLog.TabIndex = 36;
            this.txtLog.Zoom = 100;
            // 
            // ForgeInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(323, 316);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtForge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMC);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForgeInstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wille\'s MC Launcher - Forge Installer";
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMC;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtForge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lbStatus;
        private Guna.UI2.WinForms.Guna2Button btnInstall;
        private System.Windows.Forms.Timer timer1;
        private FastColoredTextBoxNS.FastColoredTextBox txtLog;
    }
}