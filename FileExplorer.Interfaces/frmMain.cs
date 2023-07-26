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

namespace FileExplorer.Interfaces
{
    public partial class frmMain : Form
    {
        private readonly IFileService _fileService;
        IEnumerable<Models.Directory> directories;
        IEnumerable<Models.File> files;

        public frmMain()
        {
            InitializeComponent();
            _fileService = new FileService();
            files = _fileService.GetFiles("D:\\");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                //item.SubItems.Add(file.Name);
                item.SubItems.Add(file.Path);
                item.SubItems.Add(file.CreateDate.ToString("dd/MMM/yyyy"));
                item.SubItems.Add(file.Size.InMegaBytes());
                item.SubItems.Add(file.Extension);
                item.BackColor = Color.Red;
                lvFiles.Items.Add(item);
            }
            
        }
    }
}
