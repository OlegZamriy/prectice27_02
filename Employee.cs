using System;

public class Employee
{
    private string fullName;
    private DateTime dateOfBirth;
    private string contactPhone;
    private string workEmail;
    private string position;
    private string jobDescription;
    private double salary;

    public Employee(string fullName, DateTime dateOfBirth, string contactPhone, string workEmail, string position, string jobDescription, double salary)
    {
        this.fullName = fullName;
        this.dateOfBirth = dateOfBirth;
        this.contactPhone = contactPhone;
        this.workEmail = workEmail;
        this.position = position;
        this.jobDescription = jobDescription;
        this.salary = salary;
    }

    public void SetFullName(string fullName)
    {
        this.fullName = fullName;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void SetDateOfBirth(DateTime dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
    }

    public DateTime GetDateOfBirth()
    {
        return dateOfBirth;
    }

    public void SetContactPhone(string contactPhone)
    {
        this.contactPhone = contactPhone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetWorkEmail(string workEmail)
    {
        this.workEmail = workEmail;
    }

    public string GetWorkEmail()
    {
        return workEmail;
    }

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public string GetPosition()
    {
        return position;
    }

    public void SetJobDescription(string jobDescription)
    {
        this.jobDescription = jobDescription;
    }

    public string GetJobDescription()
    {
        return jobDescription;
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public void IncreaseSalary(double amount)
    {
        salary += amount;
    }

    public void DecreaseSalary(double amount)
    {
        if (salary - amount >= 0)
            salary -= amount;
        else
            Console.WriteLine("Неможливо зменшити заробітну плату.");
    }

    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.salary == employee2.salary;
    }

    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.salary != employee2.salary;
    }

    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.salary > employee2.salary;
    }

    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.salary < employee2.salary;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Employee employee = (Employee)obj;
        return this.salary == employee.salary;
    }

    public override int GetHashCode()
    {
        return salary.GetHashCode();
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"ПІБ: {fullName}");
        Console.WriteLine($"Дата народження: {dateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Контактний телефон: {contactPhone}");
        Console.WriteLine($"Робочий email: {workEmail}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Опис службових обов'язків: {jobDescription}");
        Console.WriteLine($"Заробітна плата: {salary}");
    }
}
