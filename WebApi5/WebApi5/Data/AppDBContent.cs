using System;
using Microsoft.EntityFrameworkCore;
using WebApi5.Data.Models;

namespace WebApi5.Data
{
    //Данный класс является классом подключения к базе данных
    public class AppDBContent : DbContext {

            public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
                
            }
            public DbSet<CategoryW> CategoryW { get; set; }
            public DbSet<File> File { get; set; }
    }
}