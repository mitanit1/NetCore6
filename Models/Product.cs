namespace NetCore6.Models;
using System.Linq;

public class Product{
<<<<<<< HEAD
    public int ID {set; get;}
    public string Name {get; set;}
    public string Description {get; set;}
    public Decimal Price {get; set;}
    public DateTime CreateDate {get; set;}
}
public static class ProductContext {
=======
    public int ID { set; get; }
    public String Name { set; get; }
    public String Description { set; get; }
    public Decimal Price { set; get; } = 0;
}


 public static class ProductContext {
>>>>>>> 2eb8222e800ac3c5acb0fe2438b3458f3bcbc8e7
    public static List<Product> products;
    static ProductContext() {
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

    // Tìm sản phẩm theo ID
    public static Product FindProductByID(int ID) {
      var p = from product in products
              where product.ID == ID
              select product;
      return p.FirstOrDefault();
    }

<<<<<<< HEAD
}

=======
  }
>>>>>>> 2eb8222e800ac3c5acb0fe2438b3458f3bcbc8e7
