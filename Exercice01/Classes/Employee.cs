using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Classes;

internal class Employee
{
    private int _registrationNumber;
    private string _service;
    private string _category;
    private string _name = "salarié par défaut";
    private double _salary = 16236.00;
    private static double _totalSalary = 0;
    private static int _totalEmployee = 0;

    public int RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }
    public string Service { get => _service; set => _service = value; }
    public string Category { get => _category; set => _category = value; }
    public string Name { get => _name; set => _name = value; }
    public double Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _totalSalary -= _salary;
            _salary = value;
            _totalSalary += value;
        }
    }
    public static double TotalSalary { get; }
    public static int TotalEmployee { get; }

    public Employee()
    {
        _totalEmployee++;
        _totalSalary += _salary;
    }

    public Employee(int registrationNumber, string service, string category, string name, double salary)
    {
        RegistrationNumber = registrationNumber;
        Service = service;
        Category = category;
        Name = name;
        Salary = salary;
        _totalSalary += salary;
        _totalEmployee++;
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Le salaire de {Name} est de {Salary} Euros");
    }

    public static void Infos()
    {
        Console.WriteLine($"Nombre de salariés : {_totalEmployee}\nSalaire total : {_totalSalary} Euros");
    }

    public void ChangerSalaire(double newSalaire)
    {
        _totalSalary -= this.Salary;
        Salary = newSalaire;
        _totalSalary += newSalaire;
    }

    public static void ReinitializeNbOfEmployee()
    {
        _totalEmployee = 0;
        _totalSalary = 0;
        Console.WriteLine("Remise à zéro des salariés et salaire total.");
    }
}
