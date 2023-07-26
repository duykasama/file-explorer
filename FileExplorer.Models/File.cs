using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Models
{
    public class File
    {
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public FileSize Size { get; set; } = new FileSize();
        public string Extension { get; set; } = null!;
    }
}
