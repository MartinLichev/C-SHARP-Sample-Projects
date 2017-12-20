using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CountriesAndCapitals.Data;
using CountriesAndCapitals.Models;

namespace DataAccessLayer
{
    public class Program
    {
        public static CountriesAndCapitalsDbContext data = new CountriesAndCapitalsDbContext();

        public static void Main(string[] args)
        {

            Countries country = new Countries
            {
                Name = "Bolivia",
                Id = 1,
                Size = 2000000,
                Population = 10000000,
                ContinentLocation = "South America",

            };

            Countries country1 = new Countries
            {
                Name ="Brazil",
                Id=1,
                Size = 30000000,
                Population = 100000000,
                ContinentLocation = "South America",
            };

            Capitals capital = new Capitals
            {
                CountryName = "Bulgaria",
                Name = "Sofia",
                Id = 2,
                Population = 40000000,
                Size = 2000000,
            };

            Capitals capital1 = new Capitals
            {
                Name ="Berlin",
                Population = 1000000,
                Size = 100000,
                Id = 3,
                CountryName = "Germany",

            };

            CreateCapitalRecord(capital);

            CreateCountriesRecord(country);

            ReadFromCapitals();

            ReadFromCountries();

            DeleteFromCapitals(7);

            DeleteFromCountries(1);

            UpdateCountriesRecord(country1, 1);








        }


        public static void CreateCapitalRecord(Capitals item)
        {
            data.Capitals.Add(item);

            data.SaveChanges();
        }

        public static void CreateCountriesRecord(Countries item)
        {
            data.Countries.Add(item);

            data.SaveChanges();
        }

        public static void ReadFromCountries()
        {
            var select = data.Countries.ToList();


            foreach (var element in select)
            {
                Console.WriteLine($"{element.Id} {element.Name} {element.Size} {element.Population} {element.ContinentLocation}");
            }
        }

        public static void ReadFromCapitals()
        {
            var select = data.Capitals.ToList();

            foreach (var element in select)
            {
                Console.WriteLine($"{element.Id} {element.CountryName} {element.Name} {element.Population} {element.Size}");
            }
        }

        public static void DeleteFromCountries(int id)
        {
            var select = data.Countries.FirstOrDefault(a => a.Id == id);

            if (select != null)
            {
                data.Countries.Remove(select);

                data.SaveChanges();
            }

        }

        public static void DeleteFromCapitals(int id)
        {
            var select = data.Capitals.FirstOrDefault(a => a.Id == id);

            if (select != null)
            {

                data.Capitals.Remove(select);

                data.SaveChanges();
            }
        }

        public static void UpdateCapitalsRecord(Capitals item, int id)
        {
            try
            {
                
                var databaseitem = data.Capitals.FirstOrDefault(a => a.Id == id);

                if(databaseitem != null)
                {
                    databaseitem.CountryName = item.CountryName;
                    databaseitem.Id = item.Id;
                    databaseitem.Name = item.Name;
                    databaseitem.Population = item.Population;
                    databaseitem.Size = item.Size;
                }

                data.Capitals.Add(item);

                data.SaveChanges();

            }
            catch (SystemException)
            {
                Console.WriteLine("RECORD WITH SUCH \"ID\" DOES NOT EXIST IN THE DATA-BASE, PLEASE TRY AGAIN!");
            }

        }

        public static void UpdateCountriesRecord(Countries item, int id)
        {
            try
            {

                var databaseitem = data.Countries.FirstOrDefault(a => a.Id == id);

                if(databaseitem != null)
                {
                    databaseitem.Id = item.Id;
                    databaseitem.Name = item.Name;
                    databaseitem.Population = item.Population;
                    databaseitem.Size = item.Size;
                    databaseitem.ContinentLocation = item.ContinentLocation;
                }

                data.Countries.Add(item);

                data.SaveChanges();

            }
            catch(SystemException)
            {
                Console.WriteLine("RECORD, WITH SUCH \"ID\" DOES NOT EXIST IN THE DATA-BASE, PLEASE TRY AGAIN!");
            }
        }
    }
}
