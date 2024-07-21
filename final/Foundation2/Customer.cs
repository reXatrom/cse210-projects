using System;
using System.Collections.Generic;

public class Customer
{
    private string Name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this.Name = name;
        this._address = address;
    }

    public bool LiveInUSA()
    {
        return this._address.LivesInUSA();
    }

    public string GetName()
    {
        return this.Name;
    }

    public string GetAddress()
    {
        return this._address.GetAddress();
    }
}