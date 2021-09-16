
namespace QuakeMapDBEditor
{
    partial class FormMap
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxBSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEpisode = new System.Windows.Forms.ComboBox();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDeathmatch = new System.Windows.Forms.CheckBox();
            this.checkBoxCooperative = new System.Windows.Forms.CheckBox();
            this.checkBoxBots = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleplayer = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChooseBSP = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(69, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(250, 23);
            this.textBoxTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(31, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxBSP
            // 
            this.textBoxBSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBSP.Location = new System.Drawing.Point(69, 41);
            this.textBoxBSP.Name = "textBoxBSP";
            this.textBoxBSP.Size = new System.Drawing.Size(218, 23);
            this.textBoxBSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BSP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Episode:";
            // 
            // comboBoxEpisode
            // 
            this.comboBoxEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEpisode.Enabled = false;
            this.comboBoxEpisode.FormattingEnabled = true;
            this.comboBoxEpisode.Location = new System.Drawing.Point(69, 70);
            this.comboBoxEpisode.Name = "comboBoxEpisode";
            this.comboBoxEpisode.Size = new System.Drawing.Size(250, 23);
            this.comboBoxEpisode.TabIndex = 2;
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(69, 99);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(250, 23);
            this.comboBoxGame.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Game:";
            // 
            // checkBoxDeathmatch
            // 
            this.checkBoxDeathmatch.AutoSize = true;
            this.checkBoxDeathmatch.Location = new System.Drawing.Point(165, 128);
            this.checkBoxDeathmatch.Name = "checkBoxDeathmatch";
            this.checkBoxDeathmatch.Size = new System.Drawing.Size(91, 19);
            this.checkBoxDeathmatch.TabIndex = 5;
            this.checkBoxDeathmatch.Text = "Deathmatch";
            this.checkBoxDeathmatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxCooperative
            // 
            this.checkBoxCooperative.AutoSize = true;
            this.checkBoxCooperative.Location = new System.Drawing.Point(69, 153);
            this.checkBoxCooperative.Name = "checkBoxCooperative";
            this.checkBoxCooperative.Size = new System.Drawing.Size(90, 19);
            this.checkBoxCooperative.TabIndex = 6;
            this.checkBoxCooperative.Text = "Cooperative";
            this.checkBoxCooperative.UseVisualStyleBackColor = true;
            // 
            // checkBoxBots
            // 
            this.checkBoxBots.AutoSize = true;
            this.checkBoxBots.Location = new System.Drawing.Point(165, 153);
            this.checkBoxBots.Name = "checkBoxBots";
            this.checkBoxBots.Size = new System.Drawing.Size(49, 19);
            this.checkBoxBots.TabIndex = 7;
            this.checkBoxBots.Text = "Bots";
            this.checkBoxBots.UseVisualStyleBackColor = true;
            // 
            // checkBoxSingleplayer
            // 
            this.checkBoxSingleplayer.AutoSize = true;
            this.checkBoxSingleplayer.Location = new System.Drawing.Point(69, 128);
            this.checkBoxSingleplayer.Name = "checkBoxSingleplayer";
            this.checkBoxSingleplayer.Size = new System.Drawing.Size(90, 19);
            this.checkBoxSingleplayer.TabIndex = 4;
            this.checkBoxSingleplayer.Text = "Singleplayer";
            this.checkBoxSingleplayer.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(244, 195);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(163, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChooseBSP
            // 
            this.buttonChooseBSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseBSP.Location = new System.Drawing.Point(293, 41);
            this.buttonChooseBSP.Name = "buttonChooseBSP";
            this.buttonChooseBSP.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseBSP.TabIndex = 10;
            this.buttonChooseBSP.Text = "...";
            this.buttonChooseBSP.UseVisualStyleBackColor = true;
            this.buttonChooseBSP.Click += new System.EventHandler(this.buttonChooseBSP_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.bsp";
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 230);
            this.Controls.Add(this.buttonChooseBSP);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxSingleplayer);
            this.Controls.Add(this.checkBoxBots);
            this.Controls.Add(this.checkBoxCooperative);
            this.Controls.Add(this.checkBoxDeathmatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGame);
            this.Controls.Add(this.comboBoxEpisode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBSP);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxBSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEpisode;
        private System.Windows.Forms.ComboBox comboBoxGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDeathmatch;
        private System.Windows.Forms.CheckBox checkBoxCooperative;
        private System.Windows.Forms.CheckBox checkBoxBots;
        private System.Windows.Forms.CheckBox checkBoxSingleplayer;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChooseBSP;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}