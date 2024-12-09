using AccEshop.Models;
using AccEshop.Services;
using System.Xml.Linq;

var product = new Product()

{
   Name = "chips",
   Price = 1.20m,
   Description = "Fresh snack",
   ProductionTimeStamp = DateTime.Now
} ;

Console.WriteLine(product);
Console.WriteLine($"""
    the product id is {product.Id} 
    the product Name is {product.Name}
    the product Price is  { product.Price} 
""");


Customer customer = new()
{


    Id = 1,
    Address = "Sliman3",
    City = "Athens",
    Country = "Greece",
    Name="Christina"

};

OrderService orderService = new();
Order order = orderService.CreateOrder(customer, product);
string message = orderService.GetOrderDetails();
Console.WriteLine(message);
