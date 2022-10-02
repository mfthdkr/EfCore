// See https://aka.ms/new-console-template for more information

using EfCore.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var context = new EfCoreDatabaseFirstDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine((object?)$"{p.Id} : {p.Name}: {p.Price}: {p.Stock}");
    });
}