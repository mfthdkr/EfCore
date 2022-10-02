using EfCore.CodeFirst;
using EfCore.CodeFirst.Dal;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var context = new AppDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine((object?)$"{p.Id} : {p.Name}: {p.Price}: {p.Stock}");
    });
}
