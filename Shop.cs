using System;

public class Shop
{
    private string shopName;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string email;
    private double shopArea;

    public Shop(string name, string addr, string description, string phone, string email, double area)
    {
        shopName = name;
        address = addr;
        profileDescription = description;
        contactPhone = phone;
        this.email = email;
        shopArea = area;
    }

    public void SetShopName(string name)
    {
        shopName = name;
    }

    public string GetShopName()
    {
        return shopName;
    }

    public void SetAddress(string addr)
    {
        address = addr;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetProfileDescription(string description)
    {
        profileDescription = description;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public double ShopArea
    {
        get { return shopArea; }
        set { shopArea = value; }
    }

    public void IncreaseShopArea(double amount)
    {
        shopArea += amount;
    }

    public void DecreaseShopArea(double amount)
    {
        if (shopArea - amount >= 0)
            shopArea -= amount;
        else
            Console.WriteLine("Неможливо зменшити площу магазину.");
    }

    public static bool operator ==(Shop shop1, Shop shop2)
    {
        return shop1.shopArea == shop2.shopArea;
    }

    public static bool operator !=(Shop shop1, Shop shop2)
    {
        return shop1.shopArea != shop2.shopArea;
    }

    public static bool operator >(Shop shop1, Shop shop2)
    {
        return shop1.shopArea > shop2.shopArea;
    }

    public static bool operator <(Shop shop1, Shop shop2)
    {
        return shop1.shopArea < shop2.shopArea;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Shop shop = (Shop)obj;
        return this.shopArea == shop.shopArea;
    }

    public override int GetHashCode()
    {
        return shopArea.GetHashCode();
    }

    public void DisplayShopInfo()
    {
        Console.WriteLine($"Назва магазину: {shopName}");
        Console.WriteLine($"Адреса: {address}");
        Console.WriteLine($"Опис профілю магазину: {profileDescription}");
        Console.WriteLine($"Контактний телефон: {contactPhone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Площа магазину: {shopArea} кв. м.");
    }
}
