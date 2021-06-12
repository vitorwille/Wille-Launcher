
namespace Wille_s_MC_Launcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChangeJava = new Guna.UI2.WinForms.Guna2Button();
            this.lbJavaPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePath = new Guna.UI2.WinForms.Guna2Button();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnRefreshVersion = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetLastVersion = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVersion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_Launch = new Guna.UI2.WinForms.Guna2Button();
            this.gMojangLogin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtXmx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXms = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSkipHashCheck = new System.Windows.Forms.CheckBox();
            this.cbSkipAssets = new System.Windows.Forms.CheckBox();
            this.rbSequenceDownload = new System.Windows.Forms.RadioButton();
            this.rbParallelDownload = new System.Windows.Forms.RadioButton();
            this.Pb_File = new System.Windows.Forms.ProgressBar();
            this.Pb_Progress = new System.Windows.Forms.ProgressBar();
            this.Lv_Status = new System.Windows.Forms.Label();
            this.guna2GroupBox2.SuspendLayout();
            this.gMojangLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeJava
            // 
            this.btnChangeJava.CheckedState.Parent = this.btnChangeJava;
            this.btnChangeJava.CustomImages.Parent = this.btnChangeJava;
            this.btnChangeJava.FillColor = System.Drawing.Color.White;
            this.btnChangeJava.Font = new System.Drawing.Font("Arial", 9F);
            this.btnChangeJava.ForeColor = System.Drawing.Color.Black;
            this.btnChangeJava.HoverState.Parent = this.btnChangeJava;
            this.btnChangeJava.Location = new System.Drawing.Point(7, 238);
            this.btnChangeJava.Name = "btnChangeJava";
            this.btnChangeJava.ShadowDecoration.Parent = this.btnChangeJava;
            this.btnChangeJava.Size = new System.Drawing.Size(684, 29);
            this.btnChangeJava.TabIndex = 25;
            this.btnChangeJava.Text = "Change Java version";
            // 
            // lbJavaPath
            // 
            this.lbJavaPath.Font = new System.Drawing.Font("Arial", 9F);
            this.lbJavaPath.ForeColor = System.Drawing.Color.White;
            this.lbJavaPath.Location = new System.Drawing.Point(48, 217);
            this.lbJavaPath.Name = "lbJavaPath";
            this.lbJavaPath.Size = new System.Drawing.Size(295, 18);
            this.lbJavaPath.TabIndex = 24;
            this.lbJavaPath.Text = "Use default Java";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Java:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Game path:";
            // 
            // btnChangePath
            // 
            this.btnChangePath.CheckedState.Parent = this.btnChangePath;
            this.btnChangePath.CustomImages.Parent = this.btnChangePath;
            this.btnChangePath.FillColor = System.Drawing.Color.White;
            this.btnChangePath.Font = new System.Drawing.Font("Arial", 9F);
            this.btnChangePath.ForeColor = System.Drawing.Color.Black;
            this.btnChangePath.HoverState.Parent = this.btnChangePath;
            this.btnChangePath.Location = new System.Drawing.Point(7, 185);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.ShadowDecoration.Parent = this.btnChangePath;
            this.btnChangePath.Size = new System.Drawing.Size(684, 29);
            this.btnChangePath.TabIndex = 16;
            this.btnChangePath.Text = "Change Minecraft path";
            // 
            // txtPath
            // 
            this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtPath.BorderColor = System.Drawing.Color.White;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.Parent = this.txtPath;
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FillColor = System.Drawing.Color.Black;
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.FocusedState.Parent = this.txtPath;
            this.txtPath.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.HoverState.Parent = this.txtPath;
            this.txtPath.Location = new System.Drawing.Point(99, 150);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.SelectedText = "";
            this.txtPath.ShadowDecoration.Parent = this.txtPath;
            this.txtPath.Size = new System.Drawing.Size(592, 29);
            this.txtPath.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(680, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DarkViolet;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(-1, -1);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(714, 34);
            this.guna2GradientButton1.TabIndex = 21;
            this.guna2GradientButton1.Text = "Wille\'s MC Launcher v1.0.0.0";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientButton1_MouseDown);
            this.guna2GradientButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2GradientButton1_MouseMove);
            this.guna2GradientButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2GradientButton1_MouseUp);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Controls.Add(this.Pb_Progress);
            this.guna2GroupBox2.Controls.Add(this.Pb_File);
            this.guna2GroupBox2.Controls.Add(this.Lv_Status);
            this.guna2GroupBox2.Controls.Add(this.btnRefreshVersion);
            this.guna2GroupBox2.Controls.Add(this.btnSetLastVersion);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.cbVersion);
            this.guna2GroupBox2.Controls.Add(this.Btn_Launch);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(7, 38);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(698, 161);
            this.guna2GroupBox2.TabIndex = 27;
            this.guna2GroupBox2.Text = "Launch Minecraft!";
            // 
            // btnRefreshVersion
            // 
            this.btnRefreshVersion.CheckedState.Parent = this.btnRefreshVersion;
            this.btnRefreshVersion.CustomImages.Parent = this.btnRefreshVersion;
            this.btnRefreshVersion.FillColor = System.Drawing.Color.White;
            this.btnRefreshVersion.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRefreshVersion.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshVersion.HoverState.Parent = this.btnRefreshVersion;
            this.btnRefreshVersion.Location = new System.Drawing.Point(578, 46);
            this.btnRefreshVersion.Name = "btnRefreshVersion";
            this.btnRefreshVersion.ShadowDecoration.Parent = this.btnRefreshVersion;
            this.btnRefreshVersion.Size = new System.Drawing.Size(113, 36);
            this.btnRefreshVersion.TabIndex = 30;
            this.btnRefreshVersion.Text = "Refresh";
            this.btnRefreshVersion.Click += new System.EventHandler(this.btnRefreshVersion_Click);
            // 
            // btnSetLastVersion
            // 
            this.btnSetLastVersion.CheckedState.Parent = this.btnSetLastVersion;
            this.btnSetLastVersion.CustomImages.Parent = this.btnSetLastVersion;
            this.btnSetLastVersion.FillColor = System.Drawing.Color.White;
            this.btnSetLastVersion.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSetLastVersion.ForeColor = System.Drawing.Color.Black;
            this.btnSetLastVersion.HoverState.Parent = this.btnSetLastVersion;
            this.btnSetLastVersion.Location = new System.Drawing.Point(459, 46);
            this.btnSetLastVersion.Name = "btnSetLastVersion";
            this.btnSetLastVersion.ShadowDecoration.Parent = this.btnSetLastVersion;
            this.btnSetLastVersion.Size = new System.Drawing.Size(113, 36);
            this.btnSetLastVersion.TabIndex = 29;
            this.btnSetLastVersion.Text = "Select latest";
            this.btnSetLastVersion.Click += new System.EventHandler(this.btnSetLastVersion_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 36);
            this.label6.TabIndex = 26;
            this.label6.Text = "Version:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.Transparent;
            this.cbVersion.BorderColor = System.Drawing.Color.White;
            this.cbVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FillColor = System.Drawing.Color.Black;
            this.cbVersion.FocusedColor = System.Drawing.Color.Empty;
            this.cbVersion.FocusedState.Parent = this.cbVersion;
            this.cbVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVersion.ForeColor = System.Drawing.Color.White;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.HoverState.Parent = this.cbVersion;
            this.cbVersion.ItemHeight = 30;
            this.cbVersion.ItemsAppearance.Parent = this.cbVersion;
            this.cbVersion.Location = new System.Drawing.Point(65, 46);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.ShadowDecoration.Parent = this.cbVersion;
            this.cbVersion.Size = new System.Drawing.Size(388, 36);
            this.cbVersion.TabIndex = 27;
            // 
            // Btn_Launch
            // 
            this.Btn_Launch.CheckedState.Parent = this.Btn_Launch;
            this.Btn_Launch.CustomImages.Parent = this.Btn_Launch;
            this.Btn_Launch.FillColor = System.Drawing.Color.White;
            this.Btn_Launch.Font = new System.Drawing.Font("Arial", 9F);
            this.Btn_Launch.ForeColor = System.Drawing.Color.Black;
            this.Btn_Launch.HoverState.Parent = this.Btn_Launch;
            this.Btn_Launch.Location = new System.Drawing.Point(7, 88);
            this.Btn_Launch.Name = "Btn_Launch";
            this.Btn_Launch.ShadowDecoration.Parent = this.Btn_Launch;
            this.Btn_Launch.Size = new System.Drawing.Size(684, 29);
            this.Btn_Launch.TabIndex = 26;
            this.Btn_Launch.Text = "Launch!";
            this.Btn_Launch.Click += new System.EventHandler(this.Btn_Launch_Click);
            // 
            // gMojangLogin
            // 
            this.gMojangLogin.BorderColor = System.Drawing.Color.White;
            this.gMojangLogin.Controls.Add(this.btnChangeJava);
            this.gMojangLogin.Controls.Add(this.TxtXmx);
            this.gMojangLogin.Controls.Add(this.lbJavaPath);
            this.gMojangLogin.Controls.Add(this.label5);
            this.gMojangLogin.Controls.Add(this.label1);
            this.gMojangLogin.Controls.Add(this.txtXms);
            this.gMojangLogin.Controls.Add(this.btnChangePath);
            this.gMojangLogin.Controls.Add(this.label2);
            this.gMojangLogin.Controls.Add(this.txtPath);
            this.gMojangLogin.Controls.Add(this.label4);
            this.gMojangLogin.Controls.Add(this.cbSkipHashCheck);
            this.gMojangLogin.Controls.Add(this.cbSkipAssets);
            this.gMojangLogin.Controls.Add(this.rbSequenceDownload);
            this.gMojangLogin.Controls.Add(this.rbParallelDownload);
            this.gMojangLogin.CustomBorderColor = System.Drawing.Color.White;
            this.gMojangLogin.FillColor = System.Drawing.Color.Black;
            this.gMojangLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gMojangLogin.ForeColor = System.Drawing.Color.Black;
            this.gMojangLogin.Location = new System.Drawing.Point(7, 205);
            this.gMojangLogin.Name = "gMojangLogin";
            this.gMojangLogin.ShadowDecoration.Parent = this.gMojangLogin;
            this.gMojangLogin.Size = new System.Drawing.Size(698, 278);
            this.gMojangLogin.TabIndex = 26;
            this.gMojangLogin.Text = "Options";
            // 
            // TxtXmx
            // 
            this.TxtXmx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TxtXmx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtXmx.BorderColor = System.Drawing.Color.White;
            this.TxtXmx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtXmx.DefaultText = "1024";
            this.TxtXmx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtXmx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtXmx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtXmx.DisabledState.Parent = this.TxtXmx;
            this.TxtXmx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtXmx.FillColor = System.Drawing.Color.Black;
            this.TxtXmx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtXmx.FocusedState.Parent = this.TxtXmx;
            this.TxtXmx.Font = new System.Drawing.Font("Arial", 9F);
            this.TxtXmx.ForeColor = System.Drawing.Color.White;
            this.TxtXmx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtXmx.HoverState.Parent = this.TxtXmx;
            this.TxtXmx.Location = new System.Drawing.Point(99, 114);
            this.TxtXmx.Name = "TxtXmx";
            this.TxtXmx.PasswordChar = '\0';
            this.TxtXmx.PlaceholderText = "";
            this.TxtXmx.SelectedText = "";
            this.TxtXmx.SelectionStart = 4;
            this.TxtXmx.ShadowDecoration.Parent = this.TxtXmx;
            this.TxtXmx.Size = new System.Drawing.Size(592, 29);
            this.TxtXmx.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "XMX (Max.Mb.)";
            // 
            // txtXms
            // 
            this.txtXms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtXms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtXms.BorderColor = System.Drawing.Color.White;
            this.txtXms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXms.DefaultText = "";
            this.txtXms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXms.DisabledState.Parent = this.txtXms;
            this.txtXms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXms.FillColor = System.Drawing.Color.Black;
            this.txtXms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXms.FocusedState.Parent = this.txtXms;
            this.txtXms.Font = new System.Drawing.Font("Arial", 9F);
            this.txtXms.ForeColor = System.Drawing.Color.White;
            this.txtXms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXms.HoverState.Parent = this.txtXms;
            this.txtXms.Location = new System.Drawing.Point(99, 79);
            this.txtXms.Name = "txtXms";
            this.txtXms.PasswordChar = '\0';
            this.txtXms.PlaceholderText = "";
            this.txtXms.SelectedText = "";
            this.txtXms.ShadowDecoration.Parent = this.txtXms;
            this.txtXms.Size = new System.Drawing.Size(592, 29);
            this.txtXms.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "XMS (Min.Mb.)";
            // 
            // cbSkipHashCheck
            // 
            this.cbSkipHashCheck.AutoSize = true;
            this.cbSkipHashCheck.ForeColor = System.Drawing.Color.White;
            this.cbSkipHashCheck.Location = new System.Drawing.Point(514, 58);
            this.cbSkipHashCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSkipHashCheck.Name = "cbSkipHashCheck";
            this.cbSkipHashCheck.Size = new System.Drawing.Size(127, 19);
            this.cbSkipHashCheck.TabIndex = 30;
            this.cbSkipHashCheck.Text = "Skip hash checking";
            this.cbSkipHashCheck.UseVisualStyleBackColor = true;
            // 
            // cbSkipAssets
            // 
            this.cbSkipAssets.AutoSize = true;
            this.cbSkipAssets.ForeColor = System.Drawing.Color.White;
            this.cbSkipAssets.Location = new System.Drawing.Point(372, 58);
            this.cbSkipAssets.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSkipAssets.Name = "cbSkipAssets";
            this.cbSkipAssets.Size = new System.Drawing.Size(138, 19);
            this.cbSkipAssets.TabIndex = 29;
            this.cbSkipAssets.Text = "Skip assets download";
            this.cbSkipAssets.UseVisualStyleBackColor = true;
            // 
            // rbSequenceDownload
            // 
            this.rbSequenceDownload.AutoSize = true;
            this.rbSequenceDownload.ForeColor = System.Drawing.Color.White;
            this.rbSequenceDownload.Location = new System.Drawing.Point(65, 57);
            this.rbSequenceDownload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbSequenceDownload.Name = "rbSequenceDownload";
            this.rbSequenceDownload.Size = new System.Drawing.Size(140, 19);
            this.rbSequenceDownload.TabIndex = 27;
            this.rbSequenceDownload.Text = "SequenceDownloader";
            this.rbSequenceDownload.UseVisualStyleBackColor = true;
            // 
            // rbParallelDownload
            // 
            this.rbParallelDownload.AutoSize = true;
            this.rbParallelDownload.Checked = true;
            this.rbParallelDownload.ForeColor = System.Drawing.Color.White;
            this.rbParallelDownload.Location = new System.Drawing.Point(209, 57);
            this.rbParallelDownload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbParallelDownload.Name = "rbParallelDownload";
            this.rbParallelDownload.Size = new System.Drawing.Size(159, 19);
            this.rbParallelDownload.TabIndex = 28;
            this.rbParallelDownload.TabStop = true;
            this.rbParallelDownload.Text = "AsyncParallelDownloader";
            this.rbParallelDownload.UseVisualStyleBackColor = true;
            // 
            // Pb_File
            // 
            this.Pb_File.ForeColor = System.Drawing.Color.BlueViolet;
            this.Pb_File.Location = new System.Drawing.Point(7, 123);
            this.Pb_File.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pb_File.Name = "Pb_File";
            this.Pb_File.Size = new System.Drawing.Size(340, 17);
            this.Pb_File.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pb_File.TabIndex = 28;
            // 
            // Pb_Progress
            // 
            this.Pb_Progress.ForeColor = System.Drawing.Color.BlueViolet;
            this.Pb_Progress.Location = new System.Drawing.Point(351, 123);
            this.Pb_Progress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pb_Progress.Name = "Pb_Progress";
            this.Pb_Progress.Size = new System.Drawing.Size(340, 17);
            this.Pb_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pb_Progress.TabIndex = 29;
            // 
            // Lv_Status
            // 
            this.Lv_Status.ForeColor = System.Drawing.Color.White;
            this.Lv_Status.Location = new System.Drawing.Point(7, 143);
            this.Lv_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lv_Status.Name = "Lv_Status";
            this.Lv_Status.Size = new System.Drawing.Size(684, 13);
            this.Lv_Status.TabIndex = 30;
            this.Lv_Status.Text = "Ready";
            this.Lv_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(712, 491);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.gMojangLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wille\'s MC Launcher v1.0.0.0";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.guna2GroupBox2.ResumeLayout(false);
            this.gMojangLogin.ResumeLayout(false);
            this.gMojangLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Button btnChangePath;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnChangeJava;
        private System.Windows.Forms.Label lbJavaPath;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox gMojangLogin;
        private System.Windows.Forms.CheckBox cbSkipHashCheck;
        private System.Windows.Forms.CheckBox cbSkipAssets;
        private System.Windows.Forms.RadioButton rbSequenceDownload;
        private System.Windows.Forms.RadioButton rbParallelDownload;
        private System.Windows.Forms.ProgressBar Pb_File;
        private System.Windows.Forms.ProgressBar Pb_Progress;
        private System.Windows.Forms.Label Lv_Status;
        private Guna.UI2.WinForms.Guna2Button Btn_Launch;
        private Guna.UI2.WinForms.Guna2TextBox TxtXmx;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtXms;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnRefreshVersion;
        private Guna.UI2.WinForms.Guna2Button btnSetLastVersion;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbVersion;
    }
}