using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FolderFix
{
    public partial class Form1 : Form
    {
        private List<string> folderSets = new List<string>();
        private string selectedPath = string.Empty;
        private string ext = "_files";

        public Form1()
        {
            InitializeComponent();

            FolderList.Columns.Add("#", 25);
            FolderList.Columns.Add("Path", FolderList.Width - 200);
            FolderList.Columns.Add("Move Files", 70);
            FolderList.Columns.Add("Rename Files", 70);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                folderSets.Clear();
                selectedPath = folderBrowserDialog1.SelectedPath;

                if (Directory.Exists(selectedPath))
                {
                    //read folders in path
                    string[] folders = Directory.GetDirectories(selectedPath);
                    FolderList.Items.Clear();
                    List<ListViewItem> itemList = new List<ListViewItem>();
                    int index = 1;

                    foreach (string f in folders)
                    {
                        if (!f.EndsWith(ext))
                        {
                            string textFolder = f;
                            string imgFolder = f + ext;

                            if (Directory.Exists(f) && Directory.Exists(imgFolder))
                            {
                                if (!folderSets.Contains(textFolder))
                                {
                                    int filesToMove = Directory.GetFiles(textFolder).Count();
                                    folderSets.Add(textFolder);

                                    ListViewItem item = new ListViewItem(index.ToString());
                                    item.Name = Path.GetFileName(textFolder);
                                    item.SubItems.Add(Path.GetFileName(textFolder));
                                    item.SubItems.Add(filesToMove > 0 ? "Yes (" + filesToMove + ")" : "No");
                                    item.SubItems.Add("Yes");
                                    itemList.Add(item);

                                    index++;
                                }
                            }
                        }
                    }
                    FolderList.Items.AddRange(itemList.ToArray());
                }
            }
        }

        private void moveFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderSets.Count > 0)
            {
                foreach (string f in folderSets)
                {
                    string textFolder = f;
                    string imgFolder = f + ext;

                    if (Directory.Exists(textFolder) && Directory.Exists(imgFolder))
                    {
                        string[] textFiles = Directory.GetFiles(textFolder);
                        foreach (string filePath in textFiles)
                        {
                            string fileName = Path.GetFileName(filePath);
                            File.Move(textFolder + "\\" + fileName, imgFolder + "\\" + fileName);
                        }

                        Directory.Delete(textFolder);

                        var updatedFolder = FolderList.Items.Find(Path.GetFileName(textFolder), false);
                        if (updatedFolder != null)
                        {
                            updatedFolder[0].SubItems[2].Text = "Moved";
                        }
                    }
                }
            }
        }

        private void renameFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderSets.Count > 0)
            {
                foreach (string f in folderSets)
                {
                    string textFolder = f;
                    string imgFolder = f + ext;

                    if (Directory.Exists(imgFolder))
                    {
                        Regex number = new Regex(@"\(\d+\)", RegexOptions.IgnoreCase);
                        string[] imgFiles = Directory.GetFiles(imgFolder);
                        string folderName = number.Replace(Path.GetFileName(imgFolder).Replace(ext, ""), "").Trim();
                        int index = 1;

                        foreach (string filePath in imgFiles)
                        {
                            File.Copy(filePath, imgFolder + "\\" + folderName + "-" + (index++).ToString() + Path.GetExtension(filePath));
                            File.Delete(filePath);
                        }

                        var updatedFolder = FolderList.Items.Find(Path.GetFileName(textFolder), false);
                        if (updatedFolder != null)
                        {
                            updatedFolder[0].SubItems[3].Text = "Renamed";
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
