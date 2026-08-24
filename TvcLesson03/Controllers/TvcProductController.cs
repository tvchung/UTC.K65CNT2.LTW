using Microsoft.AspNetCore.Mvc;
using TvcLesson03.Models;

namespace TvcLesson03.Controllers
{
    public class TvcProductController : Controller
    {
        public IActionResult Index()
        {
            // Tạo một sản phẩm
            var product = new TvcProduct()
            {
                productId = "P001",
                productName = "Lenovo",
                quantity = 100,
                price = 1200
            };

            ViewBag.productVB = product;
            ViewData["productVD"] = product;


            return View();
        }

        public IActionResult GetAllProducts()
        {
            // tạo mock data
            List<TvcProduct> products = new List<TvcProduct>
            {
                new TvcProduct { productId = "TVC001", productName = "Áo thun nam cổ tròn", quantity = 150, price = 129000m },
                new TvcProduct { productId = "TVC002", productName = "Quần jean nữ ống suông", quantity = 80, price = 349000m },
                new TvcProduct { productId = "TVC003", productName = "Giày sneaker trắng", quantity = 45, price = 599000m },
                new TvcProduct { productId = "TVC004", productName = "Balo laptop chống nước", quantity = 60, price = 459000m },
                new TvcProduct { productId = "TVC005", productName = "Tai nghe bluetooth không dây", quantity = 200, price = 289000m },
                new TvcProduct { productId = "TVC006", productName = "Đồng hồ đeo tay thể thao", quantity = 35, price = 750000m },
                new TvcProduct { productId = "TVC007", productName = "Ví da nam cao cấp", quantity = 90, price = 199000m },
                new TvcProduct { productId = "TVC008", productName = "Mũ lưỡi trai thời trang", quantity = 120, price = 99000m },
                new TvcProduct { productId = "TVC009", productName = "Bình giữ nhiệt 500ml", quantity = 75, price = 159000m },
                new TvcProduct { productId = "TVC010", productName = "Kính mát nam UV400", quantity = 55, price = 249000m }
            };

            // lưu vào đối tượng viewdata để chuyển lên view
            ViewData["products"] = products;

            return View("Products");
        }
    }
}
