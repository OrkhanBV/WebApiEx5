using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi5.Data;
/*using WebApi5.Data.Interfaces;*/
using WebApi5.Data.Models;

namespace WebApi5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetFilesController : ControllerBase
    {
        private readonly AppDBContent appDBContent;

        public GetFilesController(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        
        //public IEnumerable<File> GetAllVersionFiles => appDBContent.File.ToList();
        public IEnumerable<File> GetAllVersionFiles =>
            appDBContent.File.Where(c => c.CategoryW.categoryType == "Другое").ToList();
        [HttpGet]
        public IEnumerable<File> Get()
        {
            return GetAllVersionFiles;
        }
    }
}