namespace NetCore6;
using Microsoft.AspNetCore.Mvc;
using NetCore6.Models;
public class ProductBox : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var products = new List<Product>(){
            new Product() {
                Name = "Iphone X",
                Description = "Dien thoai Iphone X",
                Price = 123.456M
            },
            new Product() {
                Name = "Iphone 11",
                Description = "Dien thoai Iphone 11",
                Price = 234.456M
            },
            new Product() {
                Name = "Iphone 12",
                Description = "Dien thoai Iphone 12",
                Price = 345.456M
            },
        };

        return View<List<Product>>(products);
    }
    //InvokeAsync
}