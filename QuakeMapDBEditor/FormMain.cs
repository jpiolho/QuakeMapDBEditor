using QuakeMapDBEditor.Models;
using QuakePakSharp;
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
        public static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions()
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
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

        private void UpdateState()
        {
            buttonEditEpisode.Enabled = comboBoxEpisodes.SelectedIndex >= 0;
            buttonDeleteEpisode.Enabled = comboBoxEpisodes.SelectedIndex >= 0;

            buttonAddMap.Enabled = comboBoxEpisodes.SelectedIndex >= 0;
            buttonDeleteMap.Enabled = listBoxMaps.SelectedIndex >= 0;
            buttonEditMap.Enabled = listBoxMaps.SelectedIndex >= 0;

            buttonMapMoveUp.Enabled = listBoxMaps.SelectedIndex > 0;
            buttonMapMoveDown.Enabled = listBoxMaps.SelectedIndex >= 0 && listBoxMaps.SelectedIndex < listBoxMaps.Items.Count - 1;
        }


        private void comboBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();

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



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskToSaveIfDirty())
                return;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;


            string raw;

            switch (Path.GetExtension(openFileDialog.FileName).ToUpperInvariant())
            {
                // Load from pak file
                case ".PAK":
                    {
                        using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            var pak = PakFile.FromStream(fs);

                            var entry = pak.FindEntryByName("mapdb.json");

                            if (entry == null)
                            {
                                MessageBox.Show("Could not find 'mapdb.json' in the pak file.", "Failed to load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            raw = Encoding.UTF8.GetString(entry.Data);
                        }
                        break;
                    }
                default:
                    {
                        raw = File.ReadAllText(openFileDialog.FileName);
                        break;
                    }
            }

            try
            {
                var json = JsonSerializer.Deserialize<MapDatabase>(raw, JsonSerializerOptions);
                _database = json;
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Failed to load file. Exception: {ex.Message}", "Failed to load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _filename = openFileDialog.FileName;
            Commit();

            PopulateEpisodes();

            // Select the first episode, if available
            if (_database.Episodes.Count > 0)
                comboBoxEpisodes.SelectedIndex = 0;
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_filename))
                saveAsToolStripMenuItem_Click(sender, EventArgs.Empty);
            else
                SaveDatabaseToFile(_filename);

            Commit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            SaveDatabaseToFile(saveFileDialog.FileName);
            Commit();
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
            UpdateState();

        }



        private void buttonAddMap_Click(object sender, EventArgs e)
        {
            var form = new FormMap(_database, new Map(), SelectedEpisode);

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

            // Press 'delete' button if the key delete was pressed
            if (e.KeyCode == Keys.Delete)
                buttonDeleteMap_Click(sender, e);
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete the map '{SelectedMap}'?", "Delete map", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            _database.Maps.Remove(SelectedMap);
            MarkDirty();

            PopulateMaps();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AskToSaveIfDirty())
            {
                // User cancelled the closing
                e.Cancel = true;
            }
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskToSaveIfDirty())
                return;

            _modified = false;
            _database = new MapDatabase();
            _filename = null;
            UpdateTitle();

            PopulateEpisodes();

        }



        /// <summary>
        /// Updates the form title
        /// </summary>
        private void UpdateTitle()
        {
            var sb = new StringBuilder();

            sb.Append("Quake MapDB Editor");

            // Add the modified star
            if (_modified)
                sb.Append("*");

            // Append the currently opened filename
            if (_filename != null)
                sb.Append($" - ({openFileDialog.FileName})");

            this.Text = sb.ToString();
        }


        /// <summary>
        /// Populates the episodes combobox
        /// </summary>
        private void PopulateEpisodes()
        {
            var selectedIndex = comboBoxEpisodes.SelectedIndex;

            comboBoxEpisodes.Items.Clear();
            comboBoxEpisodes.Items.AddRange(_database.Episodes.ToArray());

            comboBoxEpisodes.SelectedIndex = Math.Min(comboBoxEpisodes.Items.Count - 1, selectedIndex);

            comboBoxEpisodes_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Populates the maps listbox with maps from the currently selected episode
        /// </summary>
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

            // Re-select the current index or the one below in case the last item was deleted
            listBoxMaps.SelectedIndex = Math.Min(listBoxMaps.Items.Count - 1, selectedIndex);

            listBoxMaps_SelectedIndexChanged(this, EventArgs.Empty);
        }


        /// <summary>
        /// Commits the current session so that it is no longer dirty
        /// </summary>
        private void Commit()
        {
            _modified = false;
            UpdateTitle();
        }

        /// <summary>
        /// Marks the current session dirty (aka: modified)
        /// </summary>
        private void MarkDirty()
        {
            _modified = true;
            UpdateTitle();
        }

        /// <summary>
        /// Saves current database to a file
        /// </summary>
        /// <param name="filename"></param>
        private void SaveDatabaseToFile(string filename)
        {
            var json = JsonSerializer.Serialize(_database, JsonSerializerOptions);

            switch (Path.GetExtension(filename).ToUpperInvariant())
            {
                // Save directly into mapdb.json inside a pak
                case ".PAK":
                    {
                        PakFile pak;

                        pak = File.Exists(filename) ? PakFile.FromFile(filename) : new PakFile();

                        if (!pak.TryFindEntryByName("mapdb.json", out var entry))
                            pak.Entries.Add(entry = new PakFile.Entry() { Name = "mapdb.json" });

                        entry.Data = Encoding.UTF8.GetBytes(json);

                        pak.Save(filename);

                        break;
                    }
                default:
                    {
                        File.WriteAllText(filename, json);
                        break;
                    }
            }

            _filename = filename;
        }


        /// <summary>
        /// If the file has been modified, asks the user to save. Returns true if action was canceled.
        /// </summary>
        /// <returns></returns>
        private bool AskToSaveIfDirty()
        {
            if (_modified)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                    return true;

                if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            return false;
        }

        private void autoGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAutoGenerate();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var db = form.GeneratedDatabase;


            Database.Episodes = db.Episodes;
            Database.Maps = db.Maps;

            MarkDirty();

            PopulateEpisodes();

            // Select the first episode, if available
            if (_database.Episodes.Count > 0)
                comboBoxEpisodes.SelectedIndex = 0;
        }

        private void buttonMapMoveUp_Click(object sender, EventArgs e)
        {
            var idx = listBoxMaps.SelectedIndex;

            // Validate that it's a correct item
            if (idx <= 0)
                return;

            var temp = listBoxMaps.Items[idx - 1];
            listBoxMaps.Items[idx - 1] = listBoxMaps.Items[idx];
            listBoxMaps.Items[idx] = temp;

            listBoxMaps.SelectedIndex--;

            listBoxMaps_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void buttonMapMoveDown_Click(object sender, EventArgs e)
        {
            var idx = listBoxMaps.SelectedIndex;

            // Validate that it's a correct item
            if (idx < 0 || idx >= listBoxMaps.Items.Count-1)
                return;

            var temp = listBoxMaps.Items[idx + 1];
            listBoxMaps.Items[idx + 1] = listBoxMaps.Items[idx];
            listBoxMaps.Items[idx] = temp;

            listBoxMaps.SelectedIndex++;

            listBoxMaps_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
    }
}
