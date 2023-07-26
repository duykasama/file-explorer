using FileExplorer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Services
{
    public class DirectoryService : IDirectoryService
    {
        public Task<IEnumerable<Models.Directory>> GetDirectories()
        {
            throw new NotImplementedException();
        }
    }
}
