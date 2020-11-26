using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using WebApi5.Data;
using WebApi5.Data.Models;

namespace WebApi5.Data
{
    public class DBObjects
    {
        //public static void Initial(IApplicationBuilder app)
       
        public static void Initial(AppDBContent content)
        {
            
            if (!content.CategoryW.Any())
                content.CategoryW.AddRange(Categories.Select(c => c.Value));
            if (!content.File.Any())
            {
                content.AddRange(
                    new File()
                    {
                        Id = 1,
                        
                        materialId = 1,
                        
                        data = DateTime.Now.AddDays(1),
                        
                        fileName = "test1_0.txt",
                        
                        materialName = "test1_0.txt",

                        size = 1,

                        idVersion = 1,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Приложение"],
                    },
                    new File()
                    {
                        Id = 2,
                        
                        materialId = 1,
                        
                        data = DateTime.Now.AddDays(2),
                        
                        fileName = "test1_1.txt",
                        
                        materialName = "test1_1.txt",

                        size = 1,

                        idVersion = 2,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Приложение"],
                    },
                    new File()
                    {
                        Id = 3,
                        
                        materialId = 1,
                        
                        data = DateTime.Now.AddDays(3),
                        
                        fileName = "test1_2.txt",
                        
                        materialName = "test1_2.txt",

                        size = 1,

                        idVersion = 3,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Приложение"],
                    },
                    new File()
                    {
                        Id = 4,
                        
                        materialId = 1,
                        
                        data = DateTime.Now.AddDays(4),
                        
                        fileName = "test1_3.txt",
                        
                        materialName = "test1_3.txt",

                        size = 1,

                        idVersion = 4,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Приложение"],
                    },
                    new File()
                    {
                        Id = 5,
                        
                        materialId = 2,
                        
                        data = DateTime.Now.AddDays(5),
                        
                        fileName = "test2_1.txt",
                        
                        materialName = "test2_1.txt",

                        size = 1,

                        idVersion = 1,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Другое"],
                    },
                    new File()
                    {
                        Id = 6,
                        
                        materialId = 2,
                        
                        data = DateTime.Now.AddDays(6),
                        
                        fileName = "test2_2.txt",
                        
                        materialName = "test2_2.txt",

                        size = 1,

                        idVersion = 2,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Другое"],
                    },
                    new File()
                    {
                        Id = 7,
                        
                        materialId = 2,
                        
                        data = DateTime.Now.AddDays(7),

                        fileName = "test2_3.txt",
                        
                        materialName = "test2_3.txt",

                        size = 1,

                        idVersion = 3,

                        pathOfFile = "willbepath",

                        CategoryW = Categories["Другое"],
                    }
                    
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, CategoryW> categoryW;
            public static Dictionary<string, CategoryW> Categories
            {
                get 
                {
                    if (categoryW == null)
                    {
                        var list = new CategoryW[]
                        {
                            new CategoryW
                            {
                                Id = 1, 
                                categoryType = "Приложение"
                            },
                            new CategoryW
                            {
                                Id = 2, 
                                categoryType = "Презентация"
                            },
                            new CategoryW
                            {
                                Id = 3, 
                                categoryType = "Другое"
                            },
                        };
                        categoryW = new Dictionary<string, CategoryW>();
                        foreach (CategoryW element in list)
                        {
                            categoryW.Add(element.categoryType, element);
                        }
                    }
                    return categoryW;
                }
            }
    }
}
