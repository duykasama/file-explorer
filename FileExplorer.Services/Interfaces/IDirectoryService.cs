using FileExplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Services.Interfaces
{
    public interface IDirectoryService
    {
        Task<IEnumerable<Models.Directory>> GetDirectories(string directoryPath); 
    }
}
