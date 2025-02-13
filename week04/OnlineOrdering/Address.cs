public class Address
{
    private string street;
    private string city;
    private string province;
    private string country;

    public Address(string street, string city, string province, string country)
    {
        this.street = street;
        this.city = city;
        this.province = province;
        this.country = country;
    }

    public string Street
    {
        get { return street; }
    }

    public string City
    {
        get { return city; }
    }

    public string Province
    {
        get { return province; }
    }

    public string Country
    {
        get { return country; }
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{street}\n{city}\n{province}, {country}";
    }
}
