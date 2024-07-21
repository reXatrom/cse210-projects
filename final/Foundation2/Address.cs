using System;
using System.Collections.Generic;

public class Address
{
    private string StreetAddress;
    private string City;
    private string State;
    private string Country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.StreetAddress = streetAddress;
        this.City = city;
        this.State = state;
        this.Country = country;
    }

    public string GetAddress()
    {
        return $"{this.StreetAddress}, {this.City}, {this.State}, {this.Country}";
    }

    public bool LivesInUSA()
    {
        if(this.Country.ToLower() == "usa"){return true;}
        return false;
    }

    public string GetStreetAddress()
    {
        return this.StreetAddress;
    }

    public string GetCity()
    {
        return this.City;
    }

    public string GetState()
    {
        return this.State;
    }

    public string GetCountry()
    {
        return this.Country;
    }

}