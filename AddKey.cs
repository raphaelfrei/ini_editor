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
    public partial class AddKey : Form {

        public KeyAndValue? key;
        private bool hasChanged;

        public AddKey() {
            InitializeComponent();
            key = null;

            BtnSave.Enabled = false;
            hasChanged = false;
        }

        public AddKey(KeyAndValue key) {
            this.key = key;

            TbName.Text = key.Key.Replace('=', '\0');
            TbValue.Text = key.Value;

            BtnSave.Enabled = false;
            hasChanged = false;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TbName_TextChanged(object sender, EventArgs e) {
            hasChanged = true;
            BtnSave.Enabled = true;
        }

        private void TbValue_TextChanged(object sender, EventArgs e) {
            hasChanged = true;
            BtnSave.Enabled = true;
        }

        private void AddKey_FormClosing(object sender, FormClosingEventArgs e) {

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

        void SaveChanges() {

            key ??= new KeyAndValue();

            key.Key = TbName.Text.Replace('=', '\0').Trim();
            key.Value = TbValue.Text.Trim();

            BtnSave.Enabled = false;
            hasChanged = false;

        }


    }
}
