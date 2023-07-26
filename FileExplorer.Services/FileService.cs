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
            var path = Path.GetFullPath(directoryPath);
            DirectoryInfo dF = new DirectoryInfo(directoryPath);
            
            if (dF.EnumerateFiles().Count() == 0)
            {
                return Enumerable.Empty<Models.File>();
            }

            foreach (var f in dF.EnumerateFiles())
            {
                files.Add(new Models.File
                {
                    Name = f.Name,
                    Path = f.FullName,
                    CreateDate = f.CreationTime,
                    Size = new FileSize(f.Length),
                    Extension = f.Extension,
                });
            }

            return files;
        }
    }
}
