using EfCore.DatabaseFirst.Dal;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

// 1.yöntem. AppDbContext'ten her nesne örneği alındığında kendimiz initalize ediyoruz.
//using (var context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))

// 2.yöntem. AppDbContext'te override OnConfiguring metodu ile sqli belirtiyoruz.
using (var context = new AppDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine((object?) $"{p.Id} : {p.Name}: {p.Price}: {p.Stock}");
    });
}
