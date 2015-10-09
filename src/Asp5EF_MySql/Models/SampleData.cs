using Microsoft.Framework.DependencyInjection;
using System;

namespace Asp5EF.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<BookContext>();

            if (!context.Database.Exists())
            {
                var austen = context.Authors.Add(
                       new Author { LastName = "Austen", FirstName = "Jane" });
                var dickens = context.Authors.Add(
                    new Author { LastName = "Dickens", FirstName = "Charles" });
                var cervantes = context.Authors.Add(
                    new Author { LastName = "Cervantes", FirstName = "Miguel" });


                context.SaveChanges();
            }
           
        }
    }
}