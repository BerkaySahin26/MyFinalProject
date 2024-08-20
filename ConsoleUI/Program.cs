using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//Open Closed Principle
ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetByUnitPrice(15,25))
{
    Console.WriteLine(product.ProductName);
}


Console.WriteLine("Finish");
