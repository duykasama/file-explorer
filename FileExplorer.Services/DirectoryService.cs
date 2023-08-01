using FileExplorer.Models;
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
        private readonly FileService _fileService;
        public DirectoryService()
        {
            _fileService = new FileService();
        }
        public Task<IEnumerable<Models.Directory>> GetDirectories(string directoryPath)
        {
            var directories = new List<Models.Directory>();
            DirectoryInfo rootDirectory = new DirectoryInfo(directoryPath);

            foreach (var directory in rootDirectory.EnumerateDirectories())
            {
                directories.Add(new Models.Directory
                {
                    Name = directory.Name,
                    Path = directory.FullName,
                    CreationDate = directory.CreationTime,
                });
            }

            return Task.FromResult(directories.AsEnumerable());
        }
    }
}
