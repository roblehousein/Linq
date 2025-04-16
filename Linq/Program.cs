using Linq;

using var context = new AppDbContext();

// Créer un produit
var product = new Product { Name = "bonbon", Price = 12M };
var product1 = new Product { Name = "chaussure", Price = 300M };
var product2 = new Product { Name = "riz", Price = 8M };
var product3 = new Product { Name = "sucre", Price = 8M };
var product4 = new Product { Name = "café", Price = 11M };

context.Products.Add(product);
context.Products.Add(product1);
context.Products.Add(product2);
context.Products.Add(product3);
context.Products.Add(product4);
context.SaveChanges();

Console.WriteLine("------avant modification--------");
var products = context.Products.ToList();
foreach (var p in products)
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
}

Console.WriteLine("------après modification des prix --------");
// afficher tous les produits ont un prix superieur a 10
var ps = context.Products.Where(e => e.Price > 10).ToList();
// changer les prix de ces derniers par 5
foreach (var p in ps)
{
    p.Price = 5;
    context.Products.Update(p);
}
context.SaveChanges();
var productsUpdated = context.Products.ToList();
foreach (var p in productsUpdated)
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
}
Console.WriteLine("------après suppression des produits --------");

// supprimer ces produits 
foreach (var p in ps)
{
    context.Products.Remove(p);
}
context.SaveChanges();

// afficher la liste des produits
var newProducts = context.Products.ToList();
foreach (var p in newProducts)
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
}
//afficher la liste des produit
