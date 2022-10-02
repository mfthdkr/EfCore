using EfCore.CodeFirst;
using EfCore.CodeFirst.Dal;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var context = new AppDbContext())
{
    context.Products.Add(new Product() {Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123});
    context.Products.Add(new Product() {Name = "Kalem 2", Price = 200, Stock = 100, Barcode = 123});
    context.Products.Add(new Product() {Name = "Kalem 3", Price = 200, Stock = 100, Barcode = 123});

    context.SaveChanges();

    // var products = await context.Products.AsNoTracking().ToListAsync();

    //products.ForEach(p =>
    //{
    //    Console.WriteLine((object?)$"{p.Id} : {p.Name}: {p.Price}: {p.Stock}");
    //});
}
