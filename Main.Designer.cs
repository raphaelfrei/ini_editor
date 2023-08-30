namespace IniEditor {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DgvSections = new DataGridView();
            Section = new DataGridViewTextBoxColumn();
            DgvValue = new DataGridView();
            Commentary = new DataGridViewCheckBoxColumn();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            BtnNewSection = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnNewKey = new Button();
            BtnSave = new Button();
            BtnCancel = new Button();
            menuStrip1 = new MenuStrip();
            FtsMenu = new ToolStripMenuItem();
            TSNewFile = new ToolStripMenuItem();
            TSOpenFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TSSaveFile = new ToolStripMenuItem();
            TSCloseFile = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            TSAbout = new ToolStripMenuItem();
            TSQuit = new ToolStripMenuItem();
            LbVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvSections).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvValue).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvSections
            // 
            DgvSections.AllowUserToAddRows = false;
            DgvSections.AllowUserToDeleteRows = false;
            DgvSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSections.Columns.AddRange(new DataGridViewColumn[] { Section });
            DgvSections.Location = new Point(24, 62);
            DgvSections.MultiSelect = false;
            DgvSections.Name = "DgvSections";
            DgvSections.RowTemplate.Height = 25;
            DgvSections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvSections.Size = new Size(240, 276);
            DgvSections.TabIndex = 0;
            DgvSections.CellClick += DgvSections_CellClick;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.Name = "Section";
            Section.ReadOnly = true;
            // 
            // DgvValue
            // 
            DgvValue.AllowUserToAddRows = false;
            DgvValue.AllowUserToDeleteRows = false;
            DgvValue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvValue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvValue.Columns.AddRange(new DataGridViewColumn[] { Commentary, Key, Value });
            DgvValue.Location = new Point(285, 62);
            DgvValue.MultiSelect = false;
            DgvValue.Name = "DgvValue";
            DgvValue.RowTemplate.Height = 25;
            DgvValue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvValue.Size = new Size(502, 276);
            DgvValue.TabIndex = 1;
            DgvValue.CellClick += DgvValue_CellClick;
            // 
            // Commentary
            // 
            Commentary.HeaderText = "Commentary";
            Commentary.Name = "Commentary";
            Commentary.ReadOnly = true;
            Commentary.Visible = false;
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.Name = "Key";
            Key.ReadOnly = true;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            Value.ReadOnly = true;
            // 
            // BtnNewSection
            // 
            BtnNewSection.Location = new Point(24, 368);
            BtnNewSection.Name = "BtnNewSection";
            BtnNewSection.Size = new Size(240, 23);
            BtnNewSection.TabIndex = 2;
            BtnNewSection.Text = "&New Section";
            BtnNewSection.UseVisualStyleBackColor = true;
            BtnNewSection.Click += BtnNewSection_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(672, 368);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(115, 23);
            BtnDelete.TabIndex = 3;
            BtnDelete.Text = "&Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDeleteSection_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(551, 368);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(115, 23);
            BtnEdit.TabIndex = 4;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(263, 303);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 352);
            label2.Name = "label2";
            label2.Size = new Size(790, 85);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(270, 49);
            label3.Name = "label3";
            label3.Size = new Size(532, 303);
            label3.TabIndex = 8;
            // 
            // BtnNewKey
            // 
            BtnNewKey.Location = new Point(24, 397);
            BtnNewKey.Name = "BtnNewKey";
            BtnNewKey.Size = new Size(240, 23);
            BtnNewKey.TabIndex = 9;
            BtnNewKey.Text = "New &Key";
            BtnNewKey.UseVisualStyleBackColor = true;
            BtnNewKey.Click += BtnNewKey_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(564, 449);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 23);
            BtnSave.TabIndex = 11;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(685, 449);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 23);
            BtnCancel.TabIndex = 10;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FtsMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(812, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // FtsMenu
            // 
            FtsMenu.DropDownItems.AddRange(new ToolStripItem[] { TSNewFile, TSOpenFile, toolStripSeparator1, TSSaveFile, TSCloseFile, toolStripSeparator2, TSAbout, TSQuit });
            FtsMenu.Name = "FtsMenu";
            FtsMenu.Size = new Size(37, 20);
            FtsMenu.Text = "File";
            // 
            // TSNewFile
            // 
            TSNewFile.Name = "TSNewFile";
            TSNewFile.Size = new Size(180, 22);
            TSNewFile.Text = "&New File";
            TSNewFile.Click += TSNewFile_Click;
            // 
            // TSOpenFile
            // 
            TSOpenFile.Name = "TSOpenFile";
            TSOpenFile.Size = new Size(180, 22);
            TSOpenFile.Text = "&Open File";
            TSOpenFile.Click += TSOpenFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // TSSaveFile
            // 
            TSSaveFile.Name = "TSSaveFile";
            TSSaveFile.Size = new Size(180, 22);
            TSSaveFile.Text = "&Save File";
            TSSaveFile.Click += TSSaveFile_Click;
            // 
            // TSCloseFile
            // 
            TSCloseFile.Name = "TSCloseFile";
            TSCloseFile.Size = new Size(180, 22);
            TSCloseFile.Text = "&Close File";
            TSCloseFile.Click += TSCloseFile_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // TSAbout
            // 
            TSAbout.Name = "TSAbout";
            TSAbout.Size = new Size(180, 22);
            TSAbout.Text = "&About";
            TSAbout.Click += TSAbout_Click;
            // 
            // TSQuit
            // 
            TSQuit.Name = "TSQuit";
            TSQuit.Size = new Size(180, 22);
            TSQuit.Text = "&Quit";
            TSQuit.Click += TSQuit_Click;
            // 
            // LbVersion
            // 
            LbVersion.AutoSize = true;
            LbVersion.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LbVersion.Location = new Point(12, 463);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(69, 12);
            LbVersion.TabIndex = 13;
            LbVersion.Text = "Main.cs [v1.00]";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 484);
            Controls.Add(LbVersion);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(BtnNewKey);
            Controls.Add(BtnEdit);
            Controls.Add(BtnDelete);
            Controls.Add(BtnNewSection);
            Controls.Add(DgvValue);
            Controls.Add(DgvSections);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main";
            Text = "INI File Maintenance - © Raphael Frei 2023";
            Shown += Main_Shown;
            ((System.ComponentModel.ISupportInitialize)DgvSections).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvValue).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvSections;
        private DataGridView DgvValue;
        private DataGridViewCheckBoxColumn Commentary;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private Button BtnNewSection;
        private Button BtnDelete;
        private Button BtnEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnNewKey;
        private Button BtnSave;
        private Button BtnCancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FtsMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem TSNewFile;
        private ToolStripMenuItem TSOpenFile;
        private ToolStripMenuItem TSSaveFile;
        private ToolStripMenuItem TSCloseFile;
        private ToolStripMenuItem TSAbout;
        private ToolStripMenuItem TSQuit;
        private Label LbVersion;
        private DataGridViewTextBoxColumn Section;
    }
}