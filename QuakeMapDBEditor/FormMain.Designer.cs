
namespace QuakeMapDBEditor
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEpisodes = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddEpisode = new System.Windows.Forms.Button();
            this.buttonEditEpisode = new System.Windows.Forms.Button();
            this.buttonDeleteEpisode = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.labelMaps = new System.Windows.Forms.Label();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.buttonEditMap = new System.Windows.Forms.Button();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMapMoveDown = new System.Windows.Forms.Button();
            this.buttonMapMoveUp = new System.Windows.Forms.Button();
            this.buttonMapSort = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.byTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBspToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Episode:";
            // 
            // comboBoxEpisodes
            // 
            this.comboBoxEpisodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEpisodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEpisodes.FormattingEnabled = true;
            this.comboBoxEpisodes.Location = new System.Drawing.Point(79, 36);
            this.comboBoxEpisodes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEpisodes.Name = "comboBoxEpisodes";
            this.comboBoxEpisodes.Size = new System.Drawing.Size(356, 28);
            this.comboBoxEpisodes.TabIndex = 1;
            this.comboBoxEpisodes.SelectedIndexChanged += new System.EventHandler(this.comboBoxEpisodes_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(549, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoGenerateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // autoGenerateToolStripMenuItem
            // 
            this.autoGenerateToolStripMenuItem.Name = "autoGenerateToolStripMenuItem";
            this.autoGenerateToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.autoGenerateToolStripMenuItem.Text = "Auto generate...";
            this.autoGenerateToolStripMenuItem.Click += new System.EventHandler(this.autoGenerateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // buttonAddEpisode
            // 
            this.buttonAddEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEpisode.Image = global::QuakeMapDBEditor.Properties.Resources.Add_16x;
            this.buttonAddEpisode.Location = new System.Drawing.Point(442, 36);
            this.buttonAddEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddEpisode.Name = "buttonAddEpisode";
            this.buttonAddEpisode.Size = new System.Drawing.Size(26, 31);
            this.buttonAddEpisode.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonAddEpisode, "Add episode...");
            this.buttonAddEpisode.UseVisualStyleBackColor = true;
            this.buttonAddEpisode.Click += new System.EventHandler(this.buttonAddEpisode_Click);
            // 
            // buttonEditEpisode
            // 
            this.buttonEditEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEpisode.Image = global::QuakeMapDBEditor.Properties.Resources.Edit_16x;
            this.buttonEditEpisode.Location = new System.Drawing.Point(475, 36);
            this.buttonEditEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditEpisode.Name = "buttonEditEpisode";
            this.buttonEditEpisode.Size = new System.Drawing.Size(26, 31);
            this.buttonEditEpisode.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonEditEpisode, "Edit episode...");
            this.buttonEditEpisode.UseVisualStyleBackColor = true;
            this.buttonEditEpisode.Click += new System.EventHandler(this.buttonEditEpisode_Click);
            // 
            // buttonDeleteEpisode
            // 
            this.buttonDeleteEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEpisode.Image = global::QuakeMapDBEditor.Properties.Resources.Trash_16x;
            this.buttonDeleteEpisode.Location = new System.Drawing.Point(509, 36);
            this.buttonDeleteEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteEpisode.Name = "buttonDeleteEpisode";
            this.buttonDeleteEpisode.Size = new System.Drawing.Size(26, 31);
            this.buttonDeleteEpisode.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonDeleteEpisode, "Delete episode...");
            this.buttonDeleteEpisode.UseVisualStyleBackColor = true;
            this.buttonDeleteEpisode.Click += new System.EventHandler(this.buttonDeleteEpisode_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Json files|*.json|Pak files|*.pak|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "mapdb.json";
            this.saveFileDialog.Filter = "Json file|*.json|Pak file|*.pak|All files|*.*";
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 20;
            this.listBoxMaps.Location = new System.Drawing.Point(79, 75);
            this.listBoxMaps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMaps.Size = new System.Drawing.Size(456, 524);
            this.listBoxMaps.TabIndex = 6;
            this.listBoxMaps.SelectedIndexChanged += new System.EventHandler(this.listBoxMaps_SelectedIndexChanged);
            this.listBoxMaps.DoubleClick += new System.EventHandler(this.listBoxMaps_DoubleClick);
            this.listBoxMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMaps_KeyDown);
            // 
            // labelMaps
            // 
            this.labelMaps.AutoSize = true;
            this.labelMaps.Location = new System.Drawing.Point(27, 79);
            this.labelMaps.Name = "labelMaps";
            this.labelMaps.Size = new System.Drawing.Size(48, 20);
            this.labelMaps.TabIndex = 7;
            this.labelMaps.Text = "Maps:";
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMap.Image = global::QuakeMapDBEditor.Properties.Resources.Add_16x;
            this.buttonAddMap.Location = new System.Drawing.Point(333, 607);
            this.buttonAddMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(26, 31);
            this.buttonAddMap.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonAddMap, "Add map...");
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.buttonAddMap_Click);
            // 
            // buttonEditMap
            // 
            this.buttonEditMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditMap.Image = global::QuakeMapDBEditor.Properties.Resources.Edit_16x;
            this.buttonEditMap.Location = new System.Drawing.Point(365, 607);
            this.buttonEditMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditMap.Name = "buttonEditMap";
            this.buttonEditMap.Size = new System.Drawing.Size(26, 31);
            this.buttonEditMap.TabIndex = 9;
            this.toolTip.SetToolTip(this.buttonEditMap, "Edit map...");
            this.buttonEditMap.UseVisualStyleBackColor = true;
            this.buttonEditMap.Click += new System.EventHandler(this.buttonEditMap_Click);
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMap.Image = global::QuakeMapDBEditor.Properties.Resources.Trash_16x;
            this.buttonDeleteMap.Location = new System.Drawing.Point(397, 607);
            this.buttonDeleteMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(26, 31);
            this.buttonDeleteMap.TabIndex = 10;
            this.toolTip.SetToolTip(this.buttonDeleteMap, "Delete map...");
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.buttonDeleteMap_Click);
            // 
            // buttonMapMoveDown
            // 
            this.buttonMapMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMapMoveDown.Image = global::QuakeMapDBEditor.Properties.Resources.Download_16x;
            this.buttonMapMoveDown.Location = new System.Drawing.Point(469, 607);
            this.buttonMapMoveDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMapMoveDown.Name = "buttonMapMoveDown";
            this.buttonMapMoveDown.Size = new System.Drawing.Size(26, 31);
            this.buttonMapMoveDown.TabIndex = 11;
            this.toolTip.SetToolTip(this.buttonMapMoveDown, "Move map down");
            this.buttonMapMoveDown.UseVisualStyleBackColor = true;
            this.buttonMapMoveDown.Click += new System.EventHandler(this.buttonMapMoveDown_Click);
            // 
            // buttonMapMoveUp
            // 
            this.buttonMapMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMapMoveUp.Image = global::QuakeMapDBEditor.Properties.Resources.Upload_16x;
            this.buttonMapMoveUp.Location = new System.Drawing.Point(437, 607);
            this.buttonMapMoveUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMapMoveUp.Name = "buttonMapMoveUp";
            this.buttonMapMoveUp.Size = new System.Drawing.Size(26, 31);
            this.buttonMapMoveUp.TabIndex = 12;
            this.toolTip.SetToolTip(this.buttonMapMoveUp, "Move map up");
            this.buttonMapMoveUp.UseVisualStyleBackColor = true;
            this.buttonMapMoveUp.Click += new System.EventHandler(this.buttonMapMoveUp_Click);
            // 
            // buttonMapSort
            // 
            this.buttonMapSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMapSort.Image = global::QuakeMapDBEditor.Properties.Resources.SortLines;
            this.buttonMapSort.Location = new System.Drawing.Point(509, 607);
            this.buttonMapSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMapSort.Name = "buttonMapSort";
            this.buttonMapSort.Size = new System.Drawing.Size(26, 31);
            this.buttonMapSort.TabIndex = 15;
            this.toolTip.SetToolTip(this.buttonMapSort, "Sort maps...");
            this.buttonMapSort.UseVisualStyleBackColor = true;
            this.buttonMapSort.Click += new System.EventHandler(this.buttonMapSort_Click);
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.AutoSize = true;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(429, 612);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(2, 22);
            this.separator.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(501, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 22);
            this.label2.TabIndex = 14;
            // 
            // contextMenuStripSort
            // 
            this.contextMenuStripSort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byTitleToolStripMenuItem,
            this.byBspToolStripMenuItem});
            this.contextMenuStripSort.Name = "contextMenuStrip1";
            this.contextMenuStripSort.Size = new System.Drawing.Size(134, 52);
            // 
            // byTitleToolStripMenuItem
            // 
            this.byTitleToolStripMenuItem.Name = "byTitleToolStripMenuItem";
            this.byTitleToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.byTitleToolStripMenuItem.Text = "By title...";
            this.byTitleToolStripMenuItem.Click += new System.EventHandler(this.byTitleToolStripMenuItem_Click);
            // 
            // byBspToolStripMenuItem
            // 
            this.byBspToolStripMenuItem.Name = "byBspToolStripMenuItem";
            this.byBspToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.byBspToolStripMenuItem.Text = "By bsp...";
            this.byBspToolStripMenuItem.Click += new System.EventHandler(this.byBspToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 655);
            this.Controls.Add(this.buttonMapSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.buttonMapMoveUp);
            this.Controls.Add(this.buttonMapMoveDown);
            this.Controls.Add(this.buttonDeleteMap);
            this.Controls.Add(this.buttonEditMap);
            this.Controls.Add(this.buttonAddMap);
            this.Controls.Add(this.labelMaps);
            this.Controls.Add(this.listBoxMaps);
            this.Controls.Add(this.buttonDeleteEpisode);
            this.Controls.Add(this.buttonEditEpisode);
            this.Controls.Add(this.buttonAddEpisode);
            this.Controls.Add(this.comboBoxEpisodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Quake MapDB Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEpisodes;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button buttonAddEpisode;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditEpisode;
        private System.Windows.Forms.Button buttonDeleteEpisode;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox listBoxMaps;
        private System.Windows.Forms.Label labelMaps;
        private System.Windows.Forms.Button buttonAddMap;
        private System.Windows.Forms.Button buttonEditMap;
        private System.Windows.Forms.Button buttonDeleteMap;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoGenerateToolStripMenuItem;
        private System.Windows.Forms.Button buttonMapMoveDown;
        private System.Windows.Forms.Button buttonMapMoveUp;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMapSort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSort;
        private System.Windows.Forms.ToolStripMenuItem byTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBspToolStripMenuItem;
    }
}

