namespace Qapp_rev1_0_1
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.label_Qapp = new System.Windows.Forms.Label();
            this.logoQ = new System.Windows.Forms.PictureBox();
            this.buttExit = new System.Windows.Forms.Button();
            this.labelRev = new System.Windows.Forms.Label();
            this.buttMinimize = new System.Windows.Forms.Button();
            this.labelNewProgram = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.menuStripStartup = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileDropSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileDropSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUpload = new System.Windows.Forms.Label();
            this.dropTelsec = new System.Windows.Forms.ComboBox();
            this.dropExpansion = new System.Windows.Forms.ComboBox();
            this.panelNewProgram = new System.Windows.Forms.Panel();
            this.buttNewCreate = new System.Windows.Forms.Button();
            this.groupBoxSiteName = new System.Windows.Forms.GroupBox();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.dropCustomer = new System.Windows.Forms.ComboBox();
            this.groupBoxTelsec = new System.Windows.Forms.GroupBox();
            this.panelOpenProgram = new System.Windows.Forms.Panel();
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.buttBrowseOpen = new System.Windows.Forms.Button();
            this.buttOpen = new System.Windows.Forms.Button();
            this.panelUploadProgram = new System.Windows.Forms.Panel();
            this.textBoxUpload = new System.Windows.Forms.TextBox();
            this.buttBrowseUpload = new System.Windows.Forms.Button();
            this.buttUpload = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoQ)).BeginInit();
            this.menuStripStartup.SuspendLayout();
            this.panelNewProgram.SuspendLayout();
            this.groupBoxSiteName.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxTelsec.SuspendLayout();
            this.panelOpenProgram.SuspendLayout();
            this.panelUploadProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Qapp
            // 
            this.label_Qapp.AutoSize = true;
            this.label_Qapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Qapp.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label_Qapp.Location = new System.Drawing.Point(49, 6);
            this.label_Qapp.Name = "label_Qapp";
            this.label_Qapp.Size = new System.Drawing.Size(150, 17);
            this.label_Qapp.TabIndex = 0;
            this.label_Qapp.Text = "Qapp - Quest Controls";
            // 
            // logoQ
            // 
            this.logoQ.Image = ((System.Drawing.Image)(resources.GetObject("logoQ.Image")));
            this.logoQ.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoQ.InitialImage")));
            this.logoQ.Location = new System.Drawing.Point(5, 4);
            this.logoQ.Name = "logoQ";
            this.logoQ.Size = new System.Drawing.Size(27, 27);
            this.logoQ.TabIndex = 1;
            this.logoQ.TabStop = false;
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(597, -2);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(27, 27);
            this.buttExit.TabIndex = 2;
            this.buttExit.Text = "X";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // labelRev
            // 
            this.labelRev.AutoSize = true;
            this.labelRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRev.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelRev.Location = new System.Drawing.Point(557, 378);
            this.labelRev.Name = "labelRev";
            this.labelRev.Size = new System.Drawing.Size(54, 13);
            this.labelRev.TabIndex = 3;
            this.labelRev.Text = "Rev 1.0.1";
            // 
            // buttMinimize
            // 
            this.buttMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMinimize.Location = new System.Drawing.Point(570, -5);
            this.buttMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttMinimize.Name = "buttMinimize";
            this.buttMinimize.Size = new System.Drawing.Size(27, 30);
            this.buttMinimize.TabIndex = 4;
            this.buttMinimize.Tag = "Minimize";
            this.buttMinimize.Text = "-";
            this.buttMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttMinimize.UseVisualStyleBackColor = false;
            this.buttMinimize.Click += new System.EventHandler(this.buttMinimize_Click);
            // 
            // labelNewProgram
            // 
            this.labelNewProgram.AutoSize = true;
            this.labelNewProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewProgram.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNewProgram.Location = new System.Drawing.Point(48, 115);
            this.labelNewProgram.Name = "labelNewProgram";
            this.labelNewProgram.Size = new System.Drawing.Size(104, 20);
            this.labelNewProgram.TabIndex = 5;
            this.labelNewProgram.Text = "New Program";
            this.labelNewProgram.Click += new System.EventHandler(this.labelNewProgram_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOpen.Location = new System.Drawing.Point(48, 204);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(48, 20);
            this.labelOpen.TabIndex = 6;
            this.labelOpen.Text = "Open";
            this.labelOpen.Click += new System.EventHandler(this.labelOpenProgram_Click);
            // 
            // menuStripStartup
            // 
            this.menuStripStartup.AutoSize = false;
            this.menuStripStartup.BackColor = System.Drawing.Color.DimGray;
            this.menuStripStartup.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripStartup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTools,
            this.menuHelp});
            this.menuStripStartup.Location = new System.Drawing.Point(2, 31);
            this.menuStripStartup.Name = "menuStripStartup";
            this.menuStripStartup.Size = new System.Drawing.Size(622, 24);
            this.menuStripStartup.TabIndex = 7;
            this.menuStripStartup.Text = "menuStripStartup";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.DimGray;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuUpload,
            this.menuOpen,
            this.menuFileDropSeperator2,
            this.menuRecent,
            this.menuFileDropSeperator,
            this.menuExit});
            this.menuFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuNew.ForeColor = System.Drawing.Color.DimGray;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(112, 22);
            this.menuNew.Text = "New";
            // 
            // menuUpload
            // 
            this.menuUpload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuUpload.ForeColor = System.Drawing.Color.DimGray;
            this.menuUpload.Name = "menuUpload";
            this.menuUpload.Size = new System.Drawing.Size(112, 22);
            this.menuUpload.Text = "Upload";
            // 
            // menuOpen
            // 
            this.menuOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuOpen.ForeColor = System.Drawing.Color.DimGray;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(112, 22);
            this.menuOpen.Text = "Open";
            // 
            // menuFileDropSeperator2
            // 
            this.menuFileDropSeperator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuFileDropSeperator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuFileDropSeperator2.Name = "menuFileDropSeperator2";
            this.menuFileDropSeperator2.Size = new System.Drawing.Size(109, 6);
            // 
            // menuRecent
            // 
            this.menuRecent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuRecent.ForeColor = System.Drawing.Color.DimGray;
            this.menuRecent.Name = "menuRecent";
            this.menuRecent.Size = new System.Drawing.Size(112, 22);
            this.menuRecent.Text = "Recent";
            // 
            // menuFileDropSeperator
            // 
            this.menuFileDropSeperator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuFileDropSeperator.Name = "menuFileDropSeperator";
            this.menuFileDropSeperator.Size = new System.Drawing.Size(109, 6);
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuExit.ForeColor = System.Drawing.Color.DimGray;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(112, 22);
            this.menuExit.Text = "Exit";
            // 
            // menuTools
            // 
            this.menuTools.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(48, 20);
            this.menuTools.Text = "Tools";
            // 
            // menuHelp
            // 
            this.menuHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpload.Location = new System.Drawing.Point(48, 159);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(85, 20);
            this.labelUpload.TabIndex = 8;
            this.labelUpload.Text = "Upload I/O";
            this.labelUpload.Click += new System.EventHandler(this.labelUploadProgram_Click);
            // 
            // dropTelsec
            // 
            this.dropTelsec.AutoCompleteCustomSource.AddRange(new string[] {
            "esb",
            "rmwm",
            "minipro"});
            this.dropTelsec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dropTelsec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropTelsec.FormattingEnabled = true;
            this.dropTelsec.Items.AddRange(new object[] {
            "ESB",
            "RMWM",
            "MiniPro"});
            this.dropTelsec.Location = new System.Drawing.Point(6, 16);
            this.dropTelsec.Name = "dropTelsec";
            this.dropTelsec.Size = new System.Drawing.Size(78, 21);
            this.dropTelsec.TabIndex = 0;
            this.dropTelsec.SelectedValueChanged += new System.EventHandler(this.dropTelsec_SelectedValueChanged);
            // 
            // dropExpansion
            // 
            this.dropExpansion.FormattingEnabled = true;
            this.dropExpansion.Location = new System.Drawing.Point(56, 55);
            this.dropExpansion.Name = "dropExpansion";
            this.dropExpansion.Size = new System.Drawing.Size(37, 21);
            this.dropExpansion.TabIndex = 1;
            this.dropExpansion.Visible = false;
            // 
            // panelNewProgram
            // 
            this.panelNewProgram.Controls.Add(this.buttNewCreate);
            this.panelNewProgram.Controls.Add(this.groupBoxSiteName);
            this.panelNewProgram.Controls.Add(this.dropExpansion);
            this.panelNewProgram.Controls.Add(this.groupBoxCustomer);
            this.panelNewProgram.Controls.Add(this.groupBoxTelsec);
            this.panelNewProgram.Location = new System.Drawing.Point(52, 138);
            this.panelNewProgram.Name = "panelNewProgram";
            this.panelNewProgram.Size = new System.Drawing.Size(510, 87);
            this.panelNewProgram.TabIndex = 12;
            this.panelNewProgram.Visible = false;
            // 
            // buttNewCreate
            // 
            this.buttNewCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttNewCreate.Location = new System.Drawing.Point(441, 53);
            this.buttNewCreate.Name = "buttNewCreate";
            this.buttNewCreate.Size = new System.Drawing.Size(60, 29);
            this.buttNewCreate.TabIndex = 5;
            this.buttNewCreate.Text = "Create ►";
            this.buttNewCreate.UseVisualStyleBackColor = false;
            this.buttNewCreate.MouseEnter += new System.EventHandler(this.buttNewCreate_MouseEnter);
            this.buttNewCreate.MouseLeave += new System.EventHandler(this.buttNewCreate_MouseLeave);
            // 
            // groupBoxSiteName
            // 
            this.groupBoxSiteName.Controls.Add(this.textBoxSiteName);
            this.groupBoxSiteName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSiteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSiteName.Location = new System.Drawing.Point(253, 3);
            this.groupBoxSiteName.Name = "groupBoxSiteName";
            this.groupBoxSiteName.Size = new System.Drawing.Size(247, 46);
            this.groupBoxSiteName.TabIndex = 4;
            this.groupBoxSiteName.TabStop = false;
            this.groupBoxSiteName.Text = "Site Name";
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(6, 16);
            this.textBoxSiteName.MaxLength = 255;
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(235, 22);
            this.textBoxSiteName.TabIndex = 4;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.dropCustomer);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxCustomer.Location = new System.Drawing.Point(122, 3);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(111, 46);
            this.groupBoxCustomer.TabIndex = 3;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // dropCustomer
            // 
            this.dropCustomer.AutoCompleteCustomSource.AddRange(new string[] {
            "esb",
            "rmwm",
            "minipro"});
            this.dropCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dropCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropCustomer.FormattingEnabled = true;
            this.dropCustomer.Items.AddRange(new object[] {
            "Charter",
            "Comcast",
            "Verizon",
            "COX",
            "WOW!"});
            this.dropCustomer.Location = new System.Drawing.Point(6, 16);
            this.dropCustomer.Name = "dropCustomer";
            this.dropCustomer.Size = new System.Drawing.Size(99, 21);
            this.dropCustomer.TabIndex = 3;
            // 
            // groupBoxTelsec
            // 
            this.groupBoxTelsec.Controls.Add(this.dropTelsec);
            this.groupBoxTelsec.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTelsec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTelsec.Location = new System.Drawing.Point(9, 3);
            this.groupBoxTelsec.Name = "groupBoxTelsec";
            this.groupBoxTelsec.Size = new System.Drawing.Size(91, 46);
            this.groupBoxTelsec.TabIndex = 2;
            this.groupBoxTelsec.TabStop = false;
            this.groupBoxTelsec.Text = "TELSEC";
            // 
            // panelOpenProgram
            // 
            this.panelOpenProgram.Controls.Add(this.textBoxOpen);
            this.panelOpenProgram.Controls.Add(this.buttBrowseOpen);
            this.panelOpenProgram.Controls.Add(this.buttOpen);
            this.panelOpenProgram.Location = new System.Drawing.Point(52, 228);
            this.panelOpenProgram.Name = "panelOpenProgram";
            this.panelOpenProgram.Size = new System.Drawing.Size(510, 56);
            this.panelOpenProgram.TabIndex = 13;
            this.panelOpenProgram.Visible = false;
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.Location = new System.Drawing.Point(9, 20);
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.Size = new System.Drawing.Size(393, 20);
            this.textBoxOpen.TabIndex = 9;
            // 
            // buttBrowseOpen
            // 
            this.buttBrowseOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttBrowseOpen.Location = new System.Drawing.Point(408, 15);
            this.buttBrowseOpen.Name = "buttBrowseOpen";
            this.buttBrowseOpen.Size = new System.Drawing.Size(30, 29);
            this.buttBrowseOpen.TabIndex = 10;
            this.buttBrowseOpen.Text = "...";
            this.buttBrowseOpen.UseVisualStyleBackColor = false;
            // 
            // buttOpen
            // 
            this.buttOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttOpen.Location = new System.Drawing.Point(440, 15);
            this.buttOpen.Name = "buttOpen";
            this.buttOpen.Size = new System.Drawing.Size(60, 29);
            this.buttOpen.TabIndex = 9;
            this.buttOpen.Text = "Open ►";
            this.buttOpen.UseVisualStyleBackColor = false;
            this.buttOpen.MouseEnter += new System.EventHandler(this.buttNewCreate_MouseEnter);
            this.buttOpen.MouseLeave += new System.EventHandler(this.buttNewCreate_MouseLeave);
            // 
            // panelUploadProgram
            // 
            this.panelUploadProgram.Controls.Add(this.textBoxUpload);
            this.panelUploadProgram.Controls.Add(this.buttBrowseUpload);
            this.panelUploadProgram.Controls.Add(this.buttUpload);
            this.panelUploadProgram.Location = new System.Drawing.Point(52, 182);
            this.panelUploadProgram.Name = "panelUploadProgram";
            this.panelUploadProgram.Size = new System.Drawing.Size(510, 56);
            this.panelUploadProgram.TabIndex = 14;
            this.panelUploadProgram.Visible = false;
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.Location = new System.Drawing.Point(9, 18);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.Size = new System.Drawing.Size(393, 20);
            this.textBoxUpload.TabIndex = 8;
            // 
            // buttBrowseUpload
            // 
            this.buttBrowseUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttBrowseUpload.Location = new System.Drawing.Point(408, 13);
            this.buttBrowseUpload.Name = "buttBrowseUpload";
            this.buttBrowseUpload.Size = new System.Drawing.Size(30, 29);
            this.buttBrowseUpload.TabIndex = 7;
            this.buttBrowseUpload.Text = "...";
            this.buttBrowseUpload.UseVisualStyleBackColor = false;
            // 
            // buttUpload
            // 
            this.buttUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttUpload.Location = new System.Drawing.Point(440, 13);
            this.buttUpload.Name = "buttUpload";
            this.buttUpload.Size = new System.Drawing.Size(60, 29);
            this.buttUpload.TabIndex = 6;
            this.buttUpload.Text = "Create ►";
            this.buttUpload.UseVisualStyleBackColor = false;
            this.buttUpload.MouseEnter += new System.EventHandler(this.buttNewCreate_MouseEnter);
            this.buttUpload.MouseLeave += new System.EventHandler(this.buttNewCreate_MouseLeave);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(623, 400);
            this.Controls.Add(this.panelUploadProgram);
            this.Controls.Add(this.panelOpenProgram);
            this.Controls.Add(this.panelNewProgram);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.labelNewProgram);
            this.Controls.Add(this.buttMinimize);
            this.Controls.Add(this.labelRev);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.logoQ);
            this.Controls.Add(this.label_Qapp);
            this.Controls.Add(this.menuStripStartup);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripStartup;
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qapp";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Startup_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Startup_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Startup_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logoQ)).EndInit();
            this.menuStripStartup.ResumeLayout(false);
            this.menuStripStartup.PerformLayout();
            this.panelNewProgram.ResumeLayout(false);
            this.groupBoxSiteName.ResumeLayout(false);
            this.groupBoxSiteName.PerformLayout();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxTelsec.ResumeLayout(false);
            this.panelOpenProgram.ResumeLayout(false);
            this.panelOpenProgram.PerformLayout();
            this.panelUploadProgram.ResumeLayout(false);
            this.panelUploadProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Qapp;
        private System.Windows.Forms.PictureBox logoQ;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label labelRev;
        private System.Windows.Forms.Button buttMinimize;
        private System.Windows.Forms.Label labelNewProgram;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.MenuStrip menuStripStartup;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator menuFileDropSeperator2;
        private System.Windows.Forms.ToolStripMenuItem menuRecent;
        private System.Windows.Forms.ToolStripSeparator menuFileDropSeperator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.ComboBox dropTelsec;
        private System.Windows.Forms.ComboBox dropExpansion;
        private System.Windows.Forms.Panel panelNewProgram;
        private System.Windows.Forms.Panel panelOpenProgram;
        private System.Windows.Forms.Panel panelUploadProgram;
        private System.Windows.Forms.GroupBox groupBoxSiteName;
        private System.Windows.Forms.TextBox textBoxSiteName;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.ComboBox dropCustomer;
        private System.Windows.Forms.GroupBox groupBoxTelsec;
        private System.Windows.Forms.Button buttNewCreate;
        private System.Windows.Forms.Button buttUpload;
        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.Button buttBrowseOpen;
        private System.Windows.Forms.Button buttOpen;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.Button buttBrowseUpload;
        private System.Windows.Forms.ToolStripMenuItem menuUpload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

