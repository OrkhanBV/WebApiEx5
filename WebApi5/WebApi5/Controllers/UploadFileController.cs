/*using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApi5.Controllers
{
    public class UploadFileController : Controller
    {
        private IHostingEnvironment _env;
        private string _dir;
        
        
        public UploadFileController(IHostingEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
        }
        public IActionResult Index() => View();
        
        public IActionResult SingleFile(IFormFile file)
        {
            var dir = _env.ContentRootPath;
            using (var fileStream = new FileStream(Path.Combine(dir, "file.png"), FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }
            return RedirectToAction("Index");
        }

        public IActionResult MultipleFiles(IEnumerable<IFormFile> files)
        {
            int i = 0;
            foreach (var file in files)
            {
                using (var fileStream = new FileStream(Path.Combine(_dir, $"file{i++}.png"), FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fileStream);
                }
            }
            return RedirectToAction("Index");
        }
    }

}








/*
Вариант номер 1, проблема с HttpContext.Curren & Server не хочет видеть
Данную реализацию повзаимствовал по ссылке https://www.youtube.com/watch?v=MzDQALXH-SI&list=LL&index=3
 
[HttpPost]
[Route("Upload")]
public async Task<string> UploadFile()
{
    var ctx = HttpContext.Current;
    var root = ctx.Server.MapPath("~/AppStorage");
    var provider = new MultipartFormDataStreamProvider(root);
    try
    {
        await Request.Content.ReadAsMultipartAsync(provider);

        foreach (var file in provider.FileData)
        {
            var name = file.Headers
                .ContentDisposition
                .FileName;
            //remove double quotes from string.
            name = name.Trim('"');

            var localFileName = file.LocalFileName;
            var filePath = Path.Combine(root, name);
            File.Move(localFileName, filePath);
        }
    }
    catch (Exception e)
    {
        return $"Error: {e.Message}";
    }
    return "File Uploaded";
}
}
}
*/