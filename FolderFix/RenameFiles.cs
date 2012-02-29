using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Drawing;

namespace FolderFix
{
    public partial class Form1 : Form
    {
        private void OpenRenameFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                renameFolderSet.Clear();
                selectedPath = folderBrowserDialog1.SelectedPath;

                if (Directory.Exists(selectedPath))
                {
                    //read folders in path
                    string[] folders = Directory.GetDirectories(selectedPath);
                    RenameFolderList.Items.Clear();
                    List<ListViewItem> itemList = new List<ListViewItem>();
                    int index = 1;

                    foreach (string f in folders)
                    {
                        if (Directory.Exists(f))
                        {
                            if (!renameFolderSet.Contains(f))
                            {
                                int filesToRename = Directory.GetFiles(f).Count();
                                renameFolderSet.Add(f);

                                ListViewItem item = new ListViewItem(index.ToString());
                                item.Name = Path.GetFileName(f);
                                item.SubItems.Add(Path.GetFileName(f));
                                item.SubItems.Add(filesToRename > 0 ? "Yes (" + filesToRename + ")" : "No");
                                itemList.Add(item);

                                //LinkLabel link = new LinkLabel();
                                //link.Text = "Open";
                                //link.Click += new EventHandler(link_Click);
                                //RenameFolderList.AddEmbeddedControl(link, 3, index - 1);
                                index++;
                            }
                        }
                    }
                    RenameFolderList.Items.AddRange(itemList.ToArray());
                }
            }
        }

        void link_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RenameFilesButton_Click(object sender, EventArgs e)
        {
            if (renameFolderSet.Count > 0)
            {
                foreach (string f in renameFolderSet)
                {
                    string[] p = { f };
                    BackgroundWorker w = new BackgroundWorker();
                    w.DoWork += DoRenameWork;
                    w.RunWorkerAsync(p);
                }
            }
        }

        private void DoRenameWork(object sender, DoWorkEventArgs e)
        {
            string[] s = (string[])e.Argument;

            if (s.Length == 1)
            {
                RenameFolderFiles(s[0]);
            }
        }

        private void RenameFolderFiles(string folder)
        {
            if (Directory.Exists(folder))
            {
                Regex number = new Regex(@"\(\d+\)", RegexOptions.IgnoreCase);
                string[] imgFiles = Directory.GetFiles(folder);
                string folderName = number.Replace(Path.GetFileName(folder).Replace(ext, ""), "").Trim();
                int index = 1;

                if (imgFiles.Length > 0)
                {
                    int failed = 0;
                    int success = 0;

                    foreach (string filePath in imgFiles)
                    {
                        try
                        {
                            File.Copy(filePath, folder + "\\" + folderName + "-" + (index++).ToString() + Path.GetExtension(filePath));
                            File.Delete(filePath);
                            success++;
                        }
                        catch (Exception exp)
                        {
                            failed++;
                        }
                    }

                    UpdateRenameFolderStatus(folder, success + " renamed. " + failed + " failed.");
                    if (failed > 0)
                        FlagFolderStatus(folder);

                }
                else
                {
                    UpdateRenameFolderStatus(folder, "Folder Empty.");
                }

            }
        }

        private void FlagFolderStatus(string folder)
        {
            if (!RenameFolderList.InvokeRequired)
            {
                var updatedFolder = RenameFolderList.Items.Find(Path.GetFileName(folder), false);
                if (updatedFolder != null)
                {
                    if (updatedFolder.Length > 0)
                    {
                        updatedFolder[0].ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                FlagFolderStatusDelegate del = new FlagFolderStatusDelegate(FlagFolderStatus);
                RenameFolderList.Invoke(del, new object[] { folder });
            }
        }
        delegate void FlagFolderStatusDelegate(string folder);

        private void UpdateRenameFolderStatus(string folder, string status)
        {
            if (!RenameFolderList.InvokeRequired)
            {
                var updatedFolder = RenameFolderList.Items.Find(Path.GetFileName(folder), false);
                if (updatedFolder != null)
                {
                    if (updatedFolder.Length > 0)
                        updatedFolder[0].SubItems[2].Text = status;
                }
            }
            else
            {
                UpdateRenameFolderStatusDelegate del = new UpdateRenameFolderStatusDelegate(UpdateRenameFolderStatus);
                RenameFolderList.Invoke(del, new object[] { folder, status });
            }
        }
        delegate void UpdateRenameFolderStatusDelegate(string folder, string status);
    }
}
