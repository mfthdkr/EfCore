using EfCore.DatabaseFirst.Dal;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name}");
    });
}
