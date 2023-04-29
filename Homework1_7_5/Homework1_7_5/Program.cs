using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Homework1_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stew> stews = new List<Stew>
            {
                new Stew ("Бабкина", 2010, 5),
                new Stew ("Бабкина", 2019, 5),
                new Stew ("Мамкина", 2015, 4),
                new Stew ("Мамкина", 2020, 4),
                new Stew ("Папкина", 2016, 7),
                new Stew ("Папкина", 2021, 7),
                new Stew ("Дедкина", 2000, 8),
                new Stew ("Дедкина", 2012, 8),
                new Stew ("Сестринка", 2018, 6),
                new Stew ("Сестринка", 2022, 6)
            };

            int todayYear = DateTime.Now.Year;

            var overdueStews = stews.Where(stew => stew.ProductionYear + stew.ShelfLifeYear < todayYear);

            foreach (var stew in overdueStews)
            {
                stew.ShowInfo();
            }
        }
    }

    class Stew
    {
        public Stew(string name, int productionYear, int shelfLifeYear)
        {
            Name = name;
            ProductionYear = productionYear;
            ShelfLifeYear = shelfLifeYear;
        }

        public string Name { get; private set; }
        public int ProductionYear { get; private set; }
        public int ShelfLifeYear { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}, год производства: {ProductionYear}, срок годности: {ShelfLifeYear}");
        }
    }
}