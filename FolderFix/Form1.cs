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
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;

                if(Directory.Exists(selectedPath))
                {
                    Log(selectedPath + " - Selected");

                    //read folders in path
                    string[] folders = Directory.GetDirectories(selectedPath);
                    List<string> folderSets = new List<string>();
                    string ext = "_files";

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

                                    string[] textFiles = Directory.GetFiles(textFolder);
                                    foreach (string filePath in textFiles)
                                    {
                                        string fileName = Path.GetFileName(filePath);
                                        File.Move(textFolder + "\\" + fileName, imgFolder + "\\" + fileName);
                                        Log("-- moved " + fileName);
                                    }

                                    Directory.Delete(textFolder);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Log(selectedPath + " doesn't exist.");
                }
            }
        }

        private void Log(string m)
        {
            if (m.Length > 0)
                ResultBox.Text += m + Environment.NewLine;
        }
    }
}
