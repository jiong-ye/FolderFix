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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MoveFolderList = new System.Windows.Forms.ListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.moveTab = new System.Windows.Forms.TabPage();
            this.MoveFilesButton = new System.Windows.Forms.Button();
            this.OpenMoveFilesFolderButton = new System.Windows.Forms.Button();
            this.renameTab = new System.Windows.Forms.TabPage();
            this.RenameFolderList = new System.Windows.Forms.ListView();
            this.OpenRenameFolderButton = new System.Windows.Forms.Button();
            this.RenameFilesButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.moveTab.SuspendLayout();
            this.renameTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveFolderList
            // 
            this.MoveFolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveFolderList.GridLines = true;
            this.MoveFolderList.Location = new System.Drawing.Point(6, 36);
            this.MoveFolderList.Name = "MoveFolderList";
            this.MoveFolderList.Size = new System.Drawing.Size(691, 443);
            this.MoveFolderList.TabIndex = 2;
            this.MoveFolderList.UseCompatibleStateImageBehavior = false;
            this.MoveFolderList.View = System.Windows.Forms.View.Details;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.moveTab);
            this.tabControl.Controls.Add(this.renameTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(711, 511);
            this.tabControl.TabIndex = 6;
            // 
            // moveTab
            // 
            this.moveTab.Controls.Add(this.MoveFilesButton);
            this.moveTab.Controls.Add(this.OpenMoveFilesFolderButton);
            this.moveTab.Controls.Add(this.MoveFolderList);
            this.moveTab.Location = new System.Drawing.Point(4, 22);
            this.moveTab.Name = "moveTab";
            this.moveTab.Padding = new System.Windows.Forms.Padding(3);
            this.moveTab.Size = new System.Drawing.Size(703, 485);
            this.moveTab.TabIndex = 0;
            this.moveTab.Text = "Move Files";
            this.moveTab.UseVisualStyleBackColor = true;
            // 
            // MoveFilesButton
            // 
            this.MoveFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveFilesButton.Location = new System.Drawing.Point(622, 7);
            this.MoveFilesButton.Name = "MoveFilesButton";
            this.MoveFilesButton.Size = new System.Drawing.Size(75, 23);
            this.MoveFilesButton.TabIndex = 4;
            this.MoveFilesButton.Text = "Move Files";
            this.MoveFilesButton.UseVisualStyleBackColor = true;
            this.MoveFilesButton.Click += new System.EventHandler(this.MoveFilesButton_Click);
            // 
            // OpenMoveFilesFolderButton
            // 
            this.OpenMoveFilesFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenMoveFilesFolderButton.Location = new System.Drawing.Point(541, 7);
            this.OpenMoveFilesFolderButton.Name = "OpenMoveFilesFolderButton";
            this.OpenMoveFilesFolderButton.Size = new System.Drawing.Size(75, 23);
            this.OpenMoveFilesFolderButton.TabIndex = 3;
            this.OpenMoveFilesFolderButton.Text = "Open Folder";
            this.OpenMoveFilesFolderButton.UseVisualStyleBackColor = true;
            this.OpenMoveFilesFolderButton.Click += new System.EventHandler(this.OpenMoveFilesFolderButton_Click);
            // 
            // renameTab
            // 
            this.renameTab.Controls.Add(this.RenameFolderList);
            this.renameTab.Controls.Add(this.OpenRenameFolderButton);
            this.renameTab.Controls.Add(this.RenameFilesButton);
            this.renameTab.Location = new System.Drawing.Point(4, 22);
            this.renameTab.Name = "renameTab";
            this.renameTab.Padding = new System.Windows.Forms.Padding(3);
            this.renameTab.Size = new System.Drawing.Size(703, 485);
            this.renameTab.TabIndex = 1;
            this.renameTab.Text = "Rename Files";
            this.renameTab.UseVisualStyleBackColor = true;
            // 
            // RenameFolderList
            // 
            this.RenameFolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameFolderList.Location = new System.Drawing.Point(6, 36);
            this.RenameFolderList.Name = "RenameFolderList";
            this.RenameFolderList.Size = new System.Drawing.Size(691, 443);
            this.RenameFolderList.TabIndex = 2;
            this.RenameFolderList.UseCompatibleStateImageBehavior = false;
            this.RenameFolderList.View = System.Windows.Forms.View.Details;
            // 
            // OpenRenameFolderButton
            // 
            this.OpenRenameFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenRenameFolderButton.Location = new System.Drawing.Point(525, 7);
            this.OpenRenameFolderButton.Name = "OpenRenameFolderButton";
            this.OpenRenameFolderButton.Size = new System.Drawing.Size(75, 23);
            this.OpenRenameFolderButton.TabIndex = 1;
            this.OpenRenameFolderButton.Text = "Open Folder";
            this.OpenRenameFolderButton.UseVisualStyleBackColor = true;
            this.OpenRenameFolderButton.Click += new System.EventHandler(this.OpenRenameFolderButton_Click);
            // 
            // RenameFilesButton
            // 
            this.RenameFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameFilesButton.Location = new System.Drawing.Point(606, 7);
            this.RenameFilesButton.Name = "RenameFilesButton";
            this.RenameFilesButton.Size = new System.Drawing.Size(91, 23);
            this.RenameFilesButton.TabIndex = 0;
            this.RenameFilesButton.Text = "Rename Files";
            this.RenameFilesButton.UseVisualStyleBackColor = true;
            this.RenameFilesButton.Click += new System.EventHandler(this.RenameFilesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 535);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Folder Fix";
            this.tabControl.ResumeLayout(false);
            this.moveTab.ResumeLayout(false);
            this.renameTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView MoveFolderList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage moveTab;
        private System.Windows.Forms.TabPage renameTab;
        private System.Windows.Forms.Button OpenMoveFilesFolderButton;
        private System.Windows.Forms.Button MoveFilesButton;
        private System.Windows.Forms.Button RenameFilesButton;
        private System.Windows.Forms.Button OpenRenameFolderButton;
        private System.Windows.Forms.ListView RenameFolderList;
    }
}

