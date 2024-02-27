using System;

public class Journal
{
    private string journalName;
    private int foundationYear;
    private string description;
    private string contactPhone;
    private string email;
    private int numberOfEmployees;

    public Journal(string name, int year, string desc, string phone, string email, int employees)
    {
        journalName = name;
        foundationYear = year;
        description = desc;
        contactPhone = phone;
        this.email = email;
        numberOfEmployees = employees;
    }

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetFoundationYear(int year)
    {
        foundationYear = year;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public void SetDescription(string desc)
    {
        description = desc;
    }

    public string GetDescription()
    {
        return description;
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

    public int NumberOfEmployees
    {
        get { return numberOfEmployees; }
        set { numberOfEmployees = value; }
    }

    public void IncreaseEmployees(int amount)
    {
        numberOfEmployees += amount;
    }

    public void DecreaseEmployees(int amount)
    {
        if (numberOfEmployees - amount >= 0)
            numberOfEmployees -= amount;
        else
            Console.WriteLine("Неможливо зменшити кількість працівників.");
    }

    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees == journal2.numberOfEmployees;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees != journal2.numberOfEmployees;
    }

    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees > journal2.numberOfEmployees;
    }

    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees < journal2.numberOfEmployees;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Journal journal = (Journal)obj;
        return this.numberOfEmployees == journal.numberOfEmployees;
    }

    public override int GetHashCode()
    {
        return numberOfEmployees.GetHashCode();
    }

    public void DisplayJournalInfo()
    {
        Console.WriteLine($"Назва журналу: {journalName}");
        Console.WriteLine($"Рік заснування: {foundationYear}");
        Console.WriteLine($"Опис журналу: {description}");
        Console.WriteLine($"Контактний телефон: {contactPhone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Кількість працівників: {numberOfEmployees}");
    }
}
