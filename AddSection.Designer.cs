namespace IniEditor {
    partial class AddSection {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSection));
            label1 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            LbVersion = new Label();
            TbName = new TextBox();
            TbCommentary = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(428, 199);
            label1.TabIndex = 7;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(204, 240);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 23);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(325, 240);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 23);
            BtnCancel.TabIndex = 12;
            BtnCancel.Text = "&Close";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LbVersion
            // 
            LbVersion.AutoSize = true;
            LbVersion.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LbVersion.Location = new Point(12, 251);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(97, 12);
            LbVersion.TabIndex = 14;
            LbVersion.Text = "AddSection.cs [v1.00]";
            // 
            // TbName
            // 
            TbName.Location = new Point(24, 75);
            TbName.Name = "TbName";
            TbName.Size = new Size(403, 23);
            TbName.TabIndex = 15;
            TbName.TextChanged += TbName_TextChanged;
            // 
            // TbCommentary
            // 
            TbCommentary.Location = new Point(24, 144);
            TbCommentary.Name = "TbCommentary";
            TbCommentary.Size = new Size(403, 23);
            TbCommentary.TabIndex = 16;
            TbCommentary.TextChanged += TbCommentary_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 17;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 126);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 18;
            label3.Text = "Commentary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 170);
            label4.Name = "label4";
            label4.Size = new Size(123, 12);
            label4.TabIndex = 19;
            label4.Text = "* Is not required to insert ';'";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 101);
            label5.Name = "label5";
            label5.Size = new Size(146, 12);
            label5.TabIndex = 20;
            label5.Text = "* Is not required to insert '[' or ']'";
            // 
            // AddSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 273);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TbCommentary);
            Controls.Add(TbName);
            Controls.Add(LbVersion);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddSection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add or Edit Section";
            FormClosing += AddSection_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnSave;
        private Button BtnCancel;
        private Label LbVersion;
        private TextBox TbName;
        private TextBox TbCommentary;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}