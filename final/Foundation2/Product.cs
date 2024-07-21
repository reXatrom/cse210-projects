using System;
using System.Collections.Generic;

public class Product
{
    private string Name;
    private string Id;
    private double Price;
    private int Quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.Name = name;
        this.Id = id;
        this.Price = price;
        this.Quantity = quantity;
    }

    public double GetPrice()
    {
        return this.Price * this.Quantity;
    }

    public string GetName()
    {
        return this.Name;
    }

    public string GetID()
    {
        return this.Id;
    }

    public int GetQuantity()
    {
        return this.Quantity;
    }
}