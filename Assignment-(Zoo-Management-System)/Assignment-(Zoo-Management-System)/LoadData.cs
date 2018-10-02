using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    public class LoadData
    {
        private static BindingList<Employee> emps = MyEmployees();

        public static BindingList<Employee> MyEmployees()
        {
            Employee.Employees.Add(new CareTaker()
            {
                ID = "E001",
                FirstName = "Sok",
                LastName = "Dara",
                Gender = Gender._Gender.Male,
                Age = 20,
                WorkDate = "20 October 2000",
                _Salary = 200
            });

            Employee.Employees.Add(new CareTaker()
            {
                ID = "E002",
                FirstName = "Keo",
                LastName = "Thida",
                Gender = Gender._Gender.Female,
                Age = 25,
                WorkDate = "21 September 2002",
                _Salary = 220
            });

            Employee.Employees.Add(new Security()
            {
                ID = "E003",
                FirstName = "Chan",
                LastName = "Tola",
                Gender = Gender._Gender.Male,
                Age = 25,
                WorkDate = "21 December 2004",
                _Salary = 150
            });

            Employee.Employees.Add(new Security()
            {
                ID = "E004",
                FirstName = "Heng",
                LastName = "Peaktra",
                Gender = Gender._Gender.Male,
                Age = 25,
                WorkDate = "2 December 2001",
                _Salary = 150
            });

            return Employee.Employees;
        }
        public static void Animals()
        {
            Animal.Animals.Add(new Lion()
            {
                ID = "A001",
                Name = "Lulu",
                Gender = Gender._Gender.Male,
                _Age = new Age() { Year = 2, Month = 4 },
                _Weight = 200,
                CageType = Cage.Type.Metal,
                CareTaker = (CareTaker)emps[0],
                TypeOfFood = "Meat, large-body prey, ..",
                _Region = MyRegion.From.Afica
            });

            Animal.Animals.Add(new Tiger()
            {
                ID = "A002",
                Name = "Lili",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 7 },
                _Weight = 200,
                CageType = Cage.Type.Metal,
                CareTaker = (CareTaker)emps[0],
                TypeOfFood = "Meat, large-body prey, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Elephant()
            {
                ID = "A003",
                Name = "Momo",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Month = 2, Year = 4 },
                _Weight = 200,
                CageType = Cage.Type.Wood,
                CareTaker = (CareTaker)emps[1],
                TypeOfFood = "Vegetation, grasses, small plants, bushes, fruit, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Penguin()
            {
                ID = "A004",
                Name = "Piggi",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 1 },
                _Weight = 20,
                CageType = Cage.Type.Free_Lane,
                CareTaker = (CareTaker)emps[1],
                TypeOfFood = "Krill (a shrimp-like crustacean in the Family Euphausiidae), squids, and fishes.",
                _Region = MyRegion.From.Antarctica
            });

            Animal.Animals.Add(new Peocock()
            {
                ID = "A005",
                Name = "Nana",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 5, Month = 6 },
                _Weight = 17,
                CageType = Cage.Type.Wood,
                CareTaker = (CareTaker)emps[0],
                TypeOfFood = "Seed, insects, fruit, ..",
                _Region = MyRegion.From.Asia
            });

            Animal.Animals.Add(new Cichild()
            {
                ID = "A006",
                Name = "Sylar",
                Gender = Gender._Gender.Female,
                _Age = new Age() { Year = 3, Month = 5 },
                _Weight = 17,
                CageType = Cage.Type.Aqurium,
                CareTaker = (CareTaker)emps[0],
                TypeOfFood = "Small-fish, snail, some plant",
                _Region = MyRegion.From.Afica
            });
        }     
    }
}
