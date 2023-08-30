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

    public partial class Main : Form {

        private List<Section> sections = new List<Section>();
        private Section? selectedSection;
        private bool lastClickWasSection = false;

        private KeyAndValue? selectedKey;

        private bool isCreating = false;
        private string fileName = "";

        public Main() {
            InitializeComponent();

        }

        private void Main_Shown(object sender, EventArgs e) {
            DisableAllButtons();

        }

        /* Button - Create Section */
        private void BtnNewSection_Click(object sender, EventArgs e) {

            AddSection section = new AddSection();

            section.ShowDialog();

            if (section.section != null)
                sections.Add(section.section);

            SectionToDGV();
            BtnSave.Enabled = true;

        }

        /* Button - Edit Section */
        private void BtnEdit_Click(object sender, EventArgs e) {

            if (selectedSection == null)
                return;

            if (lastClickWasSection) {

                AddSection section = new AddSection(selectedSection);

                section.ShowDialog();
                SectionToDGV();

            } else {

                AddKey key = new AddKey(selectedKey);

                key.ShowDialog();
                LoadKeyValue(selectedSection);

            }
        }

        private void BtnDeleteSection_Click(object sender, EventArgs e) {

            if (lastClickWasSection) {

                foreach (Section sec in sections) {

                    if (sec.Name == selectedSection.Name && sec.Description == selectedSection.Description) {
                        sections.Remove(sec);
                        SectionToDGV();
                        break;
                    }

                }

            } else {

                foreach (KeyAndValue key in selectedSection.KeyAndValue) {

                    if(key.Value == selectedKey.Value && key.Key == selectedKey.Key) {
                        selectedSection.KeyAndValue.Remove(key);
                        LoadKeyValue(selectedSection);
                        break;
                    }

                }

            }
        }


        private void TSNewFile_Click(object sender, EventArgs e) {

            isCreating = true;
            sections.Clear();
            SectionToDGV();

            BtnNewSection.Enabled = true;

        }

        private void TSOpenFile_Click(object sender, EventArgs e) {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ".INI File|*.ini";

            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == "")
                return;

            fileName = openFileDialog.FileName;
            isCreating = false;

            ReadINIFile(fileName);
            SectionToDGV();

        }

        private void BtnNewKey_Click(object sender, EventArgs e) {

            if (selectedSection == null || sections.Count == 0)
                return;

            AddKey add_key = new AddKey();
            add_key.ShowDialog();

            foreach (Section section in sections)
                if (section.Name == selectedSection.Name)
                    selectedSection.AddKeyAndValue(add_key.key);

            LoadKeyValue(selectedSection);


            BtnSave.Enabled = true;
        }


        private void BtnSave_Click(object sender, EventArgs e) {

            if (isCreating) {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ".INI File|*.ini";

                saveFile.ShowDialog();

                if (saveFile.FileName == "")
                    return;

                isCreating = false;
                fileName = saveFile.FileName;

            }

            SaveToFile();

        }

        /* Data Grid - Section */
        private void DgvSections_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex < 0)
                return;

            lastClickWasSection = true;

            foreach (Section section in sections) {

                DataGridViewRow row = DgvSections.Rows[e.RowIndex];

                if (section.Name == row.Cells[0].Value.ToString()) {
                    selectedSection = section;
                    BtnNewKey.Enabled = true;
                    break;
                }

            }

            if (selectedSection == null)
                return;

            LoadKeyValue(selectedSection);
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;

        }

        private void TSQuit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TSAbout_Click(object sender, EventArgs e) {
            About about = new About();
            about.ShowDialog();
        }

        private void TSCloseFile_Click(object sender, EventArgs e) {
            DisableAllButtons();
            sections.Clear();
            fileName = "";
            selectedSection = null;
            selectedKey = null;
        }

        /* Data Grid - Value */
        private void DgvValue_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex < 0 || selectedSection == null)
                return;

            lastClickWasSection = true;

            foreach (KeyAndValue key in selectedSection.KeyAndValue) {

                DataGridViewRow row = DgvSections.Rows[e.RowIndex];

                if (key.Key == row.Cells[0].Value.ToString() && key.Value == row.Cells[1].Value.ToString()) {
                    selectedKey = key;
                    break;
                }
            }

            if (selectedSection == null)
                return;

            LoadKeyValue(selectedSection);
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void TSSaveFile_Click(object sender, EventArgs e) {
            SaveToFile();
        }

        private void LoadKeyValue(Section section) {

            DgvValue.Rows.Clear();

            foreach (KeyAndValue keyAndValue in section.KeyAndValue)
                DgvValue.Rows.Add(keyAndValue.Key.Contains(';').ToString(), $"{keyAndValue.Key}", keyAndValue.Value);

        }

        private void DisableAllButtons() {

            BtnCancel.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnNewKey.Enabled = false;
            BtnNewSection.Enabled = false;
            BtnSave.Enabled = false;

        }

        private void SaveToFile() {

            if (String.IsNullOrEmpty(fileName))
                return;

            using (StreamWriter sw = new StreamWriter(fileName)) {

                foreach (Section section in sections) {

                    sw.WriteLine($"[{section.Name.Replace("[", "").Replace("]", "").Trim()}] ;{section.Description.Replace(';', '\0').Trim()}");
                    sw.WriteLine();

                    foreach (KeyAndValue key in section.KeyAndValue)
                        sw.WriteLine($"{key.Key.Replace("=", "")}={key.Value.Replace("=", "").Trim()}");

                    sw.WriteLine();
                }

            }

            MessageBox.Show("File saved!", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SectionToDGV() {

            DgvSections.Rows.Clear();
            DgvValue.Rows.Clear();

            BtnNewSection.Enabled = true;

            foreach (Section section in sections)
                DgvSections.Rows.Add(section.Name);

            if (sections.Count > 0) {
                BtnDelete.Enabled = true;
                BtnEdit.Enabled = true;

            }

        }

        private void ReadINIFile(string filePath) {

            using (StreamReader sr = new StreamReader(filePath)) {

                sections.Clear();

                Section curSection = new Section();

                int curLine = 0;
                bool isFirstLineASection = false;

                bool isEmpty = true;

                while (!sr.EndOfStream) {

                    string line = sr.ReadLine();

                    if (line == "" || line == null)
                        continue;

                    // Start Section
                    if (line.StartsWith("[")) {

                        string description = $"";

                        if (curLine == 0)
                            isFirstLineASection = true;

                        if (line.Contains(';')) {
                            description = line[(line.IndexOf(';') - 1)..];
                            line = line[..line.IndexOf(';')];
                        }

                        curSection = new Section(line, description);
                        sections.Add(curSection);

                        isEmpty = !isEmpty;

                        // Content
                    } else {

                        if (curLine == 0)
                            isFirstLineASection = false;

                        if (!isFirstLineASection && curLine == 0) {
                            curSection = new Section("[NaN]", "; Generated automatically by the program");
                            sections.Add(curSection);
                        }

                        curSection?.AddKeyAndValue(new KeyAndValue(line[..line.IndexOf("=")], line[(line.IndexOf("=") + 1)..]));
                    }
                    curLine++;

                }
            }
        }
    }
}
