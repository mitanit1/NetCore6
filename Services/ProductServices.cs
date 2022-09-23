using NetCore6.Models;

public class ProductService
{
    public static List<Product> products;
    static ProductService() {
      // Khởi tạo một danh sách các sản phẩm mẫu
      products = new List<Product>() {
        new Product {
          ID=1,
          Name = "Iphone",
          Price = 900,
          Description = "Điện thoại Iphone abc, xyz ..."
        },
        new Product {
          ID = 2,
          Name = "Samsung",
          Price = 800,
          Description = "Điện thoại Samsung, samsung điện thoại ..."
        },
        new Product {
          ID = 3,
          Name = "Nokia",
          Price = 700,
          Description = "Điện thoại Nokia, điện thoại Android"
        }
      };
    }

    public List<Product> GetAll() {
      return products;
    }
    // Tìm sản phẩm theo ID
    public Product? FindProductByID(int ID) {
      var p = from product in products
              where product.ID == ID
              select product;
      return p.FirstOrDefault();
    }

}

