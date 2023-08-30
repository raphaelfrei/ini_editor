using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniEditor {

    public partial class AddSection : Form {

        public Section? section;
        private bool hasChanged;

        public AddSection() {
            InitializeComponent();
            section = null;

            BtnSave.Enabled = false;
            hasChanged = false;
        }

        public AddSection(Section section) {

            InitializeComponent();
            this.section = section;

            TbName.Text = section.Name;
            TbCommentary.Text = section.Description;

            if (TbCommentary.Text.StartsWith(';'))
                TbCommentary.Text = TbCommentary.Text[1..].Trim();

            TbName.Text = TbName.Text.Replace('[', '\0').Replace(']', '\0');

            BtnSave.Enabled = false;
            hasChanged = false;
        }

        /* Trigger - Is Closing */
        private void AddSection_FormClosing(object sender, FormClosingEventArgs e) {

            if (!hasChanged)
                return;

            DialogResult dr = MessageBox.Show("Do you want to save before quitting?", "Atention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            switch (dr) {

                case DialogResult.Yes:
                    SaveChanges();
                    break;

                case DialogResult.No:
                    e.Cancel = false;
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

            }

        }

        /* Text Box - Section Name */
        private void TbName_TextChanged(object sender, EventArgs e) {
            hasChanged = true;
            BtnSave.Enabled = true;
        }

        /* Text Box - Section Commentary */
        private void TbCommentary_TextChanged(object sender, EventArgs e) {
            hasChanged = true;
            BtnSave.Enabled = true;
        }

        private void SaveChanges() {

            if (TbCommentary.Text.StartsWith(';'))
                TbCommentary.Text = TbCommentary.Text[1..].Trim();

            if (section == null) {
                section = new Section($"[{TbName.Text.Replace('[', '\0').Replace(']', '\0').Trim()}]", $"; {TbCommentary.Text}");

            } else {
                section.Name = $"[{TbName.Text.Replace('[', '\0').Replace(']', '\0').Trim()}]";
                section.Description = $"; {TbCommentary.Text.Trim()}";
            }

            BtnSave.Enabled = false;
            hasChanged = false;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}