using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();
    if (result.Success == true)
    {
        foreach(var product in result.Data)
        {
            Console.WriteLine(product.ProductName+ " / " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName + "// " + product.CategoryName);
        }
}

//CategoryTest();

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var c in categoryManager.GetAll())
    {
        Console.WriteLine(c.CategoryName);
    }
}




