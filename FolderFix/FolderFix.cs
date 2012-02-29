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
        private List<string> moveFolderSet = new List<string>();
        private List<string> renameFolderSet = new List<string>();
        private string selectedPath = string.Empty;
        private string ext = "_files";

        public Form1()
        {
            InitializeComponent();

            MoveFolderList.Columns.Add("#", 25);
            MoveFolderList.Columns.Add("Path", MoveFolderList.Width - 200);
            MoveFolderList.Columns.Add("Move Files", 90);

            RenameFolderList.Columns.Add("#", 25);
            RenameFolderList.Columns.Add("Path", MoveFolderList.Width - 200);
            RenameFolderList.Columns.Add("Rename Files", 90);
        }
    }
}