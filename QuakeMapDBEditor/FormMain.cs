using QuakeMapDBEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeMapDBEditor
{
    public partial class FormMain : Form
    {
        private static JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        private MapDatabase _database;
        private string _filename;
        private bool _modified;

        public MapDatabase Database => _database;
        public Episode SelectedEpisode
        {
            get => comboBoxEpisodes.SelectedItem as Episode;
            set => comboBoxEpisodes.SelectedItem = value;
        }
        public Map SelectedMap
        {
            get => listBoxMaps.SelectedItem as Map;
            set => listBoxMaps.SelectedItem = value;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateTitle()
        {
            var sb = new StringBuilder();

            sb.Append("Quake MapDB Editor");

            if (_modified)
                sb.Append("*");

            if (_filename != null)
                sb.Append($" - ({openFileDialog.FileName})");

            

            this.Text = sb.ToString();
        }

        private void comboBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteEpisode.Enabled = comboBoxEpisodes.SelectedIndex >= 0;
            buttonEditEpisode.Enabled = comboBoxEpisodes.SelectedIndex >= 0;
            buttonAddMap.Enabled = comboBoxEpisodes.SelectedIndex >= 0;

            PopulateMaps();

            listBoxMaps_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _database = new MapDatabase();
            PopulateEpisodes();

            comboBoxEpisodes_SelectedIndexChanged(this, EventArgs.Empty);

            UpdateTitle();
        }


        private void PopulateEpisodes()
        {
            var selectedIndex = comboBoxEpisodes.SelectedIndex;

            comboBoxEpisodes.Items.Clear();
            comboBoxEpisodes.Items.AddRange(_database.Episodes.ToArray());

            comboBoxEpisodes.SelectedIndex = Math.Min(comboBoxEpisodes.Items.Count - 1, selectedIndex);

            comboBoxEpisodes_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskToSaveIfDirty();

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var raw = File.ReadAllText(openFileDialog.FileName);

            try
            {
                var json = JsonSerializer.Deserialize<MapDatabase>(raw, _jsonSerializerOptions);
                _database = json;
            }
            catch(JsonException ex)
            {
                MessageBox.Show($"Failed to load file. Exception: {ex.Message}","Failed to load",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _filename = openFileDialog.FileName;
            Commit();

            PopulateEpisodes();

            comboBoxEpisodes.SelectedIndex = 0;
        }

        private void Commit()
        {
            _modified = false;
            UpdateTitle();
        }

        private void MarkDirty()
        {
            _modified = true;
            UpdateTitle();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_filename))
                saveAsToolStripMenuItem_Click(sender, EventArgs.Empty);
            else
                SaveToFile(_filename);

            Commit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            SaveToFile(saveFileDialog.FileName);
            Commit();
        }

        private void SaveToFile(string filename)
        {
            var json = JsonSerializer.Serialize(_database, _jsonSerializerOptions);

            File.WriteAllText(filename, json);

            _filename = filename;
        }

        private void buttonAddEpisode_Click(object sender, EventArgs e)
        {
            var form = new FormEpisode(new Episode());

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _database.Episodes.Add(form.Episode);
            PopulateEpisodes();

            // Select the new episode in the dropdown
            SelectedEpisode = form.Episode;
        }

        private void buttonEditEpisode_Click(object sender, EventArgs e)
        {
            var form = new FormEpisode(SelectedEpisode);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            MarkDirty();
            PopulateEpisodes();
        }

        private void buttonDeleteEpisode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete episode '{SelectedEpisode}'?", "Delete episode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            // Delete episode
            _database.Episodes.Remove(SelectedEpisode);
            // Delete all maps under this episode
            _database.Maps.RemoveAll(m => m.Episode.ToUpperInvariant() == SelectedEpisode.Directory.ToUpperInvariant());

            MarkDirty();
            PopulateEpisodes();
        }

        private void listBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteMap.Enabled = listBoxMaps.SelectedIndex >= 0;
            buttonEditMap.Enabled = listBoxMaps.SelectedIndex >= 0;
        }

        private void PopulateMaps()
        {
            if (SelectedEpisode == null)
            {
                listBoxMaps.Items.Clear();
                return;
            }

            var ep = SelectedEpisode.Directory.ToLowerInvariant();
            var maps = _database.Maps.Where(map => map.Episode.ToLowerInvariant() == ep);

            var selectedIndex = listBoxMaps.SelectedIndex;

            listBoxMaps.Items.Clear();
            listBoxMaps.Items.AddRange(maps.ToArray());

            listBoxMaps.SelectedIndex = Math.Min(listBoxMaps.Items.Count - 1, selectedIndex);

            listBoxMaps_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void buttonAddMap_Click(object sender, EventArgs e)
        {
            var form = new FormMap(_database,new Map(),SelectedEpisode);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _database.Maps.Add(form.Map);
            MarkDirty();

            PopulateMaps();
        }

        private void buttonEditMap_Click(object sender, EventArgs e)
        {
            var form = new FormMap(_database, listBoxMaps.SelectedItem as Map, SelectedEpisode);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            MarkDirty();
            PopulateMaps();
        }

        private void listBoxMaps_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedMap == null)
                return;

            buttonEditMap_Click(sender, e);
        }

        private void listBoxMaps_KeyDown(object sender, KeyEventArgs e)
        {
            if (SelectedMap == null)
                return;

            buttonDeleteMap_Click(sender, e);
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete the map '{SelectedMap}'?", "Delete map", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            MarkDirty();
            _database.Maps.Remove(SelectedMap);

            PopulateMaps();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AskToSaveIfDirty();
        }

        private void AskToSaveIfDirty()
        {
            if (_modified)
            {
                if (MessageBox.Show("There are unsaved changes. Do you want to save?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;

                saveToolStripMenuItem_Click(this, EventArgs.Empty);
            }
        }
    }
}
