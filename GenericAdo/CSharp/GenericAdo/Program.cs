using CSharp.GenericAdo.Models;
using CSharp.GenericAdoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericAdo;

public class Program
{
    static async Task Main(string[] args)
    {
        Service<Category> categoryService = new();
        Service<Shipper> shipperService = new();

        categoryService.Add(new Category { CategoryName = "New Category" });
        shipperService.Add(new Shipper { CompanyName = "New Shipper" });

        bool result = await categoryService.Add(new Category { CategoryName = "New Category", Description = "Deneme" });
        Console.WriteLine(result);
    }
}
