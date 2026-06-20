using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new()
        {
            new Order{OrderId=1,CustomerName="Hari",TotalAmount=5000},
            new Order{OrderId=2,CustomerName="Kalyan",TotalAmount=15000},
            new Order{OrderId=3,CustomerName="Rebel",TotalAmount=25000}
        };

        var result = orders
            .Where(o => o.TotalAmount > 10000)
            .Select(o => new
            {
                o.OrderId,
                o.CustomerName
            });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.OrderId} {item.CustomerName}");
        }
    }
}