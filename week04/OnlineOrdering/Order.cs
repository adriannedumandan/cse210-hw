using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 6; 
        }
        else
        {
            total += 44; 
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in products)
        {
            sb.AppendLine($"Name: {product.Name}, Product ID: {product.ProductId}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address}";
    }
}
