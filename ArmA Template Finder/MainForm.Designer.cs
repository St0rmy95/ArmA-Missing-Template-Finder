namespace ArmA_Template_Finder
{
    partial class MainForm
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
            this.tbTerrainBuilderFile = new System.Windows.Forms.TextBox();
            this.tbTemplateFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTBFile = new System.Windows.Forms.Button();
            this.btnTemplFolder = new System.Windows.Forms.Button();
            this.lbFoundItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbTerrainBuilderFile
            // 
            this.tbTerrainBuilderFile.Location = new System.Drawing.Point(12, 25);
            this.tbTerrainBuilderFile.Name = "tbTerrainBuilderFile";
            this.tbTerrainBuilderFile.Size = new System.Drawing.Size(452, 20);
            this.tbTerrainBuilderFile.TabIndex = 0;
            // 
            // tbTemplateFolder
            // 
            this.tbTemplateFolder.Location = new System.Drawing.Point(12, 64);
            this.tbTemplateFolder.Name = "tbTemplateFolder";
            this.tbTemplateFolder.Size = new System.Drawing.Size(452, 20);
            this.tbTemplateFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TerrainBuilder File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Template Folder";
            // 
            // btnTBFile
            // 
            this.btnTBFile.Location = new System.Drawing.Point(470, 23);
            this.btnTBFile.Name = "btnTBFile";
            this.btnTBFile.Size = new System.Drawing.Size(27, 23);
            this.btnTBFile.TabIndex = 4;
            this.btnTBFile.Text = "...";
            this.btnTBFile.UseVisualStyleBackColor = true;
            this.btnTBFile.Click += new System.EventHandler(this.btnTBFile_Click);
            // 
            // btnTemplFolder
            // 
            this.btnTemplFolder.Location = new System.Drawing.Point(470, 62);
            this.btnTemplFolder.Name = "btnTemplFolder";
            this.btnTemplFolder.Size = new System.Drawing.Size(27, 23);
            this.btnTemplFolder.TabIndex = 5;
            this.btnTemplFolder.Text = "...";
            this.btnTemplFolder.UseVisualStyleBackColor = true;
            this.btnTemplFolder.Click += new System.EventHandler(this.btnTemplFolder_Click);
            // 
            // lbFoundItems
            // 
            this.lbFoundItems.FormattingEnabled = true;
            this.lbFoundItems.Location = new System.Drawing.Point(12, 120);
            this.lbFoundItems.Name = "lbFoundItems";
            this.lbFoundItems.Size = new System.Drawing.Size(485, 303);
            this.lbFoundItems.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Missing Templates";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(422, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find Missing";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TerrainBuilder Files|*.txt";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Open TerrainBuilder file";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select Template folder.";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 430);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFoundItems);
            this.Controls.Add(this.btnTemplFolder);
            this.Controls.Add(this.btnTBFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTemplateFolder);
            this.Controls.Add(this.tbTerrainBuilderFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ArmA Missing Template Finder";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTerrainBuilderFile;
        private System.Windows.Forms.TextBox tbTemplateFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTBFile;
        private System.Windows.Forms.Button btnTemplFolder;
        private System.Windows.Forms.ListBox lbFoundItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

