﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Models;

namespace FileExplorer.Services.Interfaces
{
    public interface IFileService
    {
        Task<IEnumerable<Models.File>> GetFiles(string directoryPath);
    }
}
