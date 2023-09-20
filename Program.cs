using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataKodApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
             List<string> allItems = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            // Diğer öğeleri buraya ekleyin
        };
        
        int pageSize = 10;
        int pageNumber = 2;

        List<string> pagedItems = GetPagedItems(allItems, pageSize, pageNumber);

        foreach (var item in pagedItems)
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> GetPagedItems(List<string> allItems, int pageSize, int pageNumber)
    {
        int startIndex = (pageNumber - 1) * pageSize;
        int endIndex = Math.Min(startIndex + pageSize, allItems.Count);

        if (startIndex < 0 || startIndex >= allItems.Count)
        {
            return new List<string>(); // Sayfa dışı bir durum için boş bir liste döndürebilirsiniz.
        }

        return allItems.GetRange(startIndex, endIndex - startIndex);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

