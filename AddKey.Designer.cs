namespace IniEditor {
    partial class AddKey {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKey));
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            TbValue = new TextBox();
            TbName = new TextBox();
            LbVersion = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 97);
            label5.Name = "label5";
            label5.Size = new Size(128, 12);
            label5.TabIndex = 30;
            label5.Text = "* Is not required to insert '='";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 122);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 28;
            label3.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 27;
            label2.Text = "Name:";
            // 
            // TbValue
            // 
            TbValue.Location = new Point(24, 140);
            TbValue.Name = "TbValue";
            TbValue.Size = new Size(403, 23);
            TbValue.TabIndex = 26;
            TbValue.TextChanged += TbValue_TextChanged;
            // 
            // TbName
            // 
            TbName.Location = new Point(24, 71);
            TbName.Name = "TbName";
            TbName.Size = new Size(403, 23);
            TbName.TabIndex = 25;
            TbName.TextChanged += TbName_TextChanged;
            // 
            // LbVersion
            // 
            LbVersion.AutoSize = true;
            LbVersion.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LbVersion.Location = new Point(12, 247);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(81, 12);
            LbVersion.TabIndex = 24;
            LbVersion.Text = "AddKey.cs [v1.00]";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(204, 236);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 23);
            BtnSave.TabIndex = 23;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(325, 236);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 23);
            BtnCancel.TabIndex = 22;
            BtnCancel.Text = "&Close";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(428, 199);
            label1.TabIndex = 21;
            // 
            // AddKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 270);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TbValue);
            Controls.Add(TbName);
            Controls.Add(LbVersion);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddKey";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add or Edit Key";
            FormClosing += AddKey_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox TbValue;
        private TextBox TbName;
        private Label LbVersion;
        private Button BtnSave;
        private Button BtnCancel;
        private Label label1;
    }
}