using static System.Console;
using Packt.Shared;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

WriteLine($"Using {ProjectConstants.DatabaseProvider} database provider.");

static void FilteredIncludes()
{
    using (Northwind db = new())
    {
        ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
        loggerFactory.AddProvider(new ConsoleLoggerProvider());
        string unitsInStock = "1";
        int stock = int.Parse(unitsInStock);
        IQueryable<Category>? categories = db.Categories?
          .Include(c => c.Products.Where(p => p.Stock >= stock))
          .TagWith("FilteredIncludes");
        if (categories is null)
        {
            WriteLine("No categories found.");
            return;
        }
        WriteLine($"ToQueryString: {categories.ToQueryString()}");
        foreach (Category c in categories)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count} products with a minimum of {stock} units in stock.");
            foreach (Product p in c.Products)
            {
                WriteLine($"  {p.ProductName} has {p.Stock} units in stock.");
            }
        }
    }
}

FilteredIncludes();