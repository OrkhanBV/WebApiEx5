using Microsoft.AspNetCore.Http;

namespace WebApi5.Controllers.Models
{
    public class SomeForm
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}