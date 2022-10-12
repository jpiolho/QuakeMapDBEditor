using Gameloop.Vdf;
using Microsoft.Win32;
using QuakeMapDBEditor.Models;
using QuakePakSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeMapDBEditor
{
    public partial class FormAutoGenerate : Form
    {
        
        public static Dictionary<string, string> QuakeBuiltInModNames = new Dictionary<string, string>()
        {
            // Built-in
            { "id1", "$m_quake" },
            { "hipnotic", "$m_scourge" },
            { "rogue", "$m_dissolution" },
            { "dopa", "$m_dopa" },
            { "mg1", "$m_mg1" }
        };

        public static Dictionary<byte, char?> QuakeCharacterToASCIIDictionary = new Dictionary<byte, char?>()
        {
            { 1, null },            { 2, null },            { 3, null },            { 4, null },            { 5, null },
            { 6, null },            { 7, null },            { 8, null },            { 9, null },            { 10, ' ' },
            { 11, null },           { 12, ' ' },            { 13, ' ' },            { 14, null },           { 15, '.' },
            { 16, '[' },            { 17, ']' },            { 18, '0' },            { 19, '1' },            { 20, '2' },
            { 21, '3' },            { 22, '4' },            { 23, '5' },            { 24, '6' },            { 25, '7' },
            { 26, '8' },            { 27, '9' },            { 28, '.' },            { 29, null },           { 30, null },
            { 31, null },           { 32, ' ' },            { 33, '!' },            { 34, '\"' },           { 35, '#' },
            { 36, '$' },            { 37, '%' },            { 38, '&' },            { 39, '\'' },           { 40, '(' },
            { 41, ')' },            { 42, '*' },            { 43, '+' },            { 44, ',' },            { 45, '-' },
            { 46, '.' },            { 47, '/' },            { 48, '0' },            { 49, '1' },            { 50, '2' },
            { 51, '3' },            { 52, '4' },            { 53, '5' },            { 54, '6' },            { 55, '7' },
            { 56, '8' },            { 57, '9' },            { 58, ':' },            { 59, ';' },            { 60, '<' },
            { 61, '=' },            { 62, '>' },            { 63, '?' },            { 64, '@' },            { 65, 'A' },
            { 66, 'B' },            { 67, 'C' },            { 68, 'D' },            { 69, 'E' },            { 70, 'F' },
            { 71, 'G' },            { 72, 'H' },            { 73, 'I' },            { 74, 'J' },            { 75, 'K' },
            { 76, 'L' },            { 77, 'M' },            { 78, 'N' },            { 79, 'O' },            { 80, 'P' },
            { 81, 'Q' },            { 82, 'R' },            { 83, 'S' },            { 84, 'T' },            { 85, 'U' },
            { 86, 'V' },            { 87, 'W' },            { 88, 'X' },            { 89, 'Y' },            { 90, 'Z' },
            { 91, '[' },            { 92, '\\' },           { 93, ']' },            { 94, '^' },            { 95, '_' },
            { 96, '\'' },           { 97, 'a' },            { 98, 'b' },            { 99, 'c' },            { 100, 'd' },
            { 101, 'e' },           { 102, 'f' },           { 103, 'g' },           { 104, 'h' },           { 105, 'i' },
            { 106, 'j' },           { 107, 'k' },           { 108, 'l' },           { 109, 'm' },           { 110, 'n' },
            { 111, 'o' },           { 112, 'p' },           { 113, 'q' },           { 114, 'r' },           { 115, 's' },
            { 116, 't' },           { 117, 'u' },           { 118, 'v' },           { 119, 'w' },           { 120, 'x' },
            { 121, 'y' },           { 122, 'z' },           { 123, '{' },           { 124, '|' },           { 125, '}' },
            { 126, '~' },           { 127, null },          { 128, null },          { 129, null },          { 130, null },
            { 131, null },          { 132, null },          { 133, null },          { 134, null },          { 135, null },
            { 136, null },          { 137, null },          { 138, ' ' },           { 139, null },          { 140, ' ' },
            { 141, null },          { 142, null },          { 143, null },          { 144, '[' },           { 145, ']' },
            { 146, '0' },           { 147, '1' },           { 148, '2' },           { 149, '3' },           { 150, '4' },
            { 151, '5' },           { 152, '6' },           { 153, '7' },           { 154, '8' },           { 155, '9' },
            { 156, null },          { 157, null },          { 158, null },          { 159, null },          { 160, ' ' },
            { 161, '!' },           { 162, '\"' },          { 163, '#' },           { 164, '$' },           { 165, '%' },
            { 166, '&' },           { 167, '\'' },          { 168, '(' },           { 169, ')' },           { 170, '*' },
            { 171, '+' },           { 172, ',' },           { 173, '-' },           { 174, '.' },           { 175, '/' },
            { 176, '0' },           { 177, '1' },           { 178, '2' },           { 179, '3' },           { 180, '4' },
            { 181, '5' },           { 182, '6' },           { 183, '7' },           { 184, '8' },           { 185, '9' },
            { 186, ':' },           { 187, ';' },           { 188, '<' },           { 189, '=' },           { 190, '>' },
            { 191, '?' },           { 192, '@' },           { 193, 'A' },           { 194, 'B' },           { 195, 'C' },
            { 196, 'D' },           { 197, 'E' },           { 198, 'F' },           { 199, 'G' },           { 200, 'H' },
            { 201, 'I' },           { 202, 'J' },           { 203, 'K' },           { 204, 'L' },           { 205, 'M' },
            { 206, 'N' },           { 207, 'O' },           { 208, 'P' },           { 209, 'Q' },           { 210, 'R' },
            { 211, 'S' },           { 212, 'T' },           { 213, 'U' },           { 214, 'V' },           { 215, 'W' },
            { 216, 'X' },           { 217, 'Y' },           { 218, 'Z' },           { 219, '[' },           { 220, '\\' },
            { 221, ']' },           { 222, '^' },           { 223, '_' },           { 224, '\'' },          { 225, 'a' },
            { 226, 'b' },           { 227, 'c' },           { 228, 'd' },           { 229, 'e' },           { 230, 'f' },
            { 231, 'g' },           { 232, 'h' },           { 233, 'i' },           { 234, 'j' },           { 235, 'k' },
            { 236, 'l' },           { 237, 'm' },           { 238, 'n' },           { 239, 'o' },           { 240, 'p' },
            { 241, 'q' },           { 242, 'r' },           { 243, 's' },           { 244, 't' },           { 245, 'u' },
            { 246, 'v' },           { 247, 'w' },           { 248, 'x' },           { 249, 'y' },           { 250, 'z' },
            { 251, '{' },           { 252, '|' },           { 253, '}' },           { 254, '~' },           { 255, null },
        };


        public class ModInfo
        {
            public string Name { get; set; }
        }

        public MapDatabase GeneratedDatabase { get; private set; }


        public List<(string, Exception)> _generationExceptions;
        private string _modFolder, _savedGamesFolder;
        private bool _generating = false;

        public FormAutoGenerate()
        {
            InitializeComponent();
            this.SetDefaultIcon();

            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxQuakeFolder.Text = folderBrowserDialog.SelectedPath;

            UpdateModList();
        }

        private void buttonChooseFolderSavedGames_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSavedGames.ShowDialog() != DialogResult.OK)
                return;

            textBoxQuakeFolder.Text = folderBrowserDialogSavedGames.SelectedPath;

            UpdateModList();
        }

        private void FormAutoGenerate_Load(object sender, EventArgs e)
        {
            // Find quake folder
            var quakePath = GetQuakeSteamInstallPath();
            if (!string.IsNullOrEmpty(quakePath))
                textBoxQuakeFolder.Text = quakePath;

            // Find saved games folder
            var savedGames = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games", "Nightdive Studios", "Quake");
            if (Directory.Exists(savedGames))
                textBoxSavedGamesFolder.Text = savedGames;


            UpdateModList();
        }

        private static string GetQuakeSteamInstallPath()
        {
            var steamInstallPath = Registry.GetValue(Environment.Is64BitOperatingSystem ? @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam" : @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null);
            if (steamInstallPath == null)
                return null;

            var libraryFoldersPath = Path.Combine((string)steamInstallPath, "steamapps", "libraryfolders.vdf");
            if (!File.Exists(libraryFoldersPath))
                return null;

            // Parse VDF file
            var vdf = VdfConvert.Deserialize(File.ReadAllText(libraryFoldersPath));

            // Try to look for the app 2310 in each library
            int dirId = 0;
            var libraryFolders = vdf.Value;
            dynamic dir;
            while ((dir = libraryFolders[(dirId++).ToString()]) != null)
            {
                if (dir["apps"]["2310"] != null)
                {
                    return Path.Combine(dir["path"].ToString(), "steamapps", "common", "Quake", "rerelease");
                }
            }

            return null;
        }

        private async void buttonGenerate_Click(object sender, EventArgs e)
        {
            var db = new MapDatabase();
            var root = _modFolder;
            var savedRoot = _savedGamesFolder;

            _generationExceptions = new List<(string, Exception)>();

            try
            {
                _generating = true;
                UpdateState();
                

                // Setup the progress bar
                progressBar.Maximum = checkedListBoxMods.CheckedItems.Count;
                progressBar.Minimum = 0;
                progressBar.Value = 0;

                // Go through all the mods and generate 1 by 1
                for (var i = 0; i < checkedListBoxMods.CheckedItems.Count; i++)
                {
                    var mod = (string)checkedListBoxMods.CheckedItems[i];
                    
                    try
                    {

                        var maps = new List<Map>();
                        var folders = new string[]
                        {
                        Path.Combine(root,mod),
                        Path.Combine(savedRoot,mod)
                        };

                        foreach (var folder in folders)
                        {
                            if (Directory.Exists(folder))
                            {
                                maps.AddRange(await GetAllMapsInModFolderAsync(folder));
                            }
                        }

                        // Don't add empty mods
                        if (maps.Count == 0)
                            continue;


                        // Add the episode
                        var episode = new Episode();
                        episode.Directory = mod;
                        episode.Name = await GetModNameAsync(mod, folders);
                        db.Episodes.Add(episode);

                        // Sort the maps
                        if (checkBoxSortMapsAlphabetically.Checked)
                            maps = maps.OrderBy(m => m.BSP).ToList();

                        // Add the maps
                        foreach (var map in maps)
                        {
                            map.Episode = episode.Directory;
                            map.Game = map.Episode;

                            db.Maps.Add(map);
                        }

                    }
                    catch (Exception ex)
                    {
                        _generationExceptions.Add((mod, ex));
                    }
                    finally
                    {
                        progressBar.Value = i + 1;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"An unhandled exception occured while generating: {ex.ToString()}", "Failed to generate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                _generating = false;
                UpdateState();
            }


            if(_generationExceptions.Count > 0)
            {
                var form = new FormAutoGenerateExceptions(_generationExceptions);
                form.ShowDialog();
            }
            
            GeneratedDatabase = db;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private async Task<string> GetModNameAsync(string mod,string[] folders)
        {
            // Check if there's a built-in name
            if (QuakeBuiltInModNames.TryGetValue(mod.ToLowerInvariant(), out var builtInName))
                return builtInName;

            // Look for a mod.json in each of the folders
            foreach (var folder in folders)
            {
                var path = Path.Combine(folder, "mod.json");

                if (!File.Exists(path))
                    continue;

                return JsonSerializer.Deserialize<ModInfo>(await File.ReadAllTextAsync(path),FormMain.JsonSerializerOptions).Name;
            }

            // TODO: Look for a mod.json in the pak files. Only do this when the pak library doesn't load everything into memory.


            return mod;
        }


        private async Task<Map[]> GetAllMapsInModFolderAsync(string modFolder)
        {
            var maps = new List<Map>();

            var exceptionModFolder = Path.GetFileName(modFolder);



            if (checkBoxIgnorePakFiles.Checked == false)
            {
                int pakNumber = 0;
                string currentPak;
                // Add maps from sequential paks, starting at 0.
                while (File.Exists(currentPak = Path.Combine(modFolder, $"pak{pakNumber++}.pak")))
                {
                    var exceptionPak = Path.GetFileName(currentPak);

                    PakFile pak = await PakFile.FromFileAsync(currentPak);

                    foreach (var entry in pak.Entries)
                    {
                        if (Path.GetExtension(entry.Name).ToUpperInvariant() != ".BSP")
                            continue;


                        try
                        {
                            if (Path.GetDirectoryName(entry.Name) == "maps")
                            {
                                var bspName = Path.GetFileNameWithoutExtension(entry.Name);

                                // Remove duplicate map
                                if (checkBoxRemoveDuplicates.Checked && maps.Any(m => m.BSP == bspName))
                                    continue;

                                // Parse BSP
                                var info = GetMapFromBSP(entry.Data);
                                info.BSP = bspName;
                                info.Bots = HasBotSupport(bspName, modFolder, pak);

                                if (info.Singleplayer || info.Deathmatch || info.Cooperative)
                                    maps.Add(info);
                            }
                        }
                        catch (Exception ex)
                        {
                            _generationExceptions.Add(($"{exceptionModFolder}:{exceptionPak}:{entry.Name}", ex));
                        }
                    }

                    pak = null;
                    GC.Collect(); // Try to reclaim memory from the pak
                }
            }

            // Add maps from the mod/maps folder 
            if (checkBoxIgnoreLooseMaps.Checked == false)
            {
                var dirInfo = new DirectoryInfo(Path.Combine(modFolder, "maps"));
                if (dirInfo.Exists)
                {
                    foreach (var bsp in dirInfo.GetFiles("*.bsp"))
                    {
                        try
                        {
                            var info = GetMapFromBSP(await File.ReadAllBytesAsync(bsp.FullName));

                            info.BSP = Path.GetFileNameWithoutExtension(bsp.Name);

                            // Remove duplicate map
                            if (checkBoxRemoveDuplicates.Checked && maps.Any(m => m.BSP == info.BSP))
                                continue;

                            info.Bots = HasBotSupport(info.BSP, modFolder, null);

                            if (info.Singleplayer || info.Deathmatch || info.Cooperative)
                                maps.Add(info);
                        }
                        catch (Exception ex)
                        {
                            _generationExceptions.Add(($"{exceptionModFolder}:{bsp.Name}", ex));
                        }
                    }
                }
            }


            return maps.ToArray();
        }

        private bool HasBotSupport(string mapName, string modFolder, PakFile pak)
        {
            // Check in the mod folder
            if (File.Exists(Path.Combine(modFolder, "bots", "navigation", mapName + ".nav")))
                return true;

            // Check inside the pak
            if (pak != null && pak.Entries.Any(e => e.Name.Equals($"bots/navigation/{mapName}.nav", StringComparison.OrdinalIgnoreCase)))
                return true;

            return false;
        }

        private Map GetMapFromBSP(byte[] bspData)
        {
            var data = Encoding.Latin1.GetString(bspData);

            // Find the start of the entity data. (Assuming worldspawn is the first entity)
            var idx = data.IndexOf("worldspawn");
            if (idx == -1)
                throw new InvalidDataException("Could not find worldspawn");

            // Find the start of the token
            var startIdx = data.LastIndexOf("{", idx);
            if (startIdx == -1)
                throw new InvalidDataException("Could not find start of worldspawn token");

            // Find the end of the token
            var endIdx = data.IndexOf("}", startIdx);
            if (endIdx == -1)
                throw new InvalidDataException("Could not find end of worldspawn token");


            // Parse all entities in the map
            var entities = new List<Dictionary<string, string>>();
            var currentEnt = new Dictionary<string, string>();
            int mode = 0;

            var buffer = new StringBuilder();
            string key = null;
            bool escape = false;

            for (var i = startIdx; i < data.Length; i++)
            {
                var c = data[i];

                if (mode == 0) // No token
                {
                    if (c == '{')
                        mode = 1;
                    else if (c == '\0') // End of non-garbage data
                        break;
                }
                else if (mode == 1) // In token
                {
                    if (c == '"')
                    {
                        mode = 2; // Reading string
                        buffer.Clear();
                    }
                    else if (c == '}')
                    {
                        // Leave token
                        mode = 0;

                        entities.Add(currentEnt);
                        currentEnt = new Dictionary<string, string>();
                    }
                }
                else if (mode == 2) // Reading string
                {
                    if (!escape && c == '"')
                    {
                        mode = 1; // In token

                        if (key == null)
                            key = buffer.ToString().ToLowerInvariant();
                        else
                        {
                            currentEnt[key] = buffer.ToString();
                            key = null;
                        }
                    }
                    else
                    {
                        if (c == '\\' && !escape)
                            escape = true;
                        else
                        {
                            if (escape && c == 'n')
                                buffer.Append('\n');
                            else
                                buffer.Append(c);

                            escape = false;
                        }
                    }
                }

            }

            var info = new Map();

            // Read map name from worldspawn "message"
            var worldspawn = entities.SingleOrDefault(e => e.ContainsKey("classname") && e["classname"] == "worldspawn");
            if (worldspawn != null && worldspawn.TryGetValue("message", out var message))
            {
                info.Title = TransformQuakeStringToNormalString(message.Split('\n')[0]).Trim();

                if(info.Title.Length > 1)
                    info.Title = char.ToUpper(info.Title[0]) + info.Title.Substring(1,Math.Min(info.Title.Length-1,31));
            }
            else
            {
                info.Title = "";
            }

            info.Singleplayer = entities.Any(e => e.TryGetValue("classname", out var classname) && classname == "info_player_start");
            info.Deathmatch = entities.Any(e => e.TryGetValue("classname", out var classname) && classname == "info_player_deathmatch");
            info.Cooperative = entities.Any(e => e.TryGetValue("classname", out var classname) && classname == "info_player_coop");
            info.CTF = entities.Any(e => e.TryGetValue("classname", out var classname) && (classname == "item_flag_team1" || classname == "item_flag_team2"));
            info.Horde = entities.Any(e => e.TryGetValue("classname", out var classname) && classname == "horde_manager");

            // TODO: Figure out something in case mod uses custom entities for deathmatch, coop and single player. Probably very few exist though.


            return info;
        }


        
        private string TransformQuakeStringToNormalString(string quakeString)
        {
            var sb = new StringBuilder();

            foreach (var c in quakeString)
            {
                if (QuakeCharacterToASCIIDictionary.TryGetValue((byte)c, out var newChar))
                    sb.Append(newChar);
            }

            return sb.ToString();
        }


        private void textBoxQuakeFolder_Leave(object sender, EventArgs e)
        {
            UpdateModList();
        }




        private void UpdateModList()
        {
            var quakePath = textBoxQuakeFolder.Text.Trim();
            var savedGamesPath = textBoxSavedGamesFolder.Text.Trim();

            bool update = false;

            if (_modFolder != quakePath)
            {
                update = true;
                this._modFolder = quakePath;
            }

            if (_savedGamesFolder != savedGamesPath)
            {
                update = true;
                this._savedGamesFolder = savedGamesPath;
            }


            if (update)
            {
                var mods = new List<string>();

                checkedListBoxMods.Items.Clear();

                if (!string.IsNullOrEmpty(_modFolder))
                {
                    var dirInfo = new DirectoryInfo(quakePath);
                    if (dirInfo.Exists)
                        mods.AddRange(dirInfo.GetDirectories().Select(d => d.Name));
                }

                if (!string.IsNullOrEmpty(_savedGamesFolder))
                {
                    var dirInfo = new DirectoryInfo(savedGamesPath);
                    if (dirInfo.Exists)
                        mods.AddRange(dirInfo.GetDirectories().Select(d => d.Name).Where(d => !mods.Contains(d)));
                }

                checkedListBoxMods.Items.AddRange(mods.ToArray());
            }


            UpdateState();
        }

        private void textBoxQuakeFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdateModList();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBoxMods.Items.Count; i++)
                checkedListBoxMods.SetItemChecked(i, true);

            UpdateState();
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBoxMods.Items.Count; i++)
                checkedListBoxMods.SetItemChecked(i, false);

            UpdateState();
        }

        private void checkedListBoxMods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                UpdateState();
            }));
        }


        private void UpdateState()
        {
            buttonSelectAll.Enabled = !_generating && checkedListBoxMods.CheckedItems.Count != checkedListBoxMods.Items.Count;
            buttonDeselectAll.Enabled = !_generating && checkedListBoxMods.CheckedItems.Count > 0;
            buttonGenerate.Enabled = !_generating && checkedListBoxMods.CheckedItems.Count > 0;

            checkedListBoxMods.SelectionMode = !_generating ? SelectionMode.One : SelectionMode.None;
            buttonChooseFolder.Enabled = !_generating;
            buttonChooseFolderSavedGames.Enabled = !_generating;
            textBoxQuakeFolder.ReadOnly = _generating;

            checkBoxSortMapsAlphabetically.Enabled = !_generating;
            checkBoxIgnoreLooseMaps.Enabled = !_generating;
            checkBoxIgnorePakFiles.Enabled = !_generating;
            checkBoxRemoveDuplicates.Enabled = !_generating;
        }

        private void textBoxSavedGamesFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdateModList();
        }

        private void textBoxSavedGamesFolder_Leave(object sender, EventArgs e)
        {
            UpdateModList();
        }

        private void FormAutoGenerate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_generating)
                e.Cancel = true;
        }
    }
}
