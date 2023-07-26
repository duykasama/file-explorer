using FileExplorer.Models;
using FileExplorer.Services;
using FileExplorer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace FileExplorer.Interfaces
{
    public partial class frmMain : Form
    {
        private readonly IFileService _fileService;
        private IEnumerable<Models.Directory> directories;
        private IEnumerable<Models.File> files;

        public frmMain()
        {
            InitializeComponent();
            _fileService = new FileService();
            directories = new List<Models.Directory>();
            files = _fileService.GetFiles("D:\\").Result;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                item.SubItems.Add(file.Path);
                item.SubItems.Add(file.CreateDate.ToString("dd/MMM/yyyy"));
                item.SubItems.Add(file.Size.GetSize());
                item.SubItems.Add(file.Extension);
                lvFiles.Items.Add(item);
            }
            
        }
    }
}
