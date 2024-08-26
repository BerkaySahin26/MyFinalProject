using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//Open Closed Principle

//CategoryTest();

ProductTest();

Console.WriteLine("Finish");




static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + "/"+ product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}