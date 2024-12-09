using AccEshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Services;

public class OrderService
{
    private long _id;
    private Order? _order;
    public Order CreateOrder(Customer customer, Product product)
    {
        _id++;
        _order = new Order()
        {
            Customer = customer,
            Product = product,
            Date = DateTime.Now,
            Id = _id
        };
        return _order;
    }

    public Order? GetOrder()
    {
        return _order;
    }

    public string GetOrderDetails()
    {
        return $"""
       the orde id is {_order?.Id}
       the name of the customer is {_order?.Customer?.Name}
       the name of the product is  {_order?.Product?.Name}
       the price of the product is {_order?.Product?.Price}
       """;

    }
}