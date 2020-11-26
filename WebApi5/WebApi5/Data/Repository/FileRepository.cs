using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using WebApi5.Data.Interfaces;
using WebApi5.Data.Models;

namespace WebApi5.Data.Repository
{
    public class FileRepository : IVersionFiles{

        private readonly AppDBContent appDBContent;

        public FileRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        
        public IEnumerable<File> GetAllVersionFiles => appDBContent.File.ToList();
        /*public IEnumerable<File> Files => appDBContent.File.Include(c => c.Materials);
        public File GetFile(int fileId) => appDBContent.File.FirstOrDefault(p => p.id == fileId);*/
        

        /*IEnumerable<File> IVersionFiles.GetAllVersionFiles => throw new System.NotImplementedException();

        public File GetFirstVersionFile => appDBContent.File.FirstOrDefault(c => c.fileId == 1);*/

        /*public File GetLatestVersionFile => throw new System.NotImplementedException();*/

        /*public File GetIdVersionFile(int fileId)
        {
            return (appDBContent.File.FirstOrDefault(c => c.fileId == fileId));
        }*/

        //IEnumerable<File> IVersionFiles.GetAllVersionFiles => throw new System.NotImplementedException();
    }
}
