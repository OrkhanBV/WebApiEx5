using System.Net;
using System.Web;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi5;

namespace WebApi5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Download : ControllerBase
    {
        private readonly IWebHostEnvironment _appEnvironment;
        public Download(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        
        [HttpGet]
        public PhysicalFileResult GetFile()
        {
            // Тип файла - content-type
            string file_type = "application/pdf";
            // Имя файла - необязательно
            string file_name = "file.jpeg";
            // Путь к файлу
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "AppStorage/" + file_name);
            
            return PhysicalFile(file_path, file_type, file_name);
        }
        
        
        
        //{
            /*var result = 
                new HttpResponseMessage(HttpStatusCode.OK);
            //1)Get file bytes
            var fileName = "file.jpg";
            //var filePath = HttpContext.Current.Server.MapPath($"~/AppStorage/{fileName}"); не сработал почему-то?
            var filePath = $"~/home/orhan/Desktop/Task5/WebApiEx5/WebApi5/WebApi5/AppStorage";

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            
            //2)Add bytes to a memory Stream
            var fileMemStream = 
                new MemoryStream(fileBytes);
            
            //3)Add memory stream to response
            result.Content = new StreamContent(fileMemStream);
            
            //4)Build response headers
            var headers = result.Content.Headers;
            
            headers.ContentDisposition = 
                new ContentDispositionHeaderValue("attachment");
            headers.ContentDisposition.FileName = fileName;
            
            //headers.ContentType = new MediaTypeHeaderValue("application/jpg");
            headers.ContentType = new MediaTypeHeaderValue("application/octet-stream"); ///должно позволить получить любой файл
            headers.ContentLength = fileMemStream.Length;
            return result;*/
        //}
    }
}
