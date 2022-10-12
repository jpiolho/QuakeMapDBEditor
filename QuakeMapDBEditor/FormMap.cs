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
    public partial class FormMap : Form
    {
        public Map Map { get; private set; }
        public Episode Episode { get; private set; }

        private MapDatabase _database;

        public FormMap(MapDatabase database,Map map,Episode episode)
        {
            InitializeComponent();

            this.Map = map;
            this.Episode = episode;
            _database = database;
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            var episodes = _database.Episodes.Select(ep => ep.Directory).ToArray();
            comboBoxEpisode.Items.AddRange(episodes);
            comboBoxGame.Items.AddRange(episodes);

            comboBoxEpisode.SelectedItem = Episode.Directory;
            comboBoxGame.SelectedItem = Map.Game ?? Episode.Directory;

            textBoxTitle.Text = Map.Title;
            textBoxBSP.Text = Map.BSP;

            checkBoxBots.Checked = Map.Bots;
            checkBoxCooperative.Checked = Map.Cooperative;
            checkBoxDeathmatch.Checked = Map.Deathmatch;
            checkBoxSingleplayer.Checked = Map.Singleplayer;
            checkBoxCTF.Checked = Map.CTF;
            checkBoxHorde.Checked = Map.Horde;
        }

        private void buttonChooseBSP_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxBSP.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Map.Title = textBoxTitle.Text;
            Map.BSP = textBoxBSP.Text;
            Map.Episode = comboBoxEpisode.SelectedItem as string;
            Map.Game = comboBoxEpisode.SelectedItem as string;

            Map.Deathmatch = checkBoxDeathmatch.Checked;
            Map.Cooperative = checkBoxCooperative.Checked;
            Map.Bots = checkBoxBots.Checked;
            Map.Singleplayer = checkBoxSingleplayer.Checked;
            Map.Horde = checkBoxHorde.Checked;
            Map.CTF = checkBoxCTF.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
