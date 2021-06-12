
namespace Wille_s_MC_Launcher
{
    partial class GameLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLog));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.IndentBackColor = System.Drawing.Color.Black;
            this.txtLog.IsReplaceMode = false;
            this.txtLog.LineNumberColor = System.Drawing.Color.DarkViolet;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.Paddings = new System.Windows.Forms.Padding(0);
            this.txtLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtLog.ServiceColors")));
            this.txtLog.ServiceLinesColor = System.Drawing.Color.Black;
            this.txtLog.Size = new System.Drawing.Size(412, 247);
            this.txtLog.TabIndex = 37;
            this.txtLog.Zoom = 100;
            // 
            // GameLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameLog";
            this.Text = "Minecraft Log";
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private FastColoredTextBoxNS.FastColoredTextBox txtLog;
    }
}