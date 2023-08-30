namespace IniEditor {
    partial class About {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            LbVersion = new Label();
            label1 = new Label();
            label2 = new Label();
            LLVersion = new LinkLabel();
            LLGitHub = new LinkLabel();
            LLSite = new LinkLabel();
            SuspendLayout();
            // 
            // LbVersion
            // 
            LbVersion.AutoSize = true;
            LbVersion.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LbVersion.Location = new Point(12, 189);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(74, 12);
            LbVersion.TabIndex = 15;
            LbVersion.Text = "About.cs [v1.00]";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 175);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(256, 172);
            label2.TabIndex = 16;
            label2.Text = ".INI File Editor - © Raphael Frei 2023\r\n\r\n- .INI File creator and editor free software.\r\n\r\nInformation:\r\n\r\n- Current Version:\r\n- My GitHub: \r\n- My WebSite:\r\n\r\nDeveloped by Raphael Frei\r\n";
            // 
            // LLVersion
            // 
            LLVersion.AutoSize = true;
            LLVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LLVersion.Location = new Point(111, 103);
            LLVersion.Name = "LLVersion";
            LLVersion.Size = new Size(31, 15);
            LLVersion.TabIndex = 17;
            LLVersion.TabStop = true;
            LLVersion.Text = "1.0.0";
            LLVersion.LinkClicked += LLVersion_LinkClicked;
            // 
            // LLGitHub
            // 
            LLGitHub.AutoSize = true;
            LLGitHub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LLGitHub.Location = new Point(89, 118);
            LLGitHub.Name = "LLGitHub";
            LLGitHub.Size = new Size(53, 15);
            LLGitHub.TabIndex = 18;
            LLGitHub.TabStop = true;
            LLGitHub.Text = "Click me";
            LLGitHub.LinkClicked += LLGitHub_LinkClicked;
            // 
            // LLSite
            // 
            LLSite.AutoSize = true;
            LLSite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LLSite.Location = new Point(93, 133);
            LLSite.Name = "LLSite";
            LLSite.Size = new Size(53, 15);
            LLSite.TabIndex = 19;
            LLSite.TabStop = true;
            LLSite.Text = "Click me";
            LLSite.LinkClicked += LLSite_LinkClicked;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 210);
            Controls.Add(LLSite);
            Controls.Add(LLGitHub);
            Controls.Add(LLVersion);
            Controls.Add(label2);
            Controls.Add(LbVersion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbVersion;
        private Label label1;
        private Label label2;
        private LinkLabel LLVersion;
        private LinkLabel LLGitHub;
        private LinkLabel LLSite;
    }
}