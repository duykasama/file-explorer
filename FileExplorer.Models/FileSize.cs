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
            return String.Format("{0,-10} bytes", Size);
        }

        public string InKiloBytes()
        {
            return String.Format("{0,-10} kB", Size / 1024);
        }

        public string InMegaBytes() 
        {
            return String.Format("{0,-10} MB", (Size / 1024) / 1024);
        }

        public string InGigaBytes()
        {
            return String.Format("{0,-10} GB", ((Size / 1024) / 1024) / 1024);
        }

        public string GetSize()
        {
            if (Size > 1024 * 1024 * 1024)
            {
                return InGigaBytes();
            }
            else if (Size > 1024 * 1024)
            {
                return InMegaBytes();
            }
            else if (Size > 1024)
            {
                return InKiloBytes();
            }
            else
            {
                return InBytes();
            }
        }
    }
}
