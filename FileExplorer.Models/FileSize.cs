using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Models
{
    public class FileSize
    {
        public long Size { get; set; }

        public FileSize() => Size = 0;
        public FileSize(long size) => Size = size;

        public string InBytes()
        {
            return $"{Size / 1024} bytes";
        }

        public string InMegaBytes() 
        {
            return $"{(Size / 1024) / 1024} MB";
        }

        public string InGigaBytes()
        {
            return $"{((Size / 1024) / 1024) / 1024} GB";
        }
    }
}
