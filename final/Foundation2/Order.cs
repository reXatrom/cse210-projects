using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> ProductList;
    private Customer _customer;
    private double ShippingPrice;

    public Order(List<Product> productList, Customer customer)
    {
        this.ProductList = productList;
        this._customer = customer;
        this.ShippingPrice = SetShippingPrice();
    }

    public string PackingLabel()
    {
        string str = "";

        foreach(Product item in this.ProductList){
            str += ($"Name:{item.GetName()} - ID:{item.GetID()}\n");
        }
        return str;
    }

    public string ShippingLabel()
    {
        return $"{this._customer.GetName()}\n{this._customer.GetAddress()}";   
    }

    private double SetShippingPrice()
    {
        if(this._customer.LiveInUSA()){ return 5.00;}
        return 35.00;
    }

    public double TotalPrice(){
        double price = 0;

        foreach(Product item in this.ProductList)
        {
            price += item.GetPrice();
        }

        price += this.ShippingPrice;
        return price;
    }
    
    public double GetShippingPrice()
    {
        return this.ShippingPrice;
    }
}