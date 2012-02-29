using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderFix
{
    public partial class Form1 : Form
    {

        private void OpenMoveFilesFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                moveFolderSet.Clear();
                selectedPath = folderBrowserDialog1.SelectedPath;

                if (Directory.Exists(selectedPath))
                {
                    //read folders in path
                    string[] folders = Directory.GetDirectories(selectedPath);
                    MoveFolderList.Items.Clear();
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
                                if (!moveFolderSet.Contains(textFolder))
                                {
                                    int filesToMove = Directory.GetFiles(textFolder).Count();
                                    moveFolderSet.Add(textFolder);

                                    ListViewItem item = new ListViewItem(index.ToString());
                                    item.Name = Path.GetFileName(textFolder);
                                    item.SubItems.Add(Path.GetFileName(textFolder));
                                    item.SubItems.Add(filesToMove > 0 ? "Yes (" + filesToMove + ")" : "No");
                                    itemList.Add(item);

                                    index++;
                                }
                            }
                        }
                    }
                    MoveFolderList.Items.AddRange(itemList.ToArray());
                }
            }
        }

        private void MoveFilesButton_Click(object sender, EventArgs e)
        {
            if (moveFolderSet.Count > 0)
            {
                foreach (string f in moveFolderSet)
                {
                    string textFolder = f;
                    string imgFolder = f + ext;

                    if (Directory.Exists(textFolder) && Directory.Exists(imgFolder))
                    {
                        string[] textFiles = Directory.GetFiles(textFolder);
                        foreach (string filePath in textFiles)
                        {
                            string fileName = Path.GetFileName(filePath);
                            try
                            {
                                File.Move(textFolder + "\\" + fileName, imgFolder + "\\" + fileName);
                            }
                            catch(Exception exp)
                            {
                            }
                        }

                        Directory.Delete(textFolder);

                        var updatedFolder = MoveFolderList.Items.Find(Path.GetFileName(textFolder), false);
                        if (updatedFolder != null)
                        {
                            if (updatedFolder.Length > 0)
                                updatedFolder[0].SubItems[2].Text = "Moved";
                        }
                    }
                }
            }
        }
    }
}
