
namespace QuakeMapDBEditor
{
    partial class FormEpisode
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
            this.components = new System.ComponentModel.Container();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxNeedSkillSelect = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxOverrideStartingMap = new System.Windows.Forms.TextBox();
            this.checkBoxOverrideStartingMap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textboxName
            // 
            this.textboxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxName.Location = new System.Drawing.Point(91, 16);
            this.textboxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(264, 27);
            this.textboxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 58);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(73, 20);
            this.labelDirectory.TabIndex = 3;
            this.labelDirectory.Text = "Directory:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(269, 226);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(86, 31);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(177, 226);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(91, 55);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(227, 27);
            this.textBoxDirectory.TabIndex = 1;
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFolder.Location = new System.Drawing.Point(325, 55);
            this.buttonChooseFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(30, 31);
            this.buttonChooseFolder.TabIndex = 4;
            this.buttonChooseFolder.Text = "...";
            this.toolTip.SetToolTip(this.buttonChooseFolder, "Browse folder...");
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // checkBoxNeedSkillSelect
            // 
            this.checkBoxNeedSkillSelect.AutoSize = true;
            this.checkBoxNeedSkillSelect.Location = new System.Drawing.Point(91, 90);
            this.checkBoxNeedSkillSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxNeedSkillSelect.Name = "checkBoxNeedSkillSelect";
            this.checkBoxNeedSkillSelect.Size = new System.Drawing.Size(138, 24);
            this.checkBoxNeedSkillSelect.TabIndex = 5;
            this.checkBoxNeedSkillSelect.Text = "Need skill select";
            this.checkBoxNeedSkillSelect.UseVisualStyleBackColor = true;
            // 
            // textBoxOverrideStartingMap
            // 
            this.textBoxOverrideStartingMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOverrideStartingMap.Location = new System.Drawing.Point(91, 151);
            this.textBoxOverrideStartingMap.Name = "textBoxOverrideStartingMap";
            this.textBoxOverrideStartingMap.Size = new System.Drawing.Size(266, 27);
            this.textBoxOverrideStartingMap.TabIndex = 6;
            // 
            // checkBoxOverrideStartingMap
            // 
            this.checkBoxOverrideStartingMap.AutoSize = true;
            this.checkBoxOverrideStartingMap.Location = new System.Drawing.Point(91, 121);
            this.checkBoxOverrideStartingMap.Name = "checkBoxOverrideStartingMap";
            this.checkBoxOverrideStartingMap.Size = new System.Drawing.Size(176, 24);
            this.checkBoxOverrideStartingMap.TabIndex = 8;
            this.checkBoxOverrideStartingMap.Text = "Override starting map";
            this.checkBoxOverrideStartingMap.UseVisualStyleBackColor = true;
            this.checkBoxOverrideStartingMap.CheckedChanged += new System.EventHandler(this.checkBoxOverrideStartingMap_CheckedChanged);
            // 
            // FormEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 266);
            this.Controls.Add(this.checkBoxOverrideStartingMap);
            this.Controls.Add(this.textBoxOverrideStartingMap);
            this.Controls.Add(this.checkBoxNeedSkillSelect);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textboxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEpisode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Episode";
            this.Load += new System.EventHandler(this.FormEpisode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxNeedSkillSelect;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxOverrideStartingMap;
        private System.Windows.Forms.CheckBox checkBoxOverrideStartingMap;
    }
}