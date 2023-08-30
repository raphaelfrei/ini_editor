using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniEditor {

    public partial class About : Form {

        public About() {
            InitializeComponent();
        }

        private void LLVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start($"{Directory.GetCurrentDirectory()}\\changelog.log");
        }

        private void LLGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/raphaelfrei");
        }

        private void LLSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://www.raphaelfrei.com.br");
        }
    }
}
