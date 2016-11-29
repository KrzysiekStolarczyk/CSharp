using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuszowyExpert.Models
{
    public class Cars
    {
        public List<Cars> ListOfCars= new List<Cars>();

        private string Country;      
        private string Mark;
        private string Model;
        private string Series;
        private string Body;
        private string FuelType;
        private int YearOfproduction;
        private int Miliage;
        private int EngineCapacity;
        private int Power;
        private string LocationPhotos ;

        private Cars(string country, string mark, string model, string series, string body, string fueltype, int yearofproduction, int miliage, int enginecapacity, int power, string locationphotos)
        {
            this.Country = country;
            this.Mark = mark;
            this.Model = model;
            this.Series = series;
            this.Body = body;
            this.FuelType = fueltype;
            this.YearOfproduction = yearofproduction;
            this.Miliage = miliage;
            this.EngineCapacity = enginecapacity;
            this.Power = power;
            this.LocationPhotos = locationphotos;
            
        }

        public void AddCarsToList()
        {
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B8", "Sedan", "Benzyna", 2009, 173000, 2500, 250, "Audi A4 B8 Sedan.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A4", "B8", "Kombi", "Diesel", 2012, 200000, 3500, 220, "Audi A4 B8 Kombi.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A6", "C7", "Sedan", "Benzyna", 2012, 120000, 1800, 177, "Audi A6 C7 Sedan.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "AUDI", "A6", "C5", "Kombi", "Diesel", 2009, 145000, 2000, 179, "Audi A6 C5 Kombi.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "F10", "Seria 5", "Sedan", "Benzyna", 2012, 173000, 2300, 204, "BMW F10 2012.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E36", "Seria 3", "Coupe", "Benzyna", 1993, 258000, 2500, 192, "BMW E36.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "BMW", "E46", "Seria 3", "Kombi", "Benzyna", 2002, 188000, 2000, 150, "BMW E46.jpg"));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Seicento", "Hobby", "Hatchback", "Benzyna", 1999, 244000, 900, 38, "Fiat Seicento 900.jpg"));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Seicento", "Active", "Hatchback", "Benzyna", 2005, 189000, 1100, 54, "Fiat Seicento 1100.JPG"));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Panda", "II", "Hatchback", "Benzyna", 2005, 150000, 1200, 60, "Fiat Panda II.jpg"));
            ListOfCars.Add(new Cars("Włochy", "FIAT", "Punto", "II typ 188", "Hatchback", "Diesel", 2008, 165000, 1900, 80, "Fiat Punto II.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Hatchback", "Benzyna", 2004, 188000, 1400, 90, "Opel Astra H Hatchback.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA H", "Classic III", "Kombi", "Diesel", 2007, 168000, 1700, 110, "Opel Astra H Kombi.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA J", "IV", "Sedan", "Diesel", 2007, 138000, 1600, 136, "Opel Astra J Sedan.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Diesel", 2015, 72000, 1600, 136, "Opel Astra K Hatchback.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "OPEL", "ASTRA K", "V", "Hatchback", "Benzyna", 2016, 56000, 1600, 200, "Opel Astra K Hatchback.jpg"));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W210", "E200", "Sedan", "Benzyna", 1995, 456000, 2000, 136, "Mercedes W210 E200.JPG"));
            ListOfCars.Add(new Cars("Niemcy", "MERCEDES-BENZ", "W220", "S600", "Sedan", "Benzyna", 2002, 264000, 5800, 367, "Mercedes W220 S600.jpg"));
        }

        public Cars()
        {

        }




    }




}
