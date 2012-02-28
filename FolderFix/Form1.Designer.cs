namespace FolderFix
{
    partial class Form1
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
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderList = new System.Windows.Forms.ListView();
            this.MoveFilesButton = new System.Windows.Forms.Button();
            this.RenameFilesButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Location = new System.Drawing.Point(13, 13);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(266, 23);
            this.OpenFolderButton.TabIndex = 0;
            this.OpenFolderButton.Text = "Open Folder";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // FolderList
            // 
            this.FolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderList.GridLines = true;
            this.FolderList.Location = new System.Drawing.Point(13, 42);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(927, 434);
            this.FolderList.TabIndex = 2;
            this.FolderList.UseCompatibleStateImageBehavior = false;
            this.FolderList.View = System.Windows.Forms.View.Details;
            // 
            // MoveFilesButton
            // 
            this.MoveFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveFilesButton.Location = new System.Drawing.Point(285, 13);
            this.MoveFilesButton.Name = "MoveFilesButton";
            this.MoveFilesButton.Size = new System.Drawing.Size(370, 23);
            this.MoveFilesButton.TabIndex = 3;
            this.MoveFilesButton.Text = "MoveFiles";
            this.MoveFilesButton.UseVisualStyleBackColor = true;
            this.MoveFilesButton.Click += new System.EventHandler(this.MoveFilesButton_Click);
            // 
            // RenameFilesButton
            // 
            this.RenameFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameFilesButton.Location = new System.Drawing.Point(661, 13);
            this.RenameFilesButton.Name = "RenameFilesButton";
            this.RenameFilesButton.Size = new System.Drawing.Size(279, 23);
            this.RenameFilesButton.TabIndex = 4;
            this.RenameFilesButton.Text = "Rename Files";
            this.RenameFilesButton.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResultBox.ForeColor = System.Drawing.Color.White;
            this.ResultBox.Location = new System.Drawing.Point(13, 482);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(927, 42);
            this.ResultBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 536);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.RenameFilesButton);
            this.Controls.Add(this.MoveFilesButton);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.OpenFolderButton);
            this.Name = "Form1";
            this.Text = "Folder Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView FolderList;
        private System.Windows.Forms.Button MoveFilesButton;
        private System.Windows.Forms.Button RenameFilesButton;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

