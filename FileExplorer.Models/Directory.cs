using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Models
{
    public class Directory
    {
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public List<File> Files { get; set;} = new List<File>();
        public FileSize Size
        {
            get
            {
                long totalSize = 0;
                foreach (var file in Files)
                {
                    totalSize += file.Size.Size;
                }

                return new FileSize(totalSize);
            }
        }
    }
}
