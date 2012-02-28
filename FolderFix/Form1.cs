using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderFix
{
    public partial class Form1 : Form
    {
        private List<string> folderSets = new List<string>();
        private string selectedPath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            FolderList.Columns.Add("Path", FolderList.Width - 70);
            FolderList.Columns.Add("Moved", 70);
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                folderSets.Clear();
                selectedPath = folderBrowserDialog1.SelectedPath;

                if(Directory.Exists(selectedPath))
                {
                    Log(selectedPath + " - Selected");

                    //read folders in path
                    string[] folders = Directory.GetDirectories(selectedPath);
                    string ext = "_files";
                    FolderList.Items.Clear();
                    List<ListViewItem> itemList = new List<ListViewItem>();

                    foreach (string f in folders)
                    {
                        if (!f.EndsWith(ext))
                        {
                            string textFolder = f;
                            string imgFolder = f + ext;

                            if(Directory.Exists(f) && Directory.Exists(imgFolder))
                            {
                                if (!folderSets.Contains(textFolder))
                                {
                                    folderSets.Add(textFolder);
                                    Log(textFolder + " found. " + folderSets.Count + " found so far.");

                                    ListViewItem item = new ListViewItem(textFolder);
                                    item.SubItems.Add("No");
                                    itemList.Add(item);

                                    //string[] textFiles = Directory.GetFiles(textFolder);
                                    //foreach (string filePath in textFiles)
                                    //{
                                    //    string fileName = Path.GetFileName(filePath);
                                    //    File.Move(textFolder + "\\" + fileName, imgFolder + "\\" + fileName);
                                    //    Log("-- moved " + fileName);
                                    //}

                                    //Directory.Delete(textFolder);
                                }
                            }
                        }
                    }
                    FolderList.Items.AddRange(itemList.ToArray());
                }
                else
                {
                    Log(selectedPath + " doesn't exist.");
                }
            }
        }
                
        private void MoveFilesButton_Click(object sender, EventArgs e)
        {

        }

        private void Log(string m)
        {
            if (m.Length > 0)
            {
                ResultBox.Text += m + Environment.NewLine;
                ResultBox.SelectionStart = ResultBox.Text.Length;
                ResultBox.ScrollToCaret();
            }
        }
    }
}
