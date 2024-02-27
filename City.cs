using System;

public class City
{
    private string cityName;
    private string countryName;
    private int population;
    private int areaCode;
    private string[] districts;

    public City(string cityName, string countryName, int population, int areaCode, string[] districts)
    {
        this.cityName = cityName;
        this.countryName = countryName;
        this.population = population;
        this.areaCode = areaCode;
        this.districts = districts;
    }

    public void SetCityName(string cityName)
    {
        this.cityName = cityName;
    }

    public string GetCityName()
    {
        return cityName;
    }

    public void SetCountryName(string countryName)
    {
        this.countryName = countryName;
    }

    public string GetCountryName()
    {
        return countryName;
    }

    public void SetPopulation(int population)
    {
        this.population = population;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetAreaCode(int areaCode)
    {
        this.areaCode = areaCode;
    }

    public int GetAreaCode()
    {
        return areaCode;
    }

    public void SetDistricts(string[] districts)
    {
        this.districts = districts;
    }

    public string[] GetDistricts()
    {
        return districts;
    }

    public int Population
    {
        get { return population; }
        set { population = value; }
    }

    public static City operator +(City city, int increment)
    {
        city.population += increment;
        return city;
    }

    public static City operator -(City city, int decrement)
    {
        city.population -= decrement;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.population == city2.population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.population < city2.population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.population > city2.population;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        City other = (City)obj;
        return this.population == other.population;
    }

    public override int GetHashCode()
    {
        return population.GetHashCode();
    }

    public void DisplayCityInfo()
    {
        Console.WriteLine($"Місто: {cityName}");
        Console.WriteLine($"Країна: {countryName}");
        Console.WriteLine($"Кількість жителів: {population}");
        Console.WriteLine($"Телефонний код: {areaCode}");
        Console.WriteLine("Райони міста:");
        foreach (string district in districts)
        {
            Console.WriteLine($"- {district}");
        }
    }
}
