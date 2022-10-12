using QuakeMapDBEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeMapDBEditor
{
    public partial class FormEpisode : Form
    {
        public Episode Episode { get; private set; }
        public FormEpisode(Episode episode)
        {
            InitializeComponent();

            this.Episode = episode;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Episode.Name = textboxName.Text;
            Episode.Directory = textBoxDirectory.Text;
            Episode.NeedsSkillSelect = checkBoxNeedSkillSelect.Checked;
            Episode.Map = checkBoxOverrideStartingMap.Checked ? textBoxOverrideStartingMap.Text : null;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormEpisode_Load(object sender, EventArgs e)
        {
            textboxName.Text = Episode.Name;
            textBoxDirectory.Text = Episode.Directory;
            checkBoxNeedSkillSelect.Checked = Episode.NeedsSkillSelect;
            checkBoxOverrideStartingMap.Checked = Episode.Map != null;
            textBoxOverrideStartingMap.Text = Episode.Map;

            UpdateState();
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxDirectory.Text = Path.GetFileName(folderBrowserDialog.SelectedPath);
        }


        private void UpdateState()
        {
            if(checkBoxOverrideStartingMap.Checked)
            {
                checkBoxNeedSkillSelect.Enabled = false;
                checkBoxNeedSkillSelect.Checked = false;
                textBoxOverrideStartingMap.Enabled = true;
            }
            else
            {
                checkBoxNeedSkillSelect.Enabled = true;
                textBoxOverrideStartingMap.Enabled = false;
            }
        }

        private void checkBoxOverrideStartingMap_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
        }
    }
}
