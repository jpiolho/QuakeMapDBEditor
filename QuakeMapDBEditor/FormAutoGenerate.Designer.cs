
namespace QuakeMapDBEditor
{
    partial class FormAutoGenerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuakeFolder = new System.Windows.Forms.TextBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkedListBoxMods = new System.Windows.Forms.CheckedListBox();
            this.labelMods = new System.Windows.Forms.Label();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.labelSavedGames = new System.Windows.Forms.Label();
            this.textBoxSavedGamesFolder = new System.Windows.Forms.TextBox();
            this.buttonChooseFolderSavedGames = new System.Windows.Forms.Button();
            this.folderBrowserDialogSavedGames = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxSortMapsAlphabetically = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quake folder:";
            // 
            // textBoxQuakeFolder
            // 
            this.textBoxQuakeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuakeFolder.Location = new System.Drawing.Point(131, 12);
            this.textBoxQuakeFolder.Name = "textBoxQuakeFolder";
            this.textBoxQuakeFolder.Size = new System.Drawing.Size(355, 23);
            this.textBoxQuakeFolder.TabIndex = 1;
            this.textBoxQuakeFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuakeFolder_KeyDown);
            this.textBoxQuakeFolder.Leave += new System.EventHandler(this.textBoxQuakeFolder_Leave);
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFolder.Location = new System.Drawing.Point(492, 12);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseFolder.TabIndex = 11;
            this.buttonChooseFolder.Text = "...";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(12, 437);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(506, 20);
            this.labelWarning.TabIndex = 12;
            this.labelWarning.Text = "WARNING: This process can take a while and consume high amounts of RAM";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(12, 489);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(506, 23);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "Generate...";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 460);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(506, 23);
            this.progressBar.TabIndex = 14;
            // 
            // checkedListBoxMods
            // 
            this.checkedListBoxMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxMods.FormattingEnabled = true;
            this.checkedListBoxMods.Location = new System.Drawing.Point(12, 92);
            this.checkedListBoxMods.Name = "checkedListBoxMods";
            this.checkedListBoxMods.Size = new System.Drawing.Size(506, 256);
            this.checkedListBoxMods.TabIndex = 18;
            this.checkedListBoxMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMods_ItemCheck);
            // 
            // labelMods
            // 
            this.labelMods.AutoSize = true;
            this.labelMods.Location = new System.Drawing.Point(12, 74);
            this.labelMods.Name = "labelMods";
            this.labelMods.Size = new System.Drawing.Size(40, 15);
            this.labelMods.TabIndex = 19;
            this.labelMods.Text = "Mods:";
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelectAll.Location = new System.Drawing.Point(12, 355);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(95, 23);
            this.buttonSelectAll.TabIndex = 20;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeselectAll.Location = new System.Drawing.Point(113, 355);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(94, 23);
            this.buttonDeselectAll.TabIndex = 21;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
            // 
            // labelSavedGames
            // 
            this.labelSavedGames.AutoSize = true;
            this.labelSavedGames.Location = new System.Drawing.Point(12, 44);
            this.labelSavedGames.Name = "labelSavedGames";
            this.labelSavedGames.Size = new System.Drawing.Size(113, 15);
            this.labelSavedGames.TabIndex = 22;
            this.labelSavedGames.Text = "Saved games folder:";
            // 
            // textBoxSavedGamesFolder
            // 
            this.textBoxSavedGamesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSavedGamesFolder.Location = new System.Drawing.Point(131, 41);
            this.textBoxSavedGamesFolder.Name = "textBoxSavedGamesFolder";
            this.textBoxSavedGamesFolder.Size = new System.Drawing.Size(355, 23);
            this.textBoxSavedGamesFolder.TabIndex = 23;
            this.textBoxSavedGamesFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSavedGamesFolder_KeyDown);
            this.textBoxSavedGamesFolder.Leave += new System.EventHandler(this.textBoxSavedGamesFolder_Leave);
            // 
            // buttonChooseFolderSavedGames
            // 
            this.buttonChooseFolderSavedGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFolderSavedGames.Location = new System.Drawing.Point(492, 41);
            this.buttonChooseFolderSavedGames.Name = "buttonChooseFolderSavedGames";
            this.buttonChooseFolderSavedGames.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseFolderSavedGames.TabIndex = 24;
            this.buttonChooseFolderSavedGames.Text = "...";
            this.buttonChooseFolderSavedGames.UseVisualStyleBackColor = true;
            this.buttonChooseFolderSavedGames.Click += new System.EventHandler(this.buttonChooseFolderSavedGames_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptions.Controls.Add(this.checkBoxSortMapsAlphabetically);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 384);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(506, 50);
            this.groupBoxOptions.TabIndex = 25;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxSortMapsAlphabetically
            // 
            this.checkBoxSortMapsAlphabetically.AutoSize = true;
            this.checkBoxSortMapsAlphabetically.Location = new System.Drawing.Point(6, 22);
            this.checkBoxSortMapsAlphabetically.Name = "checkBoxSortMapsAlphabetically";
            this.checkBoxSortMapsAlphabetically.Size = new System.Drawing.Size(155, 19);
            this.checkBoxSortMapsAlphabetically.TabIndex = 0;
            this.checkBoxSortMapsAlphabetically.Text = "Sort maps alphabetically";
            this.checkBoxSortMapsAlphabetically.UseVisualStyleBackColor = true;
            // 
            // FormAutoGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 524);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonChooseFolderSavedGames);
            this.Controls.Add(this.textBoxSavedGamesFolder);
            this.Controls.Add(this.labelSavedGames);
            this.Controls.Add(this.buttonDeselectAll);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.labelMods);
            this.Controls.Add(this.checkedListBoxMods);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.textBoxQuakeFolder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Generate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAutoGenerate_FormClosing);
            this.Load += new System.EventHandler(this.FormAutoGenerate_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuakeFolder;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckedListBox checkedListBoxMods;
        private System.Windows.Forms.Label labelMods;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Label labelSavedGames;
        private System.Windows.Forms.TextBox textBoxSavedGamesFolder;
        private System.Windows.Forms.Button buttonChooseFolderSavedGames;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSavedGames;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxSortMapsAlphabetically;
    }
}