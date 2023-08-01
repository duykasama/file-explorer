using FileExplorer.Models;
using FileExplorer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Services
{
    public class FileService : IFileService
    {
        public Task<IEnumerable<Models.File>> GetFiles(string directoryPath)
        {
            var files = new List<Models.File>();
            DirectoryInfo dF = new DirectoryInfo(directoryPath);

            try
            {
                foreach (var f in dF.EnumerateFiles())
                {
                    files.Add(new Models.File
                    {
                        Name = f.Name,
                        Path = f.FullName,
                        CreationDate = f.CreationTime,
                        Size = new FileSize(f.Length),
                        Extension = f.Extension,
                    });
                }
            }
            catch 
            {
                
            }

            return Task.FromResult(files.AsEnumerable());
        }
    }
}
